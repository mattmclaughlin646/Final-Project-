Imports System.Data
Imports System.Security.Cryptography
Imports System.IO
Imports System.Xml
Imports System.Text
Imports System.Data.SqlClient

Partial Class searchDeletePrescription
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Panel2.Visible = False

        Page.ClientScript.RegisterClientScriptInclude("Test", "MyScript.js")

    End Sub
    Protected Sub btnSearch_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSearch.Click

        'retrieve studentid, fname, and lname
        Dim lname As String
        Dim rxID As String
        Dim fname As String

        Try
            With Me
                'studentid = txtStudentID.Text.Trim
                fname = txtPatfname.Text.Trim
                lname = txtPatlname.Text.Trim
                rxID = txtRXid.Text.Trim

                'store values as viewstate
                'ViewState("studentid") = studentid
                ViewState("fname") = fname
                ViewState("lname") = lname
                ViewState("rxID") = rxID

                'load the data
                LoadData()

            End With
        Catch ex As Exception

        End Try

    End Sub

    Private Sub LoadData()

        With Me
            'retrieve dataset
            Dim aStudentDatatier As New clientdatatier
            Dim aDataset As New DataSet

            aDataset = aStudentDatatier.SearchNameInRX(CType(ViewState("lname"), String), CType(ViewState("fname"), String), CType(ViewState("rxID"), String))
            'bind datagrid
            grdRX.DataSource = aDataset.Tables(0)
            grdRX.DataBind()
        End With


    End Sub
    Public Sub lbtnView_Clicks(ByVal sender As Object, ByVal e As CommandEventArgs)
        Dim recordToBeEdited As String

        Try

            'Get the record
            recordToBeEdited = Trim(e.CommandArgument)


            'this script will open a popup
            Dim sb As New StringBuilder


            sb.Append("<script language='javascript'>")
            sb.Append("window.open('viewRX.aspx?ID=" + Encrypt(recordToBeEdited.ToString) + "&type=Edit" + "'  , 'patient',")

            sb.Append("'width=725, height=725, menubar=no, resizable=yes, left=50, top=50, scrollbars=yes');<")
            sb.Append("/script>")

            'register with ClientScript
            ClientScript.RegisterClientScriptBlock(GetType(Page), "PopupScript", sb.ToString())
        Catch ex As Exception
            Throw New Exception(ex.Message, ex.InnerException)
        End Try
    End Sub
    Public Sub lbtnDelete_Clicks(ByVal sender As Object, ByVal e As CommandEventArgs)

        Try

            Dim chk As CheckBox
            Dim lbl As Label
            Dim stu_ID As String
            Dim aDatatier As New clientdatatier
            If grdRX.Rows.Count > 0 Then

                'For Each row
                For Each row As GridViewRow In grdRX.Rows
                    chk = CType(row.FindControl("chkStudId"), CheckBox)
                    'is checkbox checked
                    If chk.Checked = True Then
                        lbl = CType(row.Controls(0).FindControl("hidStudID"), Label)
                        stu_ID = lbl.Text.ToString.Trim
                        ''delete the record one at a time
                        aDatatier.DELETE_PRESCRIPTION(stu_ID)

                    End If
                Next

                'refresh datagrid
                LoadData()

            End If

        Catch ex As Exception
            Throw New Exception(ex.Message, ex.InnerException)
        End Try
    End Sub


    Private Function Encrypt(clearText As String) As String
        Dim EncryptionKey As String = "MAKV2SPBNI99212"
        Dim clearBytes As Byte() = Encoding.Unicode.GetBytes(clearText)
        Using encryptor As Aes = Aes.Create()
            Dim pdb As New Rfc2898DeriveBytes(EncryptionKey, New Byte() {&H49, &H76, &H61, &H6E, &H20, &H4D,
         &H65, &H64, &H76, &H65, &H64, &H65,
         &H76})
            encryptor.Key = pdb.GetBytes(32)
            encryptor.IV = pdb.GetBytes(16)
            Using ms As New MemoryStream()
                Using cs As New CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write)
                    cs.Write(clearBytes, 0, clearBytes.Length)
                    cs.Close()
                End Using
                clearText = Convert.ToBase64String(ms.ToArray())
            End Using
        End Using
        Return clearText
    End Function


    Protected Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        txtPatfname.Text = ""
        txtPatlname.Text = ""
        txtRXid.Text = ""

    End Sub
End Class

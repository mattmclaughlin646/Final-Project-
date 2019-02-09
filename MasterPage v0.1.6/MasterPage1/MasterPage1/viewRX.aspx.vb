Imports System.Data
Imports System.Security.Cryptography
Imports System.IO
Imports System.Xml
Imports System.Text


Partial Class viewRX
    Inherits System.Web.UI.Page

    Private Function Decrypt(cipherText As String) As String
        Dim EncryptionKey As String = "MAKV2SPBNI99212"
        cipherText = cipherText.Replace(" ", "+")
        Dim cipherBytes As Byte() = Convert.FromBase64String(cipherText)
        Using encryptor As Aes = Aes.Create()
            Dim pdb As New Rfc2898DeriveBytes(EncryptionKey, New Byte() {&H49, &H76, &H61, &H6E, &H20, &H4D,
             &H65, &H64, &H76, &H65, &H64, &H65,
             &H76})
            encryptor.Key = pdb.GetBytes(32)
            encryptor.IV = pdb.GetBytes(16)
            Using ms As New MemoryStream()
                Using cs As New CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write)
                    cs.Write(cipherBytes, 0, cipherBytes.Length)
                    cs.Close()
                End Using
                cipherText = Encoding.Unicode.GetString(ms.ToArray())
            End Using
        End Using
        Return cipherText
    End Function

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim myid, myedit As String
        'Dim gender As String

        myedit = ""
        If Not IsPostBack Then
            'retrieve querystring
            myid = Decrypt(Request.QueryString("ID").Trim)


            'make sure there is a querystring
            If Not IsNothing(Request.QueryString("type")) And (Request.QueryString("type") <> String.Empty) Then
                myedit = Request.QueryString("type").Trim

            End If

            'retrieve record from table
            Dim studData As New clientdatatier
            Dim ds As New DataSet

            ds = studData.searchRX(myid)

            'is edit
            If myedit.ToUpper = "EDIT" Then


                'populate the controls
                With Me
                    .txtPatientID.Text = ds.Tables(0).Rows(0)("PATIENT_ID").ToString
                    .txtFname.Text = ds.Tables(0).Rows(0)("PATIENTFNAME").ToString
                    .txtLname.Text = ds.Tables(0).Rows(0)("PATIENTLNAME").ToString
                    .txtPname.Text = ds.Tables(0).Rows(0)("MEDNAME").ToString
                    .txtPrescriptionID.Text = ds.Tables(0).Rows(0)("RXNUM").ToString
                    .txtRefill.Text = ds.Tables(0).Rows(0)("REFILL").ToString
                    .ddlIntakeMethod.Text = ds.Tables(0).Rows(0)("INTAKE").ToString
                    .txtDosage.Text = ds.Tables(0).Rows(0)("DOSAGE").ToString
                    .txtFrequence.Text = ds.Tables(0).Rows(0)("FREQ").ToString
                    .txtDoctorID.Text = ds.Tables(0).Rows(0)("STAFF_ID").ToString
                    .txtDoctorFname.Text = ds.Tables(0).Rows(0)("DOCTORSFNAME").ToString
                    .txtDoctorLname.Text = ds.Tables(0).Rows(0)("DOCTORSLNAME").ToString
                    .txtdate.Text = ds.Tables(0).Rows(0)("DATEPRESCRIBED").ToString
                    '    'gender = ds.Tables(0).Rows(0)("GENDER").ToString
                    '    '.ddlGender.SelectedItem.Text = gender

                End With

                'ddlState.DataSource = StateManager.getStates()
                'ddlState.DataTextField = "FullAndAbbrev"
                'ddlState.DataValueField = "abbreviation"
                'ddlState.SelectedValue = "PA"
                'ddlState.DataBind()

            Else    'not edit




                'populate the controls
                With Me
                    .txtPatientID.Text = ds.Tables(0).Rows(0)("PATIENT_ID").ToString
                    .txtFname.Text = ds.Tables(0).Rows(0)("PATIENTFNAME").ToString
                    .txtLname.Text = ds.Tables(0).Rows(0)("PATIENTLNAME").ToString
                    .txtPname.Text = ds.Tables(0).Rows(0)("MEDNAME").ToString
                    .txtPrescriptionID.Text = ds.Tables(0).Rows(0)("RXNUM").ToString
                    .txtRefill.Text = ds.Tables(0).Rows(0)("REFILL").ToString
                    .ddlIntakeMethod.Text = ds.Tables(0).Rows(0)("INTAKE").ToString
                    .txtDosage.Text = ds.Tables(0).Rows(0)("DOSAGE").ToString
                    .txtFrequence.Text = ds.Tables(0).Rows(0)("FREQ").ToString
                    .txtDoctorID.Text = ds.Tables(0).Rows(0)("STAFF_ID").ToString
                    .txtDoctorFname.Text = ds.Tables(0).Rows(0)("DOCTORSFNAME").ToString
                    .txtDoctorLname.Text = ds.Tables(0).Rows(0)("DOCTORSLNAME").ToString
                    .txtdate.Text = ds.Tables(0).Rows(0)("DATEPRESCRIBED").ToString
                    'gender = ds.Tables(0).Rows(0)("GENDER").ToString
                    '.ddlGender.SelectedItem.Text = gender
                    '.ddlGender.Enabled = False
                End With

                'ddlState.DataSource = StateManager.getStates()
                'ddlState.DataTextField = "FullAndAbbrev"
                'ddlState.DataValueField = "abbreviation"
                'ddlState.SelectedValue = "PA"
                'ddlState.DataBind()
            End If
        End If

        Dim studid As String
        Dim aStudentDateTier As New clientdatatier
        Page.ClientScript.RegisterClientScriptInclude("Test", "MyScript.js")
        If Not Request.QueryString("ID").ToString = String.Empty Then
            studid = CType(Request.QueryString("ID"), String)
        End If

        'If Not Request.QueryString("Type").ToString = String.Empty Then
        '    mytype = CType(Request.QueryString("type"), String)
        'End If

        'If Not IsPostBack Then
        '    If mytype.ToUpper = "EDIT" Then
        '        btnUpdate.Text = "UPDATE"
        '        btnUpdate.ForeColor = Drawing.Color.Red

        '        Dim adataset As New DataSet
        '        adataset = astudentdatatier.GetStudentByID()
        '        With Me
        '            .txtstudentID.Text =
        '                adataset.Tables(0).Rows(0)("student_id").ToString
        '        End With
        '    End If
        'End If

    End Sub


    Protected Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

        'close the form
        Page.ClientScript.RegisterClientScriptBlock(Me.GetType(), "closeform", "CloseMe()", True)

    End Sub


    Protected Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click

        Response.Redirect("~/Home.aspx")

    End Sub


End Class

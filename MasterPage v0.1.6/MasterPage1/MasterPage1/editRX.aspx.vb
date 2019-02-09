Imports System.Data
Imports System.Security.Cryptography
Imports System.IO
Imports System.Xml
Imports System.Text


Partial Class editRX
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
                    .lblPatientID.Text = ds.Tables(0).Rows(0)("PATIENT_ID").ToString
                    .lblFname.Text = ds.Tables(0).Rows(0)("PATIENTFNAME").ToString
                    .lblLname.Text = ds.Tables(0).Rows(0)("PATIENTLNAME").ToString
                    .txtPname.Text = ds.Tables(0).Rows(0)("MEDNAME").ToString
                    .lblPrescriptionID.Text = ds.Tables(0).Rows(0)("RXNUM").ToString
                    .txtRefill.Text = ds.Tables(0).Rows(0)("REFILL").ToString
                    .ddlIntakeMethod.Text = ds.Tables(0).Rows(0)("INTAKE").ToString
                    .txtDosage.Text = ds.Tables(0).Rows(0)("DOSAGE").ToString
                    .txtFrequence.Text = ds.Tables(0).Rows(0)("FREQ").ToString
                    .lblDoctorID.Text = ds.Tables(0).Rows(0)("STAFF_ID").ToString
                    .lblDoctorFname.Text = ds.Tables(0).Rows(0)("DOCTORSFNAME").ToString
                    .lblDoctorLname.Text = ds.Tables(0).Rows(0)("DOCTORSLNAME").ToString
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
                    .lblPatientID.Text = ds.Tables(0).Rows(0)("PATIENT_ID").ToString
                    .lblFname.Text = ds.Tables(0).Rows(0)("PATIENTFNAME").ToString
                    .lblLname.Text = ds.Tables(0).Rows(0)("PATIENTLNAME").ToString
                    .txtPname.Text = ds.Tables(0).Rows(0)("MEDNAME").ToString
                    .lblPrescriptionID.Text = ds.Tables(0).Rows(0)("RXNUM").ToString
                    .txtRefill.Text = ds.Tables(0).Rows(0)("REFILL").ToString
                    .ddlIntakeMethod.Text = ds.Tables(0).Rows(0)("INTAKE").ToString
                    .txtDosage.Text = ds.Tables(0).Rows(0)("DOSAGE").ToString
                    .txtFrequence.Text = ds.Tables(0).Rows(0)("FREQ").ToString
                    .lblDoctorID.Text = ds.Tables(0).Rows(0)("STAFF_ID").ToString
                    .lblDoctorFname.Text = ds.Tables(0).Rows(0)("DOCTORSFNAME").ToString
                    .lblDoctorLname.Text = ds.Tables(0).Rows(0)("DOCTORSLNAME").ToString
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



    Protected Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim strRXNUM, strMEDNAME, strPatient_ID, strPATIENTFNAME, strPATIENTLNAME, strREFILL, strINTAKE, strDOSAGE, strFREQ, strSTAFF_ID, strDOCTORSFNAME, strDOCTORSLNAME, strDATEPRESCRIBED As String

        Try
            strRXNUM = lblPrescriptionID.Text.Trim
            strMEDNAME = txtPname.Text.Trim
            strPatient_ID = lblPatientID.Text.Trim
            strPATIENTFNAME = lblFname.Text.Trim
            strPATIENTLNAME = lblLname.Text.Trim
            strREFILL = txtRefill.Text.Trim
            strINTAKE = ddlIntakeMethod.Text.Trim
            strDOSAGE = txtDosage.Text.Trim
            strFREQ = txtFrequence.Text.Trim
            strSTAFF_ID = lblDoctorID.Text.Trim
            strDOCTORSFNAME = lblDoctorFname.Text.Trim
            strDOCTORSLNAME = lblDoctorLname.Text.Trim
            strDATEPRESCRIBED = txtdate.Text.Trim
            If strRXNUM <> "" Then
                Dim aStudent As New clientdatatier
                aStudent.UPDATEPRESCRIPTION(strRXNUM, strMEDNAME, strPatient_ID, strPATIENTFNAME, strPATIENTLNAME, strREFILL, strINTAKE, strDOSAGE, strFREQ, strSTAFF_ID, strDOCTORSFNAME, strDOCTORSLNAME, strDATEPRESCRIBED)

                litMessage.Text = "Record added successfully!"
                'MessageBox.Show("Record Updated successfully", "Prescription", MessageBoxButtons.OK)
            Else
                'MessageBox.Show("course id is required!", "Prescription", MessageBoxButtons.OK)
            End If
        Catch ex As Exception

        End Try
    End Sub


    Protected Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

        'Try
        '    'If btnClose.Text.ToUpper = "Refresh" Then
        '    'close the page refresh the datagrid
        '    Dim cb As New StringBuilder
        '    cb.Append("opener.location.href = 'SearchRX.aspx';")
        '    cb.Append("var ie7 = (document.all && !window.opera && window.XMLHttpTequest) ? true : false;")
        '    cb.Append("if (ie7)")
        '    cb.Append(" { ")
        '    cb.Append("windows.open('','_parent', '');")
        '    cb.Append("window.close();")
        '    cb.Append(" } ")
        '    cb.Append(" else ")
        '    cb.Append(" { ")
        '    cb.Append(" this.focus();")
        '    cb.Append(" self.opener = this;")
        '    cb.Append(" self.close();")
        '    cb.Append(" }")
        '    ClientScript.RegisterClientScriptBlock(GetType(Page), "CloseReloadScript", cb.ToString(), True)

        '    'ElseIf btnClose.Text.ToUpper = "CLOSE" Then
        'close the form
        Page.ClientScript.RegisterClientScriptBlock(Me.GetType(), "closeform", "CloseMe()", True)

        '    'End If
        'Catch ex As Exception

        'End Try

    End Sub
End Class

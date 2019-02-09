Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Partial Class addPrescription
    Inherits System.Web.UI.Page

    Protected Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim strRXNUM, strMEDNAME, strPatient_ID, strPATIENTFNAME, strPATIENTLNAME, strREFILL, strINTAKE, strDOSAGE, strFREQ, strSTAFF_ID, strDOCTORSFNAME, strDOCTORSLNAME, strDATEPRESCRIBED As String
        Try
            strRXNUM = txtPrescriptionID.Text.Trim
            strMEDNAME = txtPname.Text.Trim
            strPatient_ID = txtPatientID.Text.Trim
            strPATIENTFNAME = txtFname.Text.Trim
            strPATIENTLNAME = txtLname.Text.Trim
            strREFILL = txtRefill.Text.Trim
            strINTAKE = ddlIntakeMethod.Text.Trim
            strDOSAGE = txtDosage.Text.Trim
            strFREQ = txtFrequence.Text.Trim
            strSTAFF_ID = txtDoctorID.Text.Trim
            strDOCTORSFNAME = txtDoctorFname.Text.Trim
            strDOCTORSLNAME = txtDoctorLname.Text.Trim
            strDATEPRESCRIBED = txtdate.Text.Trim
            If strPatient_id <> "" Then
                Dim aClient As New clientdatatier
                aClient.AddPrescription(strRXNUM, strMEDNAME, strPatient_ID, strPATIENTFNAME, strPATIENTLNAME, strREFILL, strINTAKE, strDOSAGE, strFREQ, strSTAFF_ID, strDOCTORSFNAME, strDOCTORSLNAME, strDATEPRESCRIBED)
                litMessage.Text = "Record added successfully!"
                'Else
                '    MessageBox.Show("Patient ID is required!", "Patient", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

            'If mskPatID.Text = "" OrElse txtPatFirst.Text = "" OrElse txtPatLast.Text = "" OrElse mskPatDOB.Text = "" Then
            '    MessageBox.Show("Required Fields must be entered!", "Patient", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'End If

        Catch ex As Exception
            Throw New ArgumentException(ex.Message)
            'MessageBox.Show("This Record Already Exists!", "Patient", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Protected Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtdate.Text = ""
        txtDoctorFname.Text = ""
        txtDoctorID.Text = ""
        txtDoctorLname.Text = ""
        ddlIntakeMethod.SelectedIndex = 0
        'rdoFemale.Checked = "false"
        'rdoMale.Checked = "false"
        txtDosage.Text = ""
        txtFname.Text = ""
        txtFrequence.Text = ""
        txtLname.Text = ""
        txtPatientID.Text = ""
        txtPname.Text = ""
        txtPrescriptionID.Text = ""
        txtRefill.Text = ""


        litMessage.Text = ""
        txtPrescriptionID.Focus()
    End Sub


    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub


    Protected Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click

        Response.Redirect("~/Home.aspx")

    End Sub


End Class

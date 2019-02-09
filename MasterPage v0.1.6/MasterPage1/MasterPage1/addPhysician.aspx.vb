
Partial Class addPhysician
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load

        With Me
            ddlState1.DataSource = StateManager.getStates()
            ddlState1.DataTextField = "FullAndAbbrev"
            ddlState1.DataValueField = "abbreviation"
            ddlState1.SelectedValue = "PA"
            ddlState1.DataBind()
        End With

    End Sub
    Protected Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        Dim strPhysician_id, strFname, strMidint, strLname, strDob, strGender, strStreet, strCity, strStateint, strZipcode, strCellphone, strHomephone, strEmail, strSpecial As String
        Dim strSalary As Decimal

        Try

            strPhysician_id = txtPhysID.Text.Trim
            strFname = txtFname.Text.Trim
            strMidint = txtMI.Text.Trim
            strLname = txtLname.Text.Trim
            strDob = txtDOB.Text.Trim
            strGender = ddlGender1.Text.Trim
            strStreet = txtStreet.Text.Trim
            strCity = txtCity.Text.Trim
            strStateint = ddlState1.SelectedValue.Trim
            strZipcode = txtZip.Text.Trim
            strCellphone = txtCell.Text.Trim
            strHomephone = txtHome.Text.Trim
            strSalary = txtSalary.Text.Trim
            strEmail = txtEmail.Text.Trim
            strSpecial = txtSpecialty.Text.Trim

            If strPhysician_id <> "" Then
                Dim aClient As New clientdatatier
                aClient.AddPhysician(strPhysician_id, strFname, strMidint, strLname, strDob, strGender, strStreet, strCity, strStateint, strZipcode, strCellphone, strHomephone, strSalary, strEmail, strSpecial)
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

        txtPhysID.Text = ""
        txtFname.Text = ""
        txtMI.Text = ""
        txtLname.Text = ""
        ddlGender1.SelectedIndex = 0
        'rdoFemale.Checked = "false"
        'rdoMale.Checked = "false"
        txtDOB.Text = ""
        txtStreet.Text = ""
        txtCity.Text = ""
        ddlState1.SelectedIndex = 42
        txtZip.Text = ""
        txtHome.Text = ""
        txtCell.Text = ""
        txtSalary.Text = ""
        txtEmail.Text = ""
        txtSpecialty.Text = ""

        litMessage.Text = ""
        txtPhysID.Focus()

    End Sub

    Protected Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click

        Response.Redirect("~/Home.aspx")

    End Sub

End Class

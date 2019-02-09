
Partial Class addPatient
    Inherits System.Web.UI.Page

    Protected Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        Dim strPatient_id, strFname, strMidint, strLname, strDob, strGender, strStreet, strCity, strStateint, strZipcode, strCellphone, strHomephone As String
        'Dim strAcctbal As Decimal

        Try

            strPatient_id = txtPatID.Text
            strFname = txtFname.Text.Trim
            strMidint = txtMI.Text.Trim
            strLname = txtLname.Text.Trim
            strDob = txtDOB.Text.Trim
            strGender = ddlGender.Text.Trim
            strStreet = txtStreet.Text.Trim
            strCity = txtCity.Text.Trim
            strStateint = ddlState.SelectedValue.Trim
            strZipcode = txtZip.Text.Trim
            strCellphone = txtCell.Text.Trim
            strHomephone = txtHome.Text.Trim
            'strAcctbal = txtBal.Text.Trim

            If strPatient_id <> "" Then
                Dim aClient As New clientdatatier
                aClient.AddPatient(strPatient_id, strFname, strMidint, strLname, strDob, strGender, strStreet, strCity, strStateint, strZipcode, strCellphone, strHomephone)
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





    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load

        With Me
            ddlState.DataSource = StateManager.getStates()
            ddlState.DataTextField = "FullAndAbbrev"
            ddlState.DataValueField = "abbreviation"
            ddlState.SelectedValue = "PA"
            ddlState.DataBind()
        End With

    End Sub

    Protected Sub ddlGender_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ddlGender.SelectedIndexChanged



    End Sub

    Protected Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        txtPatID.Text = ""
        txtFname.Text = ""
        txtMI.Text = ""
        txtLname.Text = ""
        ddlGender.SelectedIndex = 0
        'rdoFemale.Checked = "false"
        'rdoMale.Checked = "false"
        txtDOB.Text = ""
        txtStreet.Text = ""
        txtCity.Text = ""
        ddlState.SelectedIndex = 42
        txtZip.Text = ""
        txtHome.Text = ""
        txtCell.Text = ""
        'txtBal.Text = ""

        litMessage.Text = ""
        txtPatID.Focus()

    End Sub

    Protected Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click

        Response.Redirect("~/Home.aspx")

    End Sub

End Class

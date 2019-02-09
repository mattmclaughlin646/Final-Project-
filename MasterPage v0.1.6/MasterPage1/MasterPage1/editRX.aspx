<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="editRX.aspx.vb" Inherits="editRX" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style5 {
            height: 34px;
        }
        .auto-style6 {
            height: 100px;
        }
        .auto-style7 {
            margin: 0 auto;
            width: 900px;
            height: 801px;
            background-color: aquamarine;
        }
    </style>
</asp:Content>

<asp:Content ContentPlaceHolderID="cph3" Runat="Server">

    <div Align="center" class="auto-style7">

        <br />
        <br />
        <br />
        
        <asp:Panel ID="Panel1" runat="server" BackColor="white" Width="400px" BorderColor="Black" BorderStyle="Solid" BorderWidth="2px">

     <b><h1 align="center">Edit Prescription</h1></b>

            <br />

            <table align="center">

                <tr>
                    <td>
                        Prescription ID: &nbsp           
                    </td>
                    <td>
                        <asp:label ID="lblPrescriptionID" runat="server"></asp:label>
<%--                        <asp:RequiredFieldValidator ID="rfvPID" runat="server" ErrorMessage="Prescription ID is a required field" ControlToValidate="lblPrescriptionID" Display="Dynamic" Font-Bold="True" ForeColor="Red">*</asp:RequiredFieldValidator>--%>
                    </td>
                </tr>

                <tr>
                    <td>
                        Prescription Name: &nbsp
                    </td>
                    <td>
                        <asp:TextBox ID="txtPname" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvPname" runat="server" ErrorMessage="Prescription name is a required field" ControlToValidate="txtPname" Display="Dynamic" Font-Bold="True" ForeColor="Red">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>
                        Patient's ID: &nbsp
                    </td>
                    <td>
                        <asp:label ID="lblPatientID" runat="server"></asp:label>
<%--                        <asp:RequiredFieldValidator ID="rfvPatientID" runat="server" ErrorMessage="Patient's ID is a required field" ControlToValidate="lblPatientID" Display="Dynamic" Font-Bold="True" ForeColor="Red">*</asp:RequiredFieldValidator>--%>
                    </td>
                </tr>
                <tr>
                    <td>
                        Patient's First Name: &nbsp
                    </td>
                    <td>
                        <asp:label ID="lblFname" runat="server"></asp:label>
<%--                        <asp:RequiredFieldValidator ID="rfvFname" runat="server" ErrorMessage="First name is a required field" ControlToValidate="lblFname" Display="Dynamic" Font-Bold="True" ForeColor="Red">*</asp:RequiredFieldValidator>--%>
                    </td>
                </tr>

                <tr>
                    <td>
                        Patient's Last Name: &nbsp
                    </td>
                    <td>
                        <asp:label ID="lblLname" runat="server"></asp:label>
<%--                        <asp:RequiredFieldValidator ID="rfvLname" runat="server" ErrorMessage="Last name is a required field" ControlToValidate="lblLname" Display="Dynamic" Font-Bold="True" ForeColor="Red">*</asp:RequiredFieldValidator>--%>
                    </td>
                </tr>

                <tr>
                    <td>
                        Method Of Intake: &nbsp
                    </td>
                    <td>
                        <asp:DropDownList ID="ddlIntakeMethod" runat="server">
                            <asp:ListItem disabled Selected Value>-- select an option --</asp:ListItem>
                            <asp:ListItem>buccal</asp:ListItem>
                            <asp:ListItem>inhalable</asp:ListItem>
                            <asp:ListItem>infused</asp:ListItem>
                            <asp:ListItem>intramuscular</asp:ListItem>
                            <asp:ListItem>intrathecal</asp:ListItem>
                            <asp:ListItem>intravenous</asp:ListItem>
                            <asp:ListItem>nasal</asp:ListItem>
                            <asp:ListItem>ophthalmic</asp:ListItem>
                            <asp:ListItem>oral</asp:ListItem>
                            <asp:ListItem>otic</asp:ListItem>
                            <asp:ListItem>rectal</asp:ListItem>
                            <asp:ListItem>subcutaneous</asp:ListItem>
                             <asp:ListItem>sublingual</asp:ListItem>
                             <asp:ListItem>topical</asp:ListItem>
                        </asp:DropDownList>
                        <asp:RequiredFieldValidator ID="rfvIntakeMethod" runat="server" ErrorMessage="Method of intake is a required field" ControlToValidate="ddlIntakeMethod" Display="Dynamic" Font-Bold="True" ForeColor="Red">*</asp:RequiredFieldValidator>
                    </td>
                </tr>

                <tr>
                    <td>
                        Frequence: &nbsp
                    </td>
                    <td>
                        <asp:TextBox ID="txtFrequence" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvFrequence" runat="server" ErrorMessage="Frequence is a required field" ControlToValidate="txtFrequence" Display="Dynamic" Font-Bold="True" ForeColor="Red">*</asp:RequiredFieldValidator>
                    </td>
                </tr>

                <tr>
                    <td>
                        Dosage: &nbsp
                    </td>
                    <td>
                        <asp:TextBox ID="txtDosage" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvDosage" runat="server" ErrorMessage="Dosage is a required field" ControlToValidate="txtDosage" Display="Dynamic" Font-Bold="True" ForeColor="Red">*</asp:RequiredFieldValidator>
                    </td>
                </tr>

                <tr>
                    <td>
                        Number of Refill's: &nbsp
                    </td>
                    <td>
                        <asp:TextBox ID="txtRefill" runat="server"></asp:TextBox>
                         <asp:RequiredFieldValidator ID="rfvRefill" runat="server" ErrorMessage="Refill is a required field" ControlToValidate="txtRefill" Display="Dynamic" Font-Bold="True" ForeColor="Red">*</asp:RequiredFieldValidator>
                   
                    </td>
                </tr>

                <tr>
                    <td>
                        Doctor's ID: &nbsp           
                    </td>
                    <td>
                        <asp:label ID="lblDoctorID" runat="server"></asp:label>
<%--                        <asp:RequiredFieldValidator ID="rfvDoctorID" runat="server" ErrorMessage="Doctor's ID is a required field" ControlToValidate="lblDoctorID" Display="Dynamic" Font-Bold="True" ForeColor="Red">*</asp:RequiredFieldValidator>--%>
                    </td>
                </tr>
                <tr>
                    <td>
                        Doctor's First Name: &nbsp           
                    </td>
                    <td>
                        <asp:label ID="lblDoctorFname" runat="server"></asp:label>
<%--                        <asp:RequiredFieldValidator ID="rfvDoctorFname" runat="server" ErrorMessage="Doctor's First Name is a required field" ControlToValidate="lblDoctorFname" Display="Dynamic" Font-Bold="True" ForeColor="Red">*</asp:RequiredFieldValidator>--%>
                    </td>
                </tr>
                <tr>
                    <td>Doctor&#39;s Last Name: &nbsp; </td>
                    <td>
                        <asp:label ID="lblDoctorLname" runat="server"></asp:label>
<%--                        <asp:RequiredFieldValidator ID="rfvDoctorLname" runat="server" ControlToValidate="lblDoctorFname" Display="Dynamic" ErrorMessage="Doctor's First Name is a required field" Font-Bold="True" ForeColor="Red">*</asp:RequiredFieldValidator>--%>
                    </td>
                <tr>
                    <td>Date Prescribed: &nbsp; </td>
                    <td class="auto-style5">
                        <asp:TextBox ID="txtdate" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvdate" runat="server" ControlToValidate="txtdate" Display="Dynamic" ErrorMessage="Date Prescibed is a required field" Font-Bold="True" ForeColor="Red">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td align="center" colspan="2">
                        <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" HeaderText="The following errors occurred:" ViewStateMode="Enabled" />
                    </td>
                </tr>
                <tr>
                    <td align="center" colspan="2"><span style="color: blue">
                        <asp:Literal ID="litMessage" runat="server"></asp:Literal>
                        </span></td>
                </tr>
                
            </table>        

            <%--<p align="center">
                <asp:Button ID="btnAdd" runat="server" Text="ADD" /> &nbsp &nbsp &nbsp                
                <asp:Button ID="btnClear" runat="server" Text="CLEAR" CausesValidation="False" />&nbsp &nbsp &nbsp
                <asp:Button ID="btnHome" runat="server" Text="HOME" /> 
            </p>--%>
                    
            
            <p align="center">
            <asp:Button ID="btnClose" runat="server" Text="CLOSE" CausesValidation="false" /> &nbsp &nbsp

            <asp:Button ID="btnUpdate" runat="server" Text="UPDATE" CausesValidation="true"/>
            </p>


        
    
</asp:panel>
</div>

</asp:Content>





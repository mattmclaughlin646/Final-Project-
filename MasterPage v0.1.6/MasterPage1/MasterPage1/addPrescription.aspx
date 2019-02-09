<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="addPrescription.aspx.vb" Inherits="addPrescription" %>
<%@ Register Assembly="AjaxControlToolKit" Namespace="AjaxControlToolKit" TagPrefix="ajaxToolkit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <%--   <br />
    <br />
    <br />--%>

</asp:Content>


<asp:Content ID="Content3" ContentPlaceHolderID="cph3" Runat="Server">
    
    <div Align="center" class="auto-style4">

        <br />
        <br />
        <br />
        
        <asp:Panel ID="Panel1" runat="server" BackColor="white" Width="400px" BorderColor="Black" BorderStyle="Solid" BorderWidth="2px" >

     <b><h1 align="center">Prescription Information</h1></b>

            <br />
            <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
            <table align="center">

                <tr>
                    <td>
                        Prescription ID: &nbsp           
                    </td>
                    <td>
                        <asp:TextBox ID="txtPrescriptionID" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvPID" runat="server" ErrorMessage="Prescription ID is a required field" ControlToValidate="txtPrescriptionID" Display="Dynamic" Font-Bold="True" ForeColor="Red">*</asp:RequiredFieldValidator>
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
                        <asp:TextBox ID="txtPatientID" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvPatientID" runat="server" ErrorMessage="Patient's ID is a required field" ControlToValidate="txtPatientID" Display="Dynamic" Font-Bold="True" ForeColor="Red">*</asp:RequiredFieldValidator>
                        </td>
                </tr>
                <tr>
                    <td>
                        Patient's First Name: &nbsp
                    </td>
                    <td>
                        <asp:TextBox ID="txtFname" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvFname" runat="server" ErrorMessage="First name is a required field" ControlToValidate="txtFname" Display="Dynamic" Font-Bold="True" ForeColor="Red">*</asp:RequiredFieldValidator>
                          </td>
                </tr>

                <tr>
                    <td>
                        Patient's Last Name: &nbsp
                    </td>
                    <td>
                        <asp:TextBox ID="txtLname" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvLname" runat="server" ErrorMessage="Last name is a required field" ControlToValidate="txtLname" Display="Dynamic" Font-Bold="True" ForeColor="Red">*</asp:RequiredFieldValidator>
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
                        <asp:TextBox ID="txtDoctorID" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvDoctorID" runat="server" ErrorMessage="Doctor's ID is a required field" ControlToValidate="txtDoctorID" Display="Dynamic" Font-Bold="True" ForeColor="Red">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>
                        Doctor's First Name: &nbsp           
                    </td>
                    <td>
                        <asp:TextBox ID="txtDoctorFname" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvDoctorFname" runat="server" ErrorMessage="Doctor's First Name is a required field" ControlToValidate="txtDoctorFname" Display="Dynamic" Font-Bold="True" ForeColor="Red">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>Doctor&#39;s Last Name: &nbsp; </td>
                    <td>
                        <asp:TextBox ID="txtDoctorLname" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvDoctorLname" runat="server" ControlToValidate="txtDoctorFname" Display="Dynamic" ErrorMessage="Doctor's First Name is a required field" Font-Bold="True" ForeColor="Red">*</asp:RequiredFieldValidator>
                    </td>
                <tr>
                    <td>Date Prescribed: &nbsp; </td>
                    <td class="auto-style5">
                        <asp:TextBox ID="txtdate" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvdate" runat="server" ControlToValidate="txtdate" Display="Dynamic" ErrorMessage="Date Prescibed is a required field" Font-Bold="True" ForeColor="Red">*</asp:RequiredFieldValidator>
                       <ajaxToolkit:CalendarExtender ID="CalanderExtender1" runat="server" TargetControlID="txtdate" Format="MMMM d, yyyy" PopupPosition="right" />
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

            <br />

            <p align="center">
                <asp:Button ID="btnAdd" runat="server" Text="ADD" /> &nbsp &nbsp &nbsp                
                <asp:Button ID="btnClear" runat="server" Text="CLEAR" CausesValidation="False" />&nbsp &nbsp &nbsp
                <asp:Button ID="btnHome" runat="server" Text="HOME" CausesValidation="false" OnCommand="btnHome_click"/> 
            </p>
                    
            </asp:Panel>

        

        </div>
        </asp:Content>



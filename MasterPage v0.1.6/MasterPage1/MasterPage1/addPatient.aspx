<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="addPatient.aspx.vb" Inherits="addPatient" %>




<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="ajaxToolkit" %>




<%--<asp:Content ID="cph2" ContentPlaceHolderID="cph2" Runat="Server">

    <br />
    <br />
    <br />

</asp:Content>--%>


<asp:Content ID="cph3" ContentPlaceHolderID="cph3" runat="server">

    

    <div Align="center" class="auto-style4">

        <br />
        <br />
        <br />
        
        <asp:Panel ID="Panel1" runat="server" BackColor="white" Width="400px" BorderColor="Black" BorderStyle="Solid" BorderWidth="2px">
            <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
     <b><h1 align="center">Patient Information</h1></b>

            <br />

            <table align="center">

                <tr>
                    <td>
                        Patient ID: &nbsp           
                    </td>
                    <td>
                        <asp:TextBox ID="txtPatID" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvID" runat="server" ErrorMessage="Patient ID is a required field" ControlToValidate="txtPatID" Display="Dynamic" Font-Bold="True" ForeColor="Red">*</asp:RequiredFieldValidator>
                    </td>
                </tr>

                <tr>
                    <td>
                        First Name: &nbsp
                    </td>
                    <td>
                        <asp:TextBox ID="txtFname" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvFname" runat="server" ErrorMessage="First name is a required field" ControlToValidate="txtFname" Display="Dynamic" Font-Bold="True" ForeColor="Red">*</asp:RequiredFieldValidator>
                    </td>
                </tr>

                <tr>
                    <td>
                        MI: &nbsp
                    </td>
                    <td>
                        <asp:TextBox ID="txtMI" runat="server"></asp:TextBox>
                    </td>
                </tr>

                <tr>
                    <td>
                        Last Name: &nbsp
                    </td>
                    <td>
                        <asp:TextBox ID="txtLname" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvLname" runat="server" ErrorMessage="Last name is a required field" ControlToValidate="txtLname" Display="Dynamic" Font-Bold="True" ForeColor="Red">*</asp:RequiredFieldValidator>
                    </td>
                </tr>

                <tr>
                    <td>
                        Gender: &nbsp
                    </td>
                    <td>
                        <asp:DropDownList ID="ddlGender" runat="server">
                            <asp:ListItem disabled Selected Value>-- select an option --</asp:ListItem>
                            <asp:ListItem>Male</asp:ListItem>
                            <asp:ListItem>Female</asp:ListItem>
                        </asp:DropDownList>
                        <asp:RequiredFieldValidator ID="rfvGender" runat="server" ErrorMessage="Gender is a required field" ControlToValidate="ddlGender" Display="Dynamic" Font-Bold="True" ForeColor="Red">*</asp:RequiredFieldValidator>
                    </td>
                </tr>

                <tr>
                    <td>
                        DOB: &nbsp
                    </td>
                    <td>
                        <asp:TextBox ID="txtDOB" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvDOB" runat="server" ErrorMessage="DOB is a required field" ControlToValidate="txtDOB" Display="Dynamic" Font-Bold="True" ForeColor="Red">*</asp:RequiredFieldValidator>
                         <ajaxToolkit:CalendarExtender ID="CalanderExtender1" runat="server" TargetControlID="txtDOB" Format="MMMM d, yyyy" PopupPosition="right" />
                    </td>
                </tr>

                <tr>
                    <td>
                        Street: &nbsp
                    </td>
                    <td>
                        <asp:TextBox ID="txtStreet" runat="server"></asp:TextBox>
                    </td>
                </tr>

                <tr>
                    <td>
                        City: &nbsp
                    </td>
                    <td>
                        <asp:TextBox ID="txtCity" runat="server"></asp:TextBox>
                    </td>
                </tr>

                <tr>
                    <td>
                        State: &nbsp
                    </td>
                    <td>                       
                        <asp:DropDownList ID="ddlState" width="175px" runat="server"></asp:DropDownList>
                    </td>
                </tr>

                <tr>
                    <td>
                        Zip Code: &nbsp
                    </td>
                    <td>
                        <asp:TextBox ID="txtZip" runat="server"></asp:TextBox>
                    </td>
                </tr>

                <tr>
                    <td>
                        Home Phone: &nbsp
                    </td>
                    <td>
                        <asp:TextBox ID="txtHome" runat="server"></asp:TextBox>
                    </td>
                </tr>

                <tr>
                    <td>
                        Cell Phone: &nbsp
                    </td>
                    <td>
                        <asp:TextBox ID="txtCell" runat="server"></asp:TextBox>
                    </td>
                </tr>

               <%-- <tr>
                    <td>
                        Account Balance: &nbsp
                    </td>
                    <td>
                        <asp:TextBox ID="txtBal" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvBal" runat="server" ErrorMessage="Account balance is a required field" ControlToValidate="txtBal" Display="Dynamic" Font-Bold="True" ForeColor="Red">*</asp:RequiredFieldValidator>
                    </td>
                </tr>--%>

                <tr>
                    <td align="center" colspan="2">
                        <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" HeaderText="The following errors occurred:" ViewStateMode="Enabled" />                            
                    </td>
                </tr>

                <tr>
                    <td align="center" colspan="2">
                    <span style="color: blue">
                        <asp:Literal ID="litMessage" runat="server"></asp:Literal>
                    </span>
                    </td>
                </tr>
                
            </table>

            <br />

            <p align="center">
                <asp:Button ID="btnAdd" runat="server" Text="ADD" /> &nbsp &nbsp &nbsp                
                <asp:Button ID="btnClear" runat="server" Text="CLEAR" CausesValidation="False" />&nbsp &nbsp &nbsp
                <asp:Button ID="btnHome" runat="server" Text="HOME" CausesValidation="false" OnCommmand="btnHome_click"/> 
            </p>
                    
            </asp:Panel>

        

        </div>

</asp:Content>

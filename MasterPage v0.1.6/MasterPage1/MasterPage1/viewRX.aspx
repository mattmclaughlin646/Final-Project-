<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="viewRX.aspx.vb" Inherits="viewRX" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>

<%--<asp:Content ID="cph2" ContentPlaceHolderID="cph2" Runat="Server">

    <br />
    <br />

</asp:Content>--%>

<asp:Content ContentPlaceHolderID="cph3" runat="server">

    <div Align="center" class="auto-style4">

        <br />
        <br />
        <br />
        
        <asp:Panel ID="Panel1" runat="server" BackColor="white" Width="400px" BorderColor="Black" BorderStyle="Solid" BorderWidth="2px">

     <b><h1 align="center">View Prescription</h1></b>

            <br />

            <table align="center">

                <tr>
                    <td>
                        Prescription ID: &nbsp           
                    </td>
                    <td>
                        &nbsp &nbsp &nbsp
                        <asp:Label ID="txtPrescriptionID" runat="server" Text=""></asp:Label>
                    </td>
                </tr>

                <tr>
                    <td>
                        Prescription Name: &nbsp
                    </td>
                    <td>
                        &nbsp &nbsp &nbsp
                        <asp:Label ID="txtPname" runat="server" Text=""></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        Patient's ID: &nbsp
                    </td>
                    <td>
                        &nbsp &nbsp &nbsp
                        <asp:Label ID="txtPatientID" runat="server" Text=""></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        Patient's First Name: &nbsp
                    </td>
                    <td>
                        &nbsp &nbsp &nbsp
                        <asp:Label ID="txtFname" runat="server" Text=""></asp:Label>
                    </td>
                </tr>

                <tr>
                    <td>
                        Patient's Last Name: &nbsp
                    </td>
                    <td>
                        &nbsp &nbsp &nbsp
                        <asp:Label ID="txtLname" runat="server" Text=""></asp:Label>
                    </td>
                </tr>

                <tr>
                    <td>
                        Method Of Intake: &nbsp
                    </td>
                    <td>
                        &nbsp &nbsp &nbsp
                        <asp:Label ID="ddlIntakeMethod" runat="server" Text=""></asp:Label>
                    </td>
                </tr>

                <tr>
                    <td>
                        Frequence: &nbsp
                    </td>
                    <td>
                        &nbsp &nbsp &nbsp
                        <asp:Label ID="txtFrequence" runat="server" Text=""></asp:Label>
                    </td>
                </tr>

                <tr>
                    <td>
                        Dosage: &nbsp
                    </td>
                    <td>
                        &nbsp &nbsp &nbsp
                        <asp:Label ID="txtDosage" runat="server" Text=""></asp:Label>
                    </td>
                </tr>

                <tr>
                    <td>
                        Number of Refill's: &nbsp
                    </td>
                    <td>
                        &nbsp &nbsp &nbsp
                        <asp:Label ID="txtRefill" runat="server" Text=""></asp:Label>
                    </td>
                </tr>

                <tr>
                    <td>
                        Doctor's ID: &nbsp           
                    </td>
                    <td>
                        &nbsp &nbsp &nbsp
                        <asp:Label ID="txtDoctorID" runat="server" Text=""></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        Doctor's First Name: &nbsp           
                    </td>
                    <td>
                        &nbsp &nbsp &nbsp
                        <asp:Label ID="txtDoctorFname" runat="server" Text=""></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        Doctor&#39;s Last Name: &nbsp; 
                    </td>
                    <td>
                        &nbsp &nbsp &nbsp
                        <asp:Label ID="txtDoctorLname" runat="server" Text=""></asp:Label>
                    </td>
                <tr>
                    <td>
                        Date Prescribed: &nbsp; 
                    </td>
                    <td>
                        &nbsp &nbsp &nbsp
                        <asp:Label ID="txtdate" runat="server" Text=""></asp:Label>
                    </td>
                </tr>               
                
            </table>

          <%--  <br />--%>

            <p align="center">
               <%-- <asp:Button ID="btnAdd" runat="server" Text="ADD" /> &nbsp &nbsp &nbsp               --%> 
                <asp:Button ID="btnClose" runat="server" Text="CLOSE" CausesValidation="False" />&nbsp &nbsp &nbsp
                <asp:Button ID="btnHome" runat="server" Text="HOME" CausedValidation="False" OnCommmand="btnHome_click"/> &nbsp
            </p>
                    
            

            <%--<asp:Button ID="btnClose" runat="server" Text="Close" CausesValidation="false" /> &nbsp &nbsp

            <asp:Button ID="btnUpdate" runat="server" Text="Update" CausesValidation="true"/>
--%>

        
    
</asp:panel>
</div>

</asp:Content>



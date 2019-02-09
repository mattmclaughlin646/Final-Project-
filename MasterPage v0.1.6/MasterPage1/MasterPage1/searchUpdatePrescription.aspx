<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="searchUpdatePrescription.aspx.vb" Inherits="searchUpdatePrescription" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="CC1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cph3" Runat="Server">
    <div Align="center" class="auto-style4">

            <br />
            <br />
            <br />
        
        <asp:panel ID="Panel1" runat="server" BackColor="white" Width="500px" BorderColor="Black" BorderStyle="Solid" BorderWidth="2px">

            <span style="align-content:center">
                <b><h1>Update Prescription</h1></b>
            </span>

            <br />

            <span style="align-content:center">
            <table>

                <tr>
                    <td>
                        Prescription ID:
                    </td>
               
                    <td>
                        &nbsp
                        <asp:TextBox ID="txtRXid" runat="server"></asp:TextBox>
                    </td>

                    <td rowspan="2">
                        &nbsp
                        <asp:Button ID="btnSearch" runat="server" Text="SEARCH" />
                    </td>
                </tr>

               <%-- <tr>
                    <td>
                        Patient ID:
                    </td>

                    <td>
                        &nbsp
                        <asp:TextBox ID="txtPatid" runat="server"></asp:TextBox>
                    </td>
                </tr>--%>

                <tr>
                    <td>
                        Patients First Name:
                    </td>

                    <td>
                        &nbsp
                        <asp:TextBox ID="txtPatfname" runat="server"></asp:TextBox>
                    </td>
                </tr>

<%--                 <asp:ScriptManager ID="ScriptManager1" runat="server" EnablePageMethods="true" EnablePartialRendering="true" EnableHistory="true" ></asp:ScriptManager>--%>

                <tr>
                    <td>
                        Patients Last Name:
                    </td>
                    
                    <td>
                        &nbsp
                        <asp:TextBox ID="txtPatlname" runat="server"></asp:TextBox>
                    </td>

<%--                 <CC1:AutoCompleteExtender ID="AutoCompleteExtender1" runat="server" ServiceMethod="GetCompletionList" TargetControlID="txtPatlname" UseContextKey="true" CompletionInterval="1" EnableCaching="true" CompletionSetCount="12" MinimumPrefixLength="1" DelimiterCharacters=";, :" ></CC1:AutoCompleteExtender>--%>


                    <td>
                        &nbsp
                        <asp:Button ID="btnClear" runat="server" Text="CLEAR" />
                    </td>
                </tr>               

               <%-- <tr>
                    <td>
                        Prescription Date:
                    </td>

                    <td>
                        &nbsp
                        <asp:TextBox ID="txtRXdate" runat="server"></asp:TextBox>
                    </td>
                </tr>--%>

            </table>
            </span>

                <br />
                <br />

            </asp:Panel>

                <br />
                <br />

            <asp:panel ID="Panel2" runat="server" BackColor="white" Width="800px" BorderColor="Black" BorderStyle="Solid" BorderWidth="2px">

                <asp:GridView ID="grdRX" AutoGenerateColumns="False" runat="server" Width="100%" AllowPaging="True" AllowSorting="True">

                    <PagerSettings Mode="NextPreviousFirstLast" FirstPageText="Go To First Page" LastPageText="Go To Last Page" Position="Top"  />
                        

                    <Columns>
                        
                        <%-- datafield must match the database field --%>
                       
                        <asp:BoundField DataField="RXNUM" HeaderText="RX ID" />
                        <asp:BoundField DataField="PATIENTFNAME" HeaderText="First Name" />
                        <asp:BoundField DataField="PATIENTLNAME" HeaderText="Last Name" />
                        <asp:BoundField DataField="PATIENT_ID" HeaderText="Patient ID" />
                        

                        <asp:TemplateField HeaderText="View">
                            <ItemTemplate>                                
                                <asp:LinkButton ID="lbtnView" runat="server" OnCommand="lbtnView_Clicks" CommandName="lbtnView" CommandArgument='<% # Eval("RXNUM")%>'></asp:LinkButton>
                            </ItemTemplate>

                            <ItemTemplate>                               
                                <asp:ImageButton ID="imgView" runat="server" CommandArgument='<% # Eval("RXNUM")%>' OnCommand="lbtnView_Clicks" CommandName="lbtnView" imageURL="~/images/view.jpg" Height="30" Width="30" CausesValidation="false" />
                            </ItemTemplate>
                        </asp:TemplateField>
                        
                        <asp:TemplateField HeaderText="Edit">
                            <ItemTemplate>                                
                                <asp:LinkButton ID="lbtnEdit" runat="server" OnCommand="lbtnEdit_Clicks" CommandName="lbtnEdit" CommandArgument='<% # Eval("RXNUM")%>'></asp:LinkButton>
                            </ItemTemplate>

                            <ItemTemplate>                               
                                <asp:ImageButton ID="imgEdit" runat="server" CommandArgument='<% # Eval("RXNUM")%>' OnCommand="lbtnEdit_Clicks" CommandName="lbtnEdit" imageURL="~/images/edit.jpg" Height="30" Width="30" CausesValidation="false" />
                            </ItemTemplate>
                        </asp:TemplateField>                    

                    </Columns>

                            <EmptyDataTemplate>
                                     No Records Found Matching Your Search!
                            </EmptyDataTemplate>

                </asp:GridView>
                        
            </asp:Panel>

    </div>


</asp:Content>



<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="Home.aspx.vb" Inherits="Home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cph3" Runat="Server">

    

     <div Align="center" class="auto-style4">

         <asp:Label runat="server"></asp:Label>

         <br />
         <br />
         <br />

         <asp:panel ID="Panel1" runat="server" BackColor="white" Width="500px" BorderColor="Black" BorderStyle="Solid" BorderWidth="2px">

            <span style="align-content:center">
                <b><h1>Welcome to XYZ Pharmacy Inc.</h1></b>
            </span>           

         </asp:panel>

         <br />
         <br />
         <br />

          <asp:panel ID="Panel2" runat="server" BackColor="white" Width="330px" BorderColor="Black" BorderStyle="Solid" BorderWidth="2px">


               <div style="padding: 18px 18px 18px 18px;">
              <span style="align-content:center">

                 <b>A promise of compassionate care.</b>
                  
                  <br />
                  <br />

                  Whatever your medication needs may be, we are here to serve you. 
                  
                  <br />
                  <br />
                  We listen. We advise. We share our professional expertise. 
                  
                  <br />
                  And, we make it our purpose to constantly provide individuals and families with exceptional pharmacist care.

              </span>
                   </div>

          </asp:panel>
     </div>



</asp:Content>



<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="About.aspx.vb" Inherits="About" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cph2" Runat="Server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="cph3" Runat="Server">


    <div Align="center" class="auto-style4">

         <asp:Label runat="server"></asp:Label>

         <br />
         <br />
         <br />

         <asp:panel ID="Panel1" runat="server" BackColor="white" Width="500px" BorderColor="Black" BorderStyle="Solid" BorderWidth="2px">

            <span style="align-content:center">
                <b><h1>XYZ Pharmacy - About Us</h1></b>
            </span>           

         </asp:panel>

         <br />
         <br />
         <br />

          <asp:panel ID="Panel2" runat="server" BackColor="white" Width="380px" BorderColor="Black" BorderStyle="Solid" BorderWidth="2px" >

              <div style="padding: 18px 18px 18px 18px;">
              <span style="align-content:center" >
                  
                 <%--<b>A promise of compassionate care.</b>
                  
                  <br />
                  <br />--%>

                  With a commitment to providing personalized care, our team of pharmacists skilled in various disciplines of pharmacy are ready to help when you need it. In fact, regardless of the time of day, the type of medication needed or level of service required, XYZ is there.

                  <br />
                  <br />

                  Because no two patients are alike, we understand that not all commercially made medication work for all people. That's why we proudly provide custom prescriptions to help meet special needs. 
                  
                  <br />
                  <br />
                  This handcrafted care goes into everything we do. From prescription processing to medication consulting to compounding medications, XYZ is the vital link between you and your healthcare provider.
                                    
              </span>
              </div>

          </asp:panel>
     </div>


</asp:Content>


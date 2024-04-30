<%@ Page Title="" Language="C#" MasterPageFile="~/file/cimimanage.Master" AutoEventWireup="true" CodeBehind="commande.aspx.cs" Inherits="CimiManage.file.commande" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <main id="main" class="main">
        <section class="section">
    <div class="card container w-75">
        <div class="row">
            <div class="col-lg-6">

     
      <asp:Label ID="Label1" runat="server" Text="utulisateur"></asp:Label>
  <asp:DropDownList ID="Dput" CssClass="form-control" runat="server">

  </asp:DropDownList>

        <asp:Label ID="Label2" runat="server" Text="service"></asp:Label>
<asp:DropDownList ID="Dpsv" CssClass="form-control" runat="server">

</asp:DropDownList>
 
  

   

    <asp:Label ID="Label3" runat="server" Text="code_commande"></asp:Label>
    <asp:TextBox ID="txtcd" CssClass="form-control" runat="server"></asp:TextBox>
 </div>
<div class="col-lg-6">
       <asp:Label ID="Label5" runat="server" Text="type_commande"></asp:Label>
   <asp:TextBox ID="txttyp" CssClass="form-control" runat="server"></asp:TextBox>

       <asp:Label ID="Label6" runat="server" Text="reduction"></asp:Label>
   <asp:TextBox ID="txtrd" CssClass="form-control" runat="server"></asp:TextBox>

       <asp:Label ID="Label7" runat="server" Text="date_commande"></asp:Label>
   <asp:TextBox ID="txtdt" CssClass="form-control" type="date" runat="server"></asp:TextBox>
    </div>
            <div class="col-lg-6">
       <asp:Label ID="Label8" runat="server" Text="statut"></asp:Label>
   <asp:TextBox ID="txtst" CssClass="form-control" runat="server"></asp:TextBox>

       <asp:Label ID="Label9" runat="server" Text="etat "></asp:Label>
   <asp:TextBox ID="txtet" CssClass="form-control" runat="server"></asp:TextBox>

       <asp:Label ID="Label10" runat="server" Text="prix_total "></asp:Label>
   <asp:TextBox ID="txtpt" CssClass="form-control" runat="server"></asp:TextBox>
 
       <asp:Label ID="Label11" runat="server" Text="annee "></asp:Label>
   <asp:TextBox ID="txtann" CssClass="form-control" runat="server"></asp:TextBox>
</div>
            <div class="col-lg-6">
       <asp:Label ID="Label12" runat="server" Text="mois "></asp:Label>
   <asp:TextBox ID="txtm" CssClass="form-control" runat="server"></asp:TextBox>

       <asp:Label ID="Label13" runat="server" Text="prix_TVA "></asp:Label>
   <asp:TextBox ID="txtptv" CssClass="form-control" runat="server"></asp:TextBox>

       <asp:Label ID="Label14" runat="server" Text="type_com_location "></asp:Label>
   <asp:TextBox ID="txttpc" CssClass="form-control" runat="server"></asp:TextBox>

       <asp:Label ID="Label15" runat="server" Text="type_com_achat "></asp:Label>
   <asp:TextBox ID="txttp" CssClass="form-control" runat="server"></asp:TextBox>
</div>


            <div class="" style="margin-left:250px; margin-top:10px;">
    <asp:Label ID="msg" runat="server" Text=""></asp:Label>
    <asp:Button ID="btncomm"  Class ="btn btn-primary" runat="server" Text="Enregistre" OnClick="btncomm_Click" />
       </div>               
    </div>
</div>
            </section>
        </main>
</asp:Content>

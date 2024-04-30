<%@ Page Title="" Language="C#" MasterPageFile="~/file/cimimanage.Master" AutoEventWireup="true" CodeBehind="service.aspx.cs" Inherits="CimiManage.file.service" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

     <main id="main" class="main">>
     <section class="section">
 <div class="card container w-75">
     <div class="row">
        
         <div class="col-lg-6">
    <asp:Label ID="Label7" runat="server" Text="nom_produit"></asp:Label>
    <asp:DropDownList ID="Dpnp" CssClass="form-control" runat="server">

    </asp:DropDownList>

    <asp:Label ID="Label8" runat="server" Text="nom_pompe"></asp:Label>
    <asp:DropDownList ID="Dpnmp" CssClass="form-control" runat="server">

    </asp:DropDownList>


    <asp:Label ID="Label1" runat="server" Text="nom_service"></asp:Label>
   <!-- <asp:TextBox ID="txtnv" runat="server"></asp:TextBox>-->

    <asp:DropDownList ID="Dpservice" CssClass="form-control" runat="server">
        <asp:ListItem Value="">Selectionner le nom de la service</asp:ListItem>
        <asp:ListItem Value="faire des cerceuille"></asp:ListItem>
        <asp:ListItem Value="decord fleure"></asp:ListItem>
        <asp:ListItem Value="conscriction des tombe"></asp:ListItem>
        <asp:ListItem Value="voiture"></asp:ListItem>
    </asp:DropDownList>
 </div>
         <div class="col-lg-6">
     <asp:Label ID="Label2" runat="server" Text="prix_service"></asp:Label>
 <asp:TextBox ID="txtps" CssClass="form-control" runat="server"></asp:TextBox>

     <asp:Label ID="Label3" runat="server" Text="longitude"></asp:Label>
 <asp:TextBox ID="txtlg" CssClass="form-control" runat="server"></asp:TextBox>


     <asp:Label ID="Label4" runat="server" Text="altitude"></asp:Label>
 <asp:TextBox ID="txtalt" CssClass="form-control" runat="server"></asp:TextBox>

   </div>
         <div style="margin-left:250px; margin-top:10px;">
    <asp:Label ID="msg" runat="server" Text=""></asp:Label>
    <asp:Button ID="btnsv" Class ="btn btn-primary" runat="server" Text="Enregistre" OnClick="btnsv_Click" />
    <a href="listservice.aspx" class="btn btn-danger">Retour a la liste</a>
             </div>
                 </div>
</div>
           </section>
       </main>
</asp:Content>

<%@ Page Title="" Language="C#" MasterPageFile="~/file/cimimanage.Master" AutoEventWireup="true" CodeBehind="service.aspx.cs" Inherits="CimiManage.file.service" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:Label ID="Label7" runat="server" Text="nom_produit"></asp:Label>
    <asp:DropDownList ID="Dpnp" runat="server">

    </asp:DropDownList>

    <asp:Label ID="Label8" runat="server" Text="nom_pompe"></asp:Label>
    <asp:DropDownList ID="Dpnmp" runat="server">

    </asp:DropDownList>


    <asp:Label ID="Label1" runat="server" Text="nom_service"></asp:Label>
   <!-- <asp:TextBox ID="txtnv" runat="server"></asp:TextBox>-->

    <asp:DropDownList ID="Dpservice" runat="server">
        <asp:ListItem Value="">Selectionner le nom de la service</asp:ListItem>
        <asp:ListItem Value="faire des cerceuille"></asp:ListItem>
        <asp:ListItem Value="decord fleure"></asp:ListItem>
        <asp:ListItem Value="conscriction des tombe"></asp:ListItem>
        <asp:ListItem Value="voiture"></asp:ListItem>
    </asp:DropDownList>

     <asp:Label ID="Label2" runat="server" Text="prix_service"></asp:Label>
 <asp:TextBox ID="txtps" runat="server"></asp:TextBox>

     <asp:Label ID="Label3" runat="server" Text="longitude"></asp:Label>
 <asp:TextBox ID="txtlg" runat="server"></asp:TextBox>


     <asp:Label ID="Label4" runat="server" Text="altitude"></asp:Label>
 <asp:TextBox ID="txtalt" runat="server"></asp:TextBox>

   

    <asp:Label ID="msg" runat="server" Text=""></asp:Label>
    <asp:Button ID="btnsv" runat="server" Text="Enregistre" OnClick="btnsv_Click" />
    <a href="listservice.aspx" class="btn btn-danger">Retour a la liste</a>
</asp:Content>

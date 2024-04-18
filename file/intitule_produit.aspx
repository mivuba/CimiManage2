<%@ Page Title="" Language="C#" MasterPageFile="~/file/cimimanage.Master" AutoEventWireup="true" CodeBehind="intitule_produit.aspx.cs" Inherits="CimiManage.file.intitule_produit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:Label ID="Label1" runat="server" Text="nom_produit"></asp:Label>
    <asp:TextBox ID="txtnp" runat="server"></asp:TextBox>

  


     <asp:Label ID="msg" runat="server" Text=""></asp:Label>
    <asp:Button ID="btnmn" runat="server" Text="Enregistre" OnClick="btnmn_Click" />
</asp:Content>

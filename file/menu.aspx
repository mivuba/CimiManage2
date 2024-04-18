<%@ Page Title="" Language="C#" MasterPageFile="~/file/cimimanage.Master" AutoEventWireup="true" CodeBehind="menu.aspx.cs" Inherits="CimiManage.file.menu" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <asp:Label ID="Label1" runat="server" Text="nom_menu"></asp:Label>
    <asp:TextBox ID="txtnm" runat="server"></asp:TextBox>

     <asp:Label ID="Label2" runat="server" Text="link"></asp:Label>
 <asp:TextBox ID="txtlk" runat="server"></asp:TextBox>

     <asp:Label ID="Label3" runat="server" Text="etat"></asp:Label>
 <asp:TextBox ID="txtet" runat="server"></asp:TextBox>

    <asp:Label ID="msg" runat="server" Text=""></asp:Label>
    <asp:Button ID="btnmn" runat="server" Text="Enregistre"  OnClick="btnmn_Click"/>
</asp:Content>

<%@ Page Title="" Language="C#" MasterPageFile="~/file/cimimanage.Master" AutoEventWireup="true" CodeBehind="droit_menu.aspx.cs" Inherits="CimiManage.file.droit_menu" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">



    <asp:Label ID="Label1" runat="server" Text="Nom role"></asp:Label>
    <asp:DropDownList ID="Dpnr" runat="server"></asp:DropDownList>

     <asp:Label ID="Label4" runat="server" Text="Nom menu "></asp:Label>
 <asp:DropDownList ID="Dpnm" runat="server"></asp:DropDownList>
   

    <asp:Label ID="Label2" runat="server" Text="gerer"></asp:Label>
        <asp:TextBox ID="txtg" runat="server"></asp:TextBox>

    <asp:Label ID="Label3" runat="server" Text="ajouter"></asp:Label>
    <asp:TextBox ID="txtaj" runat="server"></asp:TextBox>

    <asp:Label ID="Label5" runat="server" Text="acces"></asp:Label>
    <asp:TextBox ID="txtac" runat="server"></asp:TextBox>

    <asp:Label ID="msg" runat="server" Text="Label"></asp:Label>
       <asp:Button ID="btndm" runat="server" Text="Enregistre" OnClick="btndm_Click" />
</asp:Content>

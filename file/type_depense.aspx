<%@ Page Title="" Language="C#" MasterPageFile="~/file/cimimanage.Master" AutoEventWireup="true" CodeBehind="type_depense.aspx.cs" Inherits="CimiManage.file.type_depense" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:Label ID="Label1" runat="server" Text="nom_pompe"></asp:Label>
    <asp:DropDownList ID="Dppompe" runat="server">

    </asp:DropDownList>

     <asp:Label ID="Label2" runat="server" Text="type_depens"></asp:Label>
    <asp:TextBox ID="txtyp" runat="server"></asp:TextBox>

    <asp:Label ID="msg" runat="server" Text=""></asp:Label>
    <asp:Button ID="btntp" runat="server" Text="Enregistre"  OnClick="btntp_Click"/>
</asp:Content>

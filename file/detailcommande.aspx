<%@ Page Title="" Language="C#" MasterPageFile="~/file/cimimanage.Master" AutoEventWireup="true" CodeBehind="detailcommande.aspx.cs" Inherits="CimiManage.file.detailcommande" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:Label ID="Label1" runat="server" Text="service"></asp:Label>
    <asp:DropDownList ID="Dpsc" runat="server"></asp:DropDownList>

    <asp:Label ID="Label2" runat="server" Text="commande"></asp:Label>
    <asp:DropDownList ID="Dpcm" runat="server"></asp:DropDownList>

    <asp:Label ID="Label3" runat="server" Text="PU"></asp:Label>
    <asp:TextBox ID="txtpu" runat="server"></asp:TextBox>

    <asp:Label ID="Label4" runat="server" Text="nom_feu"></asp:Label>
    <asp:TextBox ID="txtnf" runat="server"></asp:TextBox>

    <asp:Label ID="Label5" runat="server" Text="date_nass"></asp:Label>
    <asp:TextBox ID="txtdn" runat="server"></asp:TextBox>

    <asp:Label ID="Label6" runat="server" Text="date_dece"></asp:Label>
    <asp:TextBox ID="txtdd" runat="server"></asp:TextBox>

    <asp:Label ID="Label7" runat="server" Text="quantite_d_com"></asp:Label>
    <asp:TextBox ID="txtqc" runat="server"></asp:TextBox>

    <asp:Label ID="msg" runat="server" Text=""></asp:Label>
    <asp:Button ID="btndt" runat="server" Text="Enregistre" OnClick="btndt_Click" />
</asp:Content>

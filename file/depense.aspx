<%@ Page Title="" Language="C#" MasterPageFile="~/file/cimimanage.Master" AutoEventWireup="true" CodeBehind="depense.aspx.cs" Inherits="CimiManage.file.depense" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:Label ID="Label1" runat="server" Text="total_depense"></asp:Label>
    <asp:TextBox ID="txttp" runat="server"></asp:TextBox>

      <asp:Label ID="Label2" runat="server" Text="mois"></asp:Label>
  <asp:TextBox ID="txtms" runat="server"></asp:TextBox>

      <asp:Label ID="Label3" runat="server" Text="annee"></asp:Label>
  <asp:TextBox ID="txtan" runat="server"></asp:TextBox>

        <asp:Label ID="Label5" runat="server" Text="statut"></asp:Label>
<asp:TextBox ID="txtst" runat="server"></asp:TextBox>

    <asp:Label ID="msg" runat="server" Text=""></asp:Label>
    <asp:Button ID="btndp" runat="server" Text="Enregistre" OnClick="btndp_Click" />
</asp:Content>

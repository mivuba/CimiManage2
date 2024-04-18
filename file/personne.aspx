<%@ Page Title="" Language="C#" MasterPageFile="~/file/cimimanage.Master" AutoEventWireup="true" CodeBehind="personne.aspx.cs" Inherits="CimiManage.file.personne" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:Label ID="Label1" runat="server" Text="users"></asp:Label>
    <asp:TextBox ID="txtus" runat="server"></asp:TextBox>
    
    
    <asp:Label ID="Label2" runat="server" Text="pssw"></asp:Label>
<asp:TextBox ID="txtpr" runat="server"></asp:TextBox>

        <asp:Label ID="Label3" runat="server" Text="etat"></asp:Label>
<asp:TextBox ID="txtet" runat="server"></asp:TextBox>

   <asp:Label ID="msg" runat="server" Text=""></asp:Label>
    <asp:Button ID="btnpers" runat="server" Text="Enregistre" OnClick="btnpers_Click" />


</asp:Content>

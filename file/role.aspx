<%@ Page Title="" Language="C#" MasterPageFile="~/file/cimimanage.Master" AutoEventWireup="true" CodeBehind="role.aspx.cs" Inherits="CimiManage.file.role" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">



    <asp:Label ID="Label1" runat="server" Text="pompe_funeble"></asp:Label>
    <asp:DropDownList ID="Dppompe" runat="server">

    </asp:DropDownList>

    <asp:Label ID="Label2" runat="server" Text="nom_role"></asp:Label>
    <asp:TextBox ID="txtrl" runat="server"></asp:TextBox>

     <asp:Label ID="msg" runat="server" Text=""></asp:Label>
    <asp:Button ID="btnrole" runat="server" Text="Enregistre" OnClick="btnrole_Click" />
     <a href="listrole.aspx" class="btn btn-danger">Retour a la liste</a>
</asp:Content>

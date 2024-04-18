<%@ Page Title="" Language="C#" MasterPageFile="~/file/cimimanage.Master" AutoEventWireup="true" CodeBehind="utilisateur.aspx.cs" Inherits="CimiManage.file.utilisateur" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:Label ID="Label1" runat="server" Text="nom_role"></asp:Label>
    <asp:DropDownList ID="Dprl" runat="server">

    </asp:DropDownList>

     <asp:Label ID="Label9" runat="server" Text="user_name"></asp:Label>
 <asp:DropDownList ID="Dpprs" runat="server">

 </asp:DropDownList>

     <asp:Label ID="Label10" runat="server" Text="nom_pompe"></asp:Label>
 <asp:DropDownList ID="Dppmp" runat="server">

 </asp:DropDownList>

    <asp:Label ID="Label2" runat="server" Text="nom_ut"></asp:Label>
    <asp:TextBox ID="txtnu" runat="server"></asp:TextBox>

     <asp:Label ID="Label3" runat="server" Text="prenom_ut"></asp:Label>
 <asp:TextBox ID="txtpu" runat="server"></asp:TextBox>

     <asp:Label ID="Label4" runat="server" Text="telephone"></asp:Label>
 <asp:TextBox ID="txttl" runat="server"></asp:TextBox>

     <asp:Label ID="Label5" runat="server" Text="email"></asp:Label>
 <asp:TextBox ID="txtem" runat="server"></asp:TextBox>

     <asp:Label ID="Label6" runat="server" Text="type_client"></asp:Label>
 <asp:TextBox ID="txttypcl" runat="server"></asp:TextBox>

     <asp:Label ID="Label7" runat="server" Text="type_personne"></asp:Label>
 <asp:TextBox ID="txttypp" runat="server"></asp:TextBox>

    
     <asp:Label ID="Label8" runat="server" Text="adresse"></asp:Label>
 <asp:TextBox ID="txtadr" runat="server"></asp:TextBox>

      <asp:Label ID="msg" runat="server" Text=""></asp:Label>
    <asp:Button ID="btnutl" runat="server" Text="Enregistre" OnClick="btnutl_Click" />

</asp:Content>

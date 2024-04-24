<%@ Page Title="" Language="C#" MasterPageFile="~/file/cimimanage.Master" AutoEventWireup="true" CodeBehind="pompe_funeble.aspx.cs" Inherits="CimiManage.file.pompe_funeble" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:Label ID="Label1" runat="server" Text="nom_pompe"></asp:Label>
 
    <asp:DropDownList ID="Dppompe" runat="server">
         <asp:ListItem>Selectionner le nom de la pompe funeble </asp:ListItem>
         <asp:ListItem Value="muha pompe"> muha pompe </asp:ListItem>
         <asp:ListItem Value="mukaza pompe">mukaza pompe </asp:ListItem>
         <asp:ListItem Value="kanyosha pompe"> kanyosha pompe </asp:ListItem>
    </asp:DropDownList>

        <asp:Label ID="Label2" runat="server" Text="email"></asp:Label>
    <asp:TextBox ID="textml" runat="server"></asp:TextBox>

        <asp:Label ID="Label3" runat="server" Text="nif"></asp:Label>
    <asp:TextBox ID="textnf" runat="server"></asp:TextBox>

        <asp:Label ID="Label4" runat="server" Text="cod"></asp:Label>
    <asp:TextBox ID="textcd" runat="server"></asp:TextBox>

        <asp:Label ID="Label5" runat="server" Text="statut"></asp:Label>
    <asp:TextBox ID="textstat" runat="server"></asp:TextBox>

        <asp:Label ID="Label6" runat="server" Text="etat"></asp:Label>
    <asp:TextBox ID="textet" runat="server"></asp:TextBox>

        <asp:Label ID="Label7" runat="server" Text="logo"></asp:Label>
    <asp:FileUpload ID="FileUpload1" runat="server" />

        <asp:Label ID="Label8" runat="server" Text="rc"></asp:Label>
    <asp:TextBox ID="textrc" runat="server"></asp:TextBox>

        <asp:Label ID="Label9" runat="server" Text="sigl"></asp:Label>
    <asp:TextBox ID="textsgl" runat="server"></asp:TextBox>

       <!-- <asp:Label ID="Label10" runat="server" Text="date_creation"></asp:Label>
    <asp:TextBox ID="textdatcr" runat="server"></asp:TextBox>-->

        <asp:Label ID="Label11" runat="server" Text="telephone"></asp:Label>
    <asp:TextBox ID="texttelp" runat="server"></asp:TextBox>

        <asp:Label ID="Label12" runat="server" Text="facebook"></asp:Label>
    <asp:TextBox ID="textfb" runat="server"></asp:TextBox>

        <asp:Label ID="Label13" runat="server" Text="whatsapp"></asp:Label>
    <asp:TextBox ID="textwspp" runat="server"></asp:TextBox>

        <asp:Label ID="Label14" runat="server" Text="adresse"></asp:Label>
    <asp:TextBox ID="textadrs" runat="server"></asp:TextBox>

      

       
    <asp:TextBox ID="msg" runat="server"></asp:TextBox>
    <asp:Button ID="btnpmp" runat="server" Text="Enregistre" OnClick="btnpmp_Click" />
</asp:Content>

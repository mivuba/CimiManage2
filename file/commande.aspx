<%@ Page Title="" Language="C#" MasterPageFile="~/file/cimimanage.Master" AutoEventWireup="true" CodeBehind="commande.aspx.cs" Inherits="CimiManage.file.commande" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

      <asp:Label ID="Label1" runat="server" Text="utulisateur"></asp:Label>
  <asp:DropDownList ID="Dput" runat="server">

  </asp:DropDownList>

        <asp:Label ID="Label2" runat="server" Text="service"></asp:Label>
<asp:DropDownList ID="Dpsv" runat="server">

</asp:DropDownList>

  

   

    <asp:Label ID="Label3" runat="server" Text="code_com "></asp:Label>
    <asp:TextBox ID="txtcd" runat="server"></asp:TextBox>

       <asp:Label ID="Label5" runat="server" Text="type_com "></asp:Label>
   <asp:TextBox ID="txttyp" runat="server"></asp:TextBox>

       <asp:Label ID="Label6" runat="server" Text="reduction "></asp:Label>
   <asp:TextBox ID="txtrd" runat="server"></asp:TextBox>

       <asp:Label ID="Label7" runat="server" Text="date_com "></asp:Label>
   <asp:TextBox ID="txtdt" runat="server"></asp:TextBox>

       <asp:Label ID="Label8" runat="server" Text="statut "></asp:Label>
   <asp:TextBox ID="txtst" runat="server"></asp:TextBox>

       <asp:Label ID="Label9" runat="server" Text="etat "></asp:Label>
   <asp:TextBox ID="txtet" runat="server"></asp:TextBox>

       <asp:Label ID="Label10" runat="server" Text="prix_total "></asp:Label>
   <asp:TextBox ID="txtpt" runat="server"></asp:TextBox>

       <asp:Label ID="Label11" runat="server" Text="annee "></asp:Label>
   <asp:TextBox ID="txtann" runat="server"></asp:TextBox>

       <asp:Label ID="Label12" runat="server" Text="mois "></asp:Label>
   <asp:TextBox ID="txtm" runat="server"></asp:TextBox>

       <asp:Label ID="Label13" runat="server" Text="prix_TVA "></asp:Label>
   <asp:TextBox ID="txtptv" runat="server"></asp:TextBox>

       <asp:Label ID="Label14" runat="server" Text="type_com_location "></asp:Label>
   <asp:TextBox ID="txttpc" runat="server"></asp:TextBox>

       <asp:Label ID="Label15" runat="server" Text="type_com_achat "></asp:Label>
   <asp:TextBox ID="txttp" runat="server"></asp:TextBox>




    <asp:Label ID="msg" runat="server" Text=""></asp:Label>
    <asp:Button ID="btncomm" runat="server" Text="Enregistre" OnClick="btncomm_Click" />
</asp:Content>

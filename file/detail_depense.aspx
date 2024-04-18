<%@ Page Title="" Language="C#" MasterPageFile="~/file/cimimanage.Master" AutoEventWireup="true" CodeBehind="detail_depense.aspx.cs" Inherits="CimiManage.file.detail_depense" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:Label ID="Label1" runat="server" Text="type_depense"></asp:Label>
    <asp:DropDownList ID="Dptyp" runat="server">

    </asp:DropDownList>

    <asp:Label ID="Label3" runat="server" Text="depense"></asp:Label>
<asp:DropDownList ID="Dpdp" runat="server">

</asp:DropDownList>

    <asp:Label ID="Label2" runat="server" Text="quantite_depense"></asp:Label>
    <asp:TextBox ID="txtqd" runat="server"></asp:TextBox>


     <asp:Label ID="Label4" runat="server" Text="prix_unite"></asp:Label>
 <asp:TextBox ID="txtpu" runat="server"></asp:TextBox>

     <asp:Label ID="Label5" runat="server" Text="nom_pers"></asp:Label>
 <asp:TextBox ID="txtnp" runat="server"></asp:TextBox>

   <asp:Label ID="msg" runat="server" Text=""></asp:Label>
    <asp:Button ID="btndp" runat="server" Text="Enregistre" OnClick="btndp_Click" />
    <a href="listdetail_depense.aspx" class="btn btn-danger">Retour a la liste</a>

</asp:Content>

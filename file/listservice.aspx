<%@ Page Title="" Language="C#" MasterPageFile="~/file/cimimanage.Master" AutoEventWireup="true" CodeBehind="listservice.aspx.cs" Inherits="CimiManage.file.listservice" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="gdv" runat="server" CssClass="table table-striped table-bordered table-responsive" AutoGenerateColumns="false" OnRowCommand="gdv_RowCommand">

<Columns>

    <asp:TemplateField HeaderText="nom_produit">
        <ItemTemplate>
            <asp:Label ID="lblnp" runat="server" Text='<%# Eval("nom_produit") %>'></asp:Label>
        </ItemTemplate>
    </asp:TemplateField>

    <asp:TemplateField HeaderText="nom_pompe">
    <ItemTemplate>
        <asp:Label ID="lblnpp" runat="server" Text='<%# Eval("nom_pompe") %>'></asp:Label>
    </ItemTemplate>
</asp:TemplateField>

    <asp:TemplateField HeaderText="nom_service">
    <ItemTemplate>
        <asp:Label ID="lblns" runat="server" Text='<%# Eval("nom_service") %>'></asp:Label>
    </ItemTemplate>
</asp:TemplateField>

    <asp:TemplateField HeaderText="prix_service">
    <ItemTemplate>
        <asp:Label ID="lblps" runat="server" Text='<%# Eval("prix_service") %>'></asp:Label>
    </ItemTemplate>
</asp:TemplateField>

    <asp:TemplateField HeaderText="longitude">
    <ItemTemplate>
        <asp:Label ID="lbllg" runat="server" Text='<%# Eval("longitude") %>'></asp:Label>
    </ItemTemplate>
</asp:TemplateField>

        <asp:TemplateField HeaderText="altitude">
    <ItemTemplate>
        <asp:Label ID="lblal" runat="server" Text='<%# Eval("altitude") %>'></asp:Label>
    </ItemTemplate>
</asp:TemplateField>

        <asp:TemplateField HeaderText="ACTION">
    <ItemTemplate>
        <asp:Button  runat="server" Text="editer" CommandName="edit" CommandArgument='<%# Eval("id_service") %>'/>
        <asp:Button  runat="server" Text="supprimer" CommandName="sup" CommandArgument='<%# Eval("id_service") %>' />
    </ItemTemplate>
</asp:TemplateField>



</Columns>
    </asp:GridView>
</asp:Content>

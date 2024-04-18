<%@ Page Title="" Language="C#" MasterPageFile="~/file/cimimanage.Master" AutoEventWireup="true" CodeBehind="listdroit_menu.aspx.cs" Inherits="CimiManage.file.listdroit_menu" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="gdv" runat="server" AutoGenerateColumns="false" OnRowCommand="gdv_RowCommand">

<Columns>

<asp:TemplateField HeaderText="nom_menu">
    <ItemTemplate>
        <asp:Label ID="blbnm" runat="server" Text='<%# Eval("nom_menu") %>'></asp:Label>
    </ItemTemplate>
</asp:TemplateField>

    <asp:TemplateField HeaderText="nom_role">
    <ItemTemplate>
        <asp:Label ID="blbnr" runat="server" Text='<%# Eval("nom_role") %>'></asp:Label>
    </ItemTemplate>
</asp:TemplateField>

    <asp:TemplateField HeaderText="gerer">
    <ItemTemplate>
        <asp:Label ID="blbgr" runat="server" Text='<%# Eval("gerer") %>'></asp:Label>
    </ItemTemplate>
</asp:TemplateField>

    <asp:TemplateField HeaderText="ajouter">
    <ItemTemplate>
        <asp:Label ID="blbaj" runat="server" Text='<%# Eval("ajouter") %>'></asp:Label>
    </ItemTemplate>
</asp:TemplateField>


        <asp:TemplateField HeaderText="acces">
    <ItemTemplate>
        <asp:Label ID="blbacc" runat="server" Text='<%# Eval("acces") %>'></asp:Label>
    </ItemTemplate>
</asp:TemplateField>

     
            <asp:TemplateField HeaderText="ACTION">
    <ItemTemplate>
        <asp:Button  runat="server" Text="editer" CommandName="edit" CommandArgument='<%# Eval("id_dmenu") %>' />
    </ItemTemplate>
</asp:TemplateField>

</Columns>
    </asp:GridView>
    
</asp:Content>

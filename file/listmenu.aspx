<%@ Page Title="" Language="C#" MasterPageFile="~/file/cimimanage.Master" AutoEventWireup="true" CodeBehind="listmenu.aspx.cs" Inherits="CimiManage.file.listmenu" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:GridView ID="gdv" runat="server" CssClass="table table-striped table-bordered table-responsive" AutoGenerateColumns="false" OnRowCommand="gdv_RowCommand">
<Columns>

<asp:TemplateField HeaderText="nom_menu">
    <ItemTemplate>
        <asp:Label ID="Label1" runat="server" Text='<%# Eval("nom_menu")%>'></asp:Label>
    </ItemTemplate>
</asp:TemplateField>


    <asp:TemplateField HeaderText="link">
    <ItemTemplate>
        <asp:Label ID="Label2" runat="server" Text='<%# Eval("link")%>'></asp:Label>
    </ItemTemplate>
</asp:TemplateField>

    <asp:TemplateField HeaderText="etat">
    <ItemTemplate>
        <asp:Label ID="Label3" runat="server" Text='<%# Eval("etat")%>'></asp:Label>
    </ItemTemplate>
</asp:TemplateField>

    <asp:TemplateField HeaderText="ACTION">
    <ItemTemplate>
        <asp:Button  runat="server" Text="editer" CommandName="edit" CommandArgument='<%# Eval("id_menu")%>' />
    </ItemTemplate>
</asp:TemplateField>

</Columns>
    </asp:GridView>
</asp:Content>

<%@ Page Title="" Language="C#" MasterPageFile="~/file/cimimanage.Master" AutoEventWireup="true" CodeBehind="listrole.aspx.cs" Inherits="CimiManage.file.listrole" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="gdv" runat="server" AutoGenerateColumns="false" OnRowCommand="gdv_RowCommand">
<Columns>


<asp:TemplateField HeaderText="nom pompe">
<ItemTemplate>
    <asp:Label ID="lblnp" runat="server" Text='<%# Eval("nom_pomp") %>'></asp:Label>
</ItemTemplate>
</asp:TemplateField>

    <asp:TemplateField HeaderText="role">
<ItemTemplate>
    <asp:Label ID="lbl" runat="server" Text='<%# Eval("role") %>'></asp:Label>
</ItemTemplate>
</asp:TemplateField>

    <asp:TemplateField HeaderText="ACTION">
<ItemTemplate>
    <asp:Button  runat="server" Text="editer"  CommandName="edit" CommandArgument='<%# Eval("idrole") %>'/>

    <asp:Button  runat="server" Text="supprimer"  CommandName="sup" CommandArgument='<%# Eval("idrole") %>'/>
</ItemTemplate>
</asp:TemplateField>









</Columns>

    </asp:GridView>
</asp:Content>

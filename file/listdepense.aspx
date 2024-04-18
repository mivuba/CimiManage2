<%@ Page Title="" Language="C#" MasterPageFile="~/file/cimimanage.Master" AutoEventWireup="true" CodeBehind="listdepense.aspx.cs" Inherits="CimiManage.file.listdepense" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:GridView ID="gdv" runat="server" AutoGenerateColumns="false" OnRowCommand="gdv_RowCommand" >
<Columns>

<asp:TemplateField HeaderText="total_depense">
    <ItemTemplate>
        <asp:Label ID="Label1" runat="server" Text='<%# Eval("total_depense")%>'></asp:Label>
    </ItemTemplate>
</asp:TemplateField>


<asp:TemplateField HeaderText="mois">
    <ItemTemplate>
        <asp:Label ID="Label2" runat="server" Text='<%# Eval("mois")%>'></asp:Label>
    </ItemTemplate>
</asp:TemplateField>

<asp:TemplateField HeaderText="annee">
    <ItemTemplate>
        <asp:Label ID="Label3" runat="server" Text='<%# Eval("annee")%>'></asp:Label>
    </ItemTemplate>
</asp:TemplateField>


    <asp:TemplateField HeaderText="statut">
    <ItemTemplate>
        <asp:Label ID="Label4" runat="server" Text='<%# Eval("statut")%>'></asp:Label>
    </ItemTemplate>
</asp:TemplateField>

        <asp:TemplateField HeaderText="">
    <ItemTemplate>
       
        <asp:Button  runat="server" Text="editer"  CommandName="edit" CommandArgument='<%# Eval("id_dep")%>'/>
    </ItemTemplate>
</asp:TemplateField>



</Columns>
    </asp:GridView>
</asp:Content>

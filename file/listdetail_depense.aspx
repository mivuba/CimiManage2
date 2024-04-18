<%@ Page Title="" Language="C#" MasterPageFile="~/file/cimimanage.Master" AutoEventWireup="true" CodeBehind="listdetail_depense.aspx.cs" Inherits="CimiManage.file.listdetail_depense" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="gdv" runat="server" AutoGenerateColumns="false" OnRowCommand="gvd_RowCommand">

        <Columns>

<asp:TemplateField HeaderText="type_depens">
    <ItemTemplate>
        <asp:Label ID="lbltp" runat="server" Text='<%# Eval("type_depens") %>'></asp:Label>
    </ItemTemplate>
</asp:TemplateField>

<asp:TemplateField  HeaderText="total_depense">
    <ItemTemplate>
        <asp:Label ID="lblntp" runat="server" Text='<%# Eval("total_depense") %>'></asp:Label>
    </ItemTemplate>
</asp:TemplateField>

            <asp:TemplateField  HeaderText="quantite_depense">
    <ItemTemplate>
        <asp:Label ID="lblqdp" runat="server" Text='<%# Eval("quantite_depense") %>'></asp:Label>
    </ItemTemplate>
</asp:TemplateField>

            <asp:TemplateField  HeaderText="prix_unite">
    <ItemTemplate>
        <asp:Label ID="lblpu" runat="server" Text='<%# Eval("prix_unite") %>'></asp:Label>
    </ItemTemplate>
</asp:TemplateField>

                        <asp:TemplateField HeaderText="nom_pers">
    <ItemTemplate>
        <asp:Label ID="lblnp" runat="server" Text='<%# Eval("nom_pers") %>'></asp:Label>
    </ItemTemplate>
</asp:TemplateField>

            <asp:TemplateField HeaderText="ACTION">
    <ItemTemplate>
        <asp:Button  runat="server" Text="Editer" CommandName="edit" CommandArgument='<%# Eval("id_det_dep") %>' />
        
    </ItemTemplate>
</asp:TemplateField>

        </Columns>
    </asp:GridView>

</asp:Content>

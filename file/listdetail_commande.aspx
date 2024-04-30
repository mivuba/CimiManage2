<%@ Page Title="" Language="C#" MasterPageFile="~/file/cimimanage.Master" AutoEventWireup="true" CodeBehind="listdetail_commande.aspx.cs" Inherits="CimiManage.file.listdetail_commande" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:GridView ID="gdv" runat="server" CssClass="table table-striped table-bordered table-responsive" AutoGenerateColumns="false" OnRowCommand="gdv_RowCommand">
        <Columns>

            <asp:TemplateField HeaderText="type_commande">
                <ItemTemplate>
                    <asp:Label ID="lbltyc" runat="server" Text='<%# Eval("type_com") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>

            <asp:TemplateField HeaderText="nom_service">
    <ItemTemplate>
        <asp:Label ID="lblns" runat="server" Text='<%# Eval("nom_service") %>'></asp:Label>
    </ItemTemplate>
</asp:TemplateField>

            <asp:TemplateField HeaderText="Prix uniteur">
    <ItemTemplate>
        <asp:Label ID="lblpu" runat="server" Text='<%# Eval("PU") %>'></asp:Label>
    </ItemTemplate>
</asp:TemplateField>

            <asp:TemplateField HeaderText="nom_feu">
    <ItemTemplate>
        <asp:Label ID="lblnf" runat="server" Text='<%# Eval("nom_feu") %>'></asp:Label>
    </ItemTemplate>
</asp:TemplateField>

            <asp:TemplateField HeaderText="date_nassance">
    <ItemTemplate>
        <asp:Label ID="lbldn" runat="server" Text='<%# Eval("date_nass") %>'></asp:Label>
    </ItemTemplate>
</asp:TemplateField>

            <asp:TemplateField HeaderText="date_dece">
    <ItemTemplate>
        <asp:Label ID="lbldd" runat="server" Text='<%# Eval("date_dece") %>'></asp:Label>
    </ItemTemplate>
</asp:TemplateField>

            <asp:TemplateField HeaderText="quantite detail commande">
    <ItemTemplate>
        <asp:Label ID="lblqdc" runat="server" Text='<%# Eval("quantite_d_com") %>'></asp:Label>
    </ItemTemplate>
</asp:TemplateField>

            
            <asp:TemplateField HeaderText="ACTION">
    <ItemTemplate>
        <asp:Button  runat="server" Text="editer" CommandName="edit" CommandArgument='<%# Eval("id_detail_com") %>' />
        <asp:Button  runat="server" Text="Button" CommandName="" CommandArgument='<%# Eval("id_detail_com") %>' />
    </ItemTemplate>
</asp:TemplateField>

        </Columns>
    </asp:GridView>
</asp:Content>

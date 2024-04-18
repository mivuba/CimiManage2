<%@ Page Title="" Language="C#" MasterPageFile="~/file/cimimanage.Master" AutoEventWireup="true" CodeBehind="listtype_depense.aspx.cs" Inherits="CimiManage.file.listtype_depense" %>
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


            
<asp:TemplateField HeaderText="type_depense">
    <ItemTemplate>
        <asp:Label ID="lbl" runat="server" Text='<%# Eval("type_depenss") %>'></asp:Label>
    </ItemTemplate>
</asp:TemplateField>


<asp:TemplateField HeaderText="ACTION">
    <ItemTemplate>
        <asp:Button  runat="server" Text="editer" CommandName="edit" CommandArgument='<%# Eval("id_type_dep") %>' />
        <asp:Button  runat="server" Text="supprimer" CommandName="sup" CommandArgument='<%# Eval("id_type_dep") %>'  />
    </ItemTemplate>
</asp:TemplateField>


        </Columns>
    </asp:GridView>
</asp:Content>

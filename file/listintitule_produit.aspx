<%@ Page Title="" Language="C#" MasterPageFile="~/file/cimimanage.Master" AutoEventWireup="true" CodeBehind="listintitule_produit.aspx.cs" Inherits="CimiManage.file.listintitule_produit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="gdv" runat="server" AutoGenerateColumns="false" OnRowCommand="gdv_RowCommand">
<Columns>


    <asp:TemplateField HeaderText="nom_produit">
        <ItemTemplate>
            <asp:Label ID="Label1" runat="server" Text='<%# Eval("nom_produit")%>'></asp:Label>
        </ItemTemplate>
    </asp:TemplateField>




  <asp:TemplateField HeaderText="ACTION">
      <ItemTemplate>
          <asp:Button  runat="server" Text="editer"  CommandName="edit" CommandArgument='<%# Eval("id_produit")%>' />
          <asp:Button  runat="server" Text="supprimer"  CommandName="sup" CommandArgument='<%# Eval("id_produit")%>' />
      </ItemTemplate>
  </asp:TemplateField>
</Columns>
    </asp:GridView>
</asp:Content>

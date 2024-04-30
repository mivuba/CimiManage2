<%@ Page Title="" Language="C#" MasterPageFile="~/file/cimimanage.Master" AutoEventWireup="true" CodeBehind="listpersonne.aspx.cs" Inherits="CimiManage.file.listpersonne" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:GridView ID="gdv" runat="server" CssClass="table table-striped table-bordered table-responsive" AutoGenerateColumns="false" OnRowCommand="gdv_RowCommand" >
<Columns>
<asp:TemplateField HeaderText="user_name">
    <ItemTemplate>
        <asp:Label runat="server" Text='<%# Eval("user_name")%>'></asp:Label>
    </ItemTemplate>
</asp:TemplateField>
    
    <asp:TemplateField HeaderText="password">
    <ItemTemplate>
        <asp:Label runat="server" Text='<%# Eval("password")%>'></asp:Label>
    </ItemTemplate>
</asp:TemplateField>

    <asp:TemplateField HeaderText="etat">
    <ItemTemplate>
          <asp:Label runat="server" Text='<%# Eval("etat")%>'></asp:Label>
    </ItemTemplate>
</asp:TemplateField>

    
    <asp:TemplateField HeaderText="ACTION">
    <ItemTemplate>
        <asp:Button  runat="server" Text="editer" CommandName="edit" CommandArgument='<%# Eval("id_pers")%>' />
         <asp:Button  runat="server" Text="Supprimer"  CommandName="sup" CommandArgument='<%# Eval("id_pers")%>' />
    </ItemTemplate>
</asp:TemplateField>



</Columns>

    </asp:GridView>

</asp:Content>

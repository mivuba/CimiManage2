<%@ Page Title="" Language="C#" MasterPageFile="~/file/cimimanage.Master" AutoEventWireup="true" CodeBehind="listepompe_funeble.aspx.cs" Inherits="CimiManage.file.listepompe_funeble" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:GridView ID="gdv" runat="server" AutoGenerateColumns="false" OnRowCommand="gdv_RowCommand">
    <columns>

<asp:TemplateField HeaderText="nom_pompe">
    <ItemTemplate>
        <asp:Label ID="Label1" runat="server" Text='<%# Eval("nom_p")%>'></asp:Label>
    </ItemTemplate>
</asp:TemplateField>

        <asp:TemplateField HeaderText="email">
    <ItemTemplate>
        <asp:Label ID="Label2" runat="server" Text='<%# Eval("mail")%>'></asp:Label>
    </ItemTemplate>
</asp:TemplateField>

        <asp:TemplateField HeaderText="NIF">
    <ItemTemplate>
        <asp:Label ID="Label3" runat="server" Text='<%# Eval("nif")%>'></asp:Label>
    </ItemTemplate>
</asp:TemplateField>

        <asp:TemplateField HeaderText="code">
    <ItemTemplate>
        <asp:Label ID="Label4" runat="server" Text='<%# Eval("cod")%>'></asp:Label>
    </ItemTemplate>
</asp:TemplateField>

        <asp:TemplateField HeaderText="statut">
    <ItemTemplate>
        <asp:Label ID="Label5" runat="server" Text='<%# Eval("statut")%>'></asp:Label>
    </ItemTemplate>
</asp:TemplateField>

        <asp:TemplateField HeaderText="etat">
    <ItemTemplate>
        <asp:Label ID="Label6" runat="server" Text='<%# Eval("etat")%>'></asp:Label>
    </ItemTemplate>
</asp:TemplateField>

        <asp:TemplateField HeaderText="logos">
    <ItemTemplate>
        <asp:Label ID="Label7" runat="server" Text='<%# Eval("logo")%>'></asp:Label>
    </ItemTemplate>
</asp:TemplateField>

        <asp:TemplateField HeaderText="telephone">
    <ItemTemplate>
         <asp:Label ID="Label8" runat="server" Text='<%# Eval("phone")%>'></asp:Label>
    </ItemTemplate>
</asp:TemplateField>

        <asp:TemplateField HeaderText="RC">
    <ItemTemplate>
        <asp:Label ID="Label9" runat="server" Text='<%# Eval(" rc")%>'></asp:Label>
    </ItemTemplate>
</asp:TemplateField>

        <asp:TemplateField HeaderText="sigle">
    <ItemTemplate>
        <asp:Label ID="Label10" runat="server" Text='<%# Eval("sigl")%>'></asp:Label>
    </ItemTemplate>
</asp:TemplateField>

        <asp:TemplateField HeaderText="date_creation">
    <ItemTemplate>
         <asp:Label ID="Label11" runat="server" Text='<%# Eval("date_creation")%>'></asp:Label>
    </ItemTemplate>
</asp:TemplateField>

        <asp:TemplateField HeaderText="facebook">
    <ItemTemplate>
           <asp:Label ID="Label12" runat="server" Text='<%# Eval("facebook")%>'></asp:Label>
    </ItemTemplate>
</asp:TemplateField>

        <asp:TemplateField HeaderText="whatshapp">
    <ItemTemplate>
        <asp:Label ID="Label13" runat="server" Text='<%# Eval("whatsapp")%>'></asp:Label>
    </ItemTemplate>
</asp:TemplateField>

        <asp:TemplateField HeaderText="adresse">
    <ItemTemplate>
        <asp:Label ID="Label14" runat="server" Text='<%# Eval("adress")%>'></asp:Label>
    </ItemTemplate>
</asp:TemplateField>

    
                <asp:TemplateField HeaderText="ACTION">
    <ItemTemplate>

        <asp:Button  runat="server" Text="editer"  CommandName="edit" CommandArgument='<%# Eval("id_pompe")%>'/>
        <asp:Button  runat="server" Text="supprimer" CommandName="sup" CommandArgument='<%# Eval("id_pompe")%>' />
        
    </ItemTemplate>
</asp:TemplateField>




    </columns>
        </asp:GridView>
</asp:Content>

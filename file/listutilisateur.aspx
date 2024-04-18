<%@ Page Title="" Language="C#" MasterPageFile="~/file/cimimanage.Master" AutoEventWireup="true" CodeBehind="listutilisateur.aspx.cs" Inherits="CimiManage.file.listutilisateur" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:GridView ID="gdv" runat="server" AutoGenerateColumns="false" OnRowCommand="gdv_RowCommand">

<Columns>

     <asp:TemplateField HeaderText="user_name">
     <ItemTemplate>
         <asp:Label ID="lblus" runat="server" Text='<%# Eval("user_name") %>'></asp:Label>
     </ItemTemplate>
 </asp:TemplateField>

     <asp:TemplateField HeaderText="nom_role">
     <ItemTemplate>
         <asp:Label ID="lblro" runat="server" Text='<%# Eval("nom_role") %>'></asp:Label>
     </ItemTemplate>
 </asp:TemplateField>

     <asp:TemplateField HeaderText="nom_pompe">
     <ItemTemplate>
         <asp:Label ID="lblpo" runat="server" Text='<%# Eval("nom_pompe") %>'></asp:Label>
     </ItemTemplate>
 </asp:TemplateField>

    <asp:TemplateField HeaderText="nom_ut">
        <ItemTemplate>
            <asp:Label ID="lblnp" runat="server" Text='<%# Eval("nom_ut") %>'></asp:Label>
        </ItemTemplate>
    </asp:TemplateField>

    
    <asp:TemplateField HeaderText="prenom_ut">
        <ItemTemplate>
            <asp:Label ID="lblpu" runat="server" Text='<%# Eval("prenom_ut") %>'></asp:Label>  
        </ItemTemplate>
    </asp:TemplateField>

    
    <asp:TemplateField HeaderText="telephone">
        <ItemTemplate>
            <asp:Label ID="lbltl" runat="server" Text='<%# Eval("telephone") %>'></asp:Label>
        </ItemTemplate>
    </asp:TemplateField>

    
    <asp:TemplateField HeaderText="email">
        <ItemTemplate>
            <asp:Label ID="lblem" runat="server" Text='<%# Eval("email") %>'></asp:Label>
        </ItemTemplate>
    </asp:TemplateField>

    
    <asp:TemplateField HeaderText="type_client">
        <ItemTemplate>
            <asp:Label ID="lbltc" runat="server" Text='<%# Eval("type_client") %>'></asp:Label>
        </ItemTemplate>
    </asp:TemplateField>

    
    <asp:TemplateField HeaderText="type_personne">
        <ItemTemplate>
            <asp:Label ID="lbltp" runat="server" Text='<%# Eval("type_personne") %>'></asp:Label>
        </ItemTemplate>
    </asp:TemplateField>

    
    <asp:TemplateField HeaderText="adresse">
        <ItemTemplate>
            <asp:Label ID="lblad" runat="server" Text='<%# Eval("adresse") %>'></asp:Label>
        </ItemTemplate>
    </asp:TemplateField>

    
    <asp:TemplateField HeaderText="ACTION">
        <ItemTemplate>
            <asp:Button  runat="server" Text="editer"  CommandName="edit" CommandArgument='<%# Eval("id_ut") %>'/>
            <asp:Button  runat="server" Text="supprimer" CommandName="sup" CommandArgument='<%# Eval("id_ut") %>' />
        </ItemTemplate>
    </asp:TemplateField>







</Columns>



    </asp:GridView>
</asp:Content>

<%@ Page Title="" Language="C#" MasterPageFile="~/file/cimimanage.Master" AutoEventWireup="true" CodeBehind="listpompe_funeble.aspx.cs" Inherits="CimiManage.file.listpompe_funeble" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:GridView ID="gdv" runat="server" AutoGenerateColumns="false" OnRowCommand="gdv_RowCommand">
<Columns>

    <asp:TemplateField HeaderText="nom_pompe">
        <ItemTemplate>
            <asp:Label ID="lblnp" runat="server" Text='<%# Eval("nom_p")%>'></asp:Label>
        </ItemTemplate>
    </asp:TemplateField>


       <asp:TemplateField HeaderText="email">
       <ItemTemplate>
           <asp:Label ID="lblml" runat="server" Text='<%# Eval("mail")%>'></asp:Label>
       </ItemTemplate>
   </asp:TemplateField>

       <asp:TemplateField  HeaderText="NIF">
       <ItemTemplate>
           <asp:Label ID="lblnf" runat="server" Text='<%# Eval("nif")%>'></asp:Label>
       </ItemTemplate>
   </asp:TemplateField>

       <asp:TemplateField  HeaderText="code">
       <ItemTemplate>
           <asp:Label ID="lblcd" runat="server" Text='<%# Eval("cod")%>'></asp:Label>
       </ItemTemplate>
   </asp:TemplateField>

       <asp:TemplateField  HeaderText="statut">
       <ItemTemplate>
           <asp:Label ID="lblst" runat="server" Text='<%# Eval("statut")%>'></asp:Label>
       </ItemTemplate>
   </asp:TemplateField>

       <asp:TemplateField  HeaderText="etat">
       <ItemTemplate>
           <asp:Label ID="lblet" runat="server" Text='<%# Eval("etat")%>'></asp:Label>
       </ItemTemplate>
   </asp:TemplateField>


    
       <asp:TemplateField  HeaderText="logo">
       <ItemTemplate>
           <asp:Image ID="Ilg" runat="server" ImageUrl='<%# Eval("logo")%>' Height="30px" Width="30px"/>
       </ItemTemplate>
   </asp:TemplateField>
      

       <asp:TemplateField  HeaderText="telephone">
       <ItemTemplate>
           <asp:Label ID="lblph" runat="server" Text='<%# Eval("phone")%>'></asp:Label>
       </ItemTemplate>
   </asp:TemplateField>

       <asp:TemplateField  HeaderText="RC">
       <ItemTemplate>
           <asp:Label ID="lblrc" runat="server" Text='<%# Eval("rc")%>'></asp:Label>
       </ItemTemplate>
   </asp:TemplateField>

       <asp:TemplateField  HeaderText="sigle">
       <ItemTemplate>
           <asp:Label ID="lblsg" runat="server" Text='<%# Eval("sigl")%>'></asp:Label>
       </ItemTemplate>
   </asp:TemplateField>

        <asp:TemplateField  HeaderText="date_creation">
    <ItemTemplate>
        <asp:Label ID="lbldcr" runat="server" Text='<%# Eval("date_creation")%>'></asp:Label>
    </ItemTemplate>
</asp:TemplateField>

        <asp:TemplateField  HeaderText="facebook">
    <ItemTemplate>
        <asp:Label ID="lblfc" runat="server" Text='<%# Eval("facebook")%>'></asp:Label>
    </ItemTemplate>
</asp:TemplateField>

        <asp:TemplateField  HeaderText="whatshapp">
    <ItemTemplate>
        <asp:Label ID="lblwh" runat="server" Text='<%# Eval("whatsapp")%>'></asp:Label>
    </ItemTemplate>
</asp:TemplateField>

        <asp:TemplateField  HeaderText="adresse">
    <ItemTemplate>
        <asp:Label ID="lblad" runat="server" Text='<%# Eval("adress")%>'></asp:Label>
    </ItemTemplate>
</asp:TemplateField>


            <asp:TemplateField HeaderText="ACTION">
    <ItemTemplate>
        <asp:Button  runat="server" Text="editer" CommandName="edit" CommandArgument='<%# Eval("id_pompe")%>'/>

        <asp:Button runat="server" Text="supprimer" CommandName="sup" CommandArgument='<%# Eval("id_pompe")%>'/>
    </ItemTemplate>
</asp:TemplateField>

</Columns>
    </asp:GridView>
</asp:Content>

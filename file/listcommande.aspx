<%@ Page Title="" Language="C#" MasterPageFile="~/file/cimimanage.Master" AutoEventWireup="true" CodeBehind="listcommande.aspx.cs" Inherits="CimiManage.file.listcommande" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:GridView ID="gdv" runat="server" AutoGenerateColumns="false" OnRowCommand="gdv_RowCommand">

        <Columns>

            <asp:TemplateField HeaderText="nom_ut">
                <ItemTemplate>
                    <asp:Label ID="lblnu" runat="server" Text='<%# Eval("nom_ut") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>

             <asp:TemplateField HeaderText="nom_service">
     <ItemTemplate>
          <asp:Label ID="lblns" runat="server" Text='<%# Eval("nom_service") %>'></asp:Label>
     </ItemTemplate>
 </asp:TemplateField>

             <asp:TemplateField HeaderText="code_com" >
     <ItemTemplate>
          <asp:Label ID="lblcd" runat="server" Text='<%# Eval("code_com") %>'></asp:Label>
     </ItemTemplate>
 </asp:TemplateField>

             <asp:TemplateField HeaderText="type_com">
     <ItemTemplate>
          <asp:Label ID="lbltc" runat="server" Text='<%# Eval("type_com") %>'></asp:Label>
     </ItemTemplate>
 </asp:TemplateField>

             <asp:TemplateField HeaderText="reduction">
     <ItemTemplate>
         <asp:Label ID="lblrd" runat="server" Text='<%# Eval("reduction") %>'></asp:Label>
     </ItemTemplate>
 </asp:TemplateField>

             <asp:TemplateField HeaderText="date_com">
     <ItemTemplate>
         
         <asp:Label ID="lbldt" runat="server" Text='<%# Eval("date_com") %>'></asp:Label>
     </ItemTemplate>
 </asp:TemplateField>

             <asp:TemplateField HeaderText="statut">
     <ItemTemplate>
          <asp:Label ID="lblst" runat="server" Text='<%# Eval("statut") %>'></asp:Label>
     </ItemTemplate>
 </asp:TemplateField>

             <asp:TemplateField HeaderText="etat">
     <ItemTemplate>
         <asp:Label ID="lblet" runat="server" Text='<%# Eval("etat") %>'></asp:Label>
     </ItemTemplate>
 </asp:TemplateField>

             <asp:TemplateField  HeaderText="prix_total">
     <ItemTemplate>
                  <asp:Label ID="lblpt" runat="server" Text='<%# Eval("prix_total") %>'></asp:Label>
     </ItemTemplate>
 </asp:TemplateField>

             <asp:TemplateField HeaderText="annee">
     <ItemTemplate>
          <asp:Label ID="lblan" runat="server" Text='<%# Eval("annee") %>'></asp:Label>
     </ItemTemplate>
 </asp:TemplateField>

             <asp:TemplateField HeaderText="mois">
     <ItemTemplate>
         <asp:Label ID="lblms" runat="server" Text='<%# Eval("mois") %>'></asp:Label>
     </ItemTemplate>
 </asp:TemplateField>

             <asp:TemplateField HeaderText="prix_TVA">
     <ItemTemplate>
          <asp:Label ID="lblptv" runat="server" Text='<%# Eval("prix_TVA") %>'></asp:Label>
     </ItemTemplate>
 </asp:TemplateField>

             <asp:TemplateField HeaderText="type_com_location">
     <ItemTemplate>
          <asp:Label ID="lbltcl" runat="server" Text='<%# Eval("type_com_location") %>'></asp:Label>
     </ItemTemplate>
 </asp:TemplateField>

             <asp:TemplateField HeaderText="type_com_achat">
     <ItemTemplate>
          <asp:Label ID="lbltca" runat="server" Text='<%# Eval("type_com_achat") %>'></asp:Label>
     </ItemTemplate>
 </asp:TemplateField>

             <asp:TemplateField HeaderText="ACTION">
     <ItemTemplate>
         <asp:Button  runat="server" Text="editer" CommandName="edit" CommandArgument='<%# Eval("id_com") %>'/>
         <asp:Button  runat="server" Text="supprimer" CommandName="sup" CommandArgument='<%# Eval("id_com") %>'/>
     </ItemTemplate>
 </asp:TemplateField>



        </Columns>
    </asp:GridView>
</asp:Content>

<%@ Page Title="" Language="C#" MasterPageFile="~/file/cimimanage.Master" AutoEventWireup="true" CodeBehind="detail_depense.aspx.cs" Inherits="CimiManage.file.detail_depense" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

            <main id="main" class="main">
    <section class="section">
<div class="card container w-75">
    <div class="row">
        <div class="col-lg-6">
    <asp:Label ID="Label1" runat="server" Text="type_depense"></asp:Label>
    <asp:DropDownList ID="Dptyp" CssClass="form-control" runat="server">

    </asp:DropDownList>

    <asp:Label ID="Label3" runat="server" Text="depense"></asp:Label>
<asp:DropDownList ID="Dpdp" CssClass="form-control" runat="server">

</asp:DropDownList>
            </div>
       <div class="col-lg-6">
    <asp:Label ID="Label2" runat="server" Text="quantite_depense"></asp:Label>
    <asp:TextBox ID="txtqd" CssClass="form-control" runat="server"></asp:TextBox>


     <asp:Label ID="Label4" runat="server" Text="prix_unite"></asp:Label>
 <asp:TextBox ID="txtpu" CssClass="form-control" runat="server"></asp:TextBox>
</div>
     <asp:Label ID="Label5" runat="server" Text="nom_pers"></asp:Label>
 <asp:TextBox ID="txtnp" CssClass="form-control" runat="server"></asp:TextBox>

        <div style="margin-left:250px; margin-top:10px;">
   <asp:Label ID="msg" runat="server" Text=""></asp:Label>
    <asp:Button ID="btndp" class="btn btn-primary" runat="server" Text="Enregistre" OnClick="btndp_Click" />
    <a href="listdetail_depense.aspx" class="btn btn-danger">Retour a la liste</a>
            </div>
                         </div>
</div>
           </section>
       </main>
</asp:Content>

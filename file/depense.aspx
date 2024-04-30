<%@ Page Title="" Language="C#" MasterPageFile="~/file/cimimanage.Master" AutoEventWireup="true" CodeBehind="depense.aspx.cs" Inherits="CimiManage.file.depense" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <main id="main" class="main">>
        <section class="section">
    <div class="card container w-75">
        <div class="row">
           
            <div class="col-lg-6">

   
    <asp:Label ID="Label1" runat="server" Text="total_depense"></asp:Label>
    <asp:TextBox ID="txttp" CssClass="form-control" runat="server"></asp:TextBox>

      <asp:Label ID="Label2" runat="server" Text="mois"></asp:Label>
  <asp:TextBox ID="txtms" CssClass="form-control" runat="server"></asp:TextBox>
</div>
            <div class="col-lg-6">
      <asp:Label ID="Label3" runat="server" Text="annee"></asp:Label>
  <asp:TextBox ID="txtan" CssClass="form-control" runat="server"></asp:TextBox>

        <asp:Label ID="Label5" runat="server" Text="statut"></asp:Label>
<asp:TextBox ID="txtst" CssClass="form-control"  runat="server"></asp:TextBox>
</div>
            <div class="" style="margin-left:250px; margin-top:10px;">
    <asp:Label ID="msg" runat="server" Text=""></asp:Label>
    <asp:Button ID="btndp" Class ="btn btn-primary" runat="server" Text="Enregistre" OnClick="btndp_Click" />
         </div>                
     </div>
 </div>
            </section>
        </main>
</asp:Content>

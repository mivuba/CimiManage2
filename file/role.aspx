<%@ Page Title="" Language="C#" MasterPageFile="~/file/cimimanage.Master" AutoEventWireup="true" CodeBehind="role.aspx.cs" Inherits="CimiManage.file.role" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

        <main id="main" class="main">
    <section class="section">
<div class="card container w-75">
    <div class="row">
        <div class="col-lg-12">

    <asp:Label ID="Label1" runat="server" Text="pompe_funeble"></asp:Label>
    <asp:DropDownList ID="Dppompe" CssClass="form-control" runat="server">

    </asp:DropDownList>

    <asp:Label ID="Label2" runat="server" Text="nom_role"></asp:Label>
    <asp:TextBox ID="txtrl" CssClass="form-control" runat="server"></asp:TextBox>
</div>
        <div style="margin-left:250px; margin-top:10px;">
     <asp:Label ID="msg" runat="server" Text=""></asp:Label>
    <asp:Button ID="btnrole" Class ="btn btn-primary" runat="server" Text="Enregistre" OnClick="btnrole_Click" />
     <a href="listrole.aspx" class="btn btn-danger">Retour a la liste</a>
            </div>
                         </div>
</div>
           </section>
       </main>
</asp:Content>

<%@ Page Title="" Language="C#" MasterPageFile="~/file/cimimanage.Master" AutoEventWireup="true" CodeBehind="droit_menu.aspx.cs" Inherits="CimiManage.file.droit_menu" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


            <main id="main" class="main">
    <section class="section">
<div class="card container w-75">
    <div class="row">

        <div class="col-lg-6">
    <asp:Label ID="Label1" runat="server" Text="Nom role"></asp:Label>
    <asp:DropDownList ID="Dpnr" CssClass="form-control" runat="server"></asp:DropDownList>

     <asp:Label ID="Label4" runat="server" Text="Nom menu "></asp:Label>
 <asp:DropDownList ID="Dpnm" CssClass="form-control" runat="server"></asp:DropDownList>
   </div>
        <div class="col-lg-6">
    <asp:Label ID="Label2" runat="server" Text="gerer"></asp:Label>
        <asp:TextBox ID="txtg" CssClass="form-control" runat="server"></asp:TextBox>

    <asp:Label ID="Label3" runat="server" Text="ajouter"></asp:Label>
    <asp:TextBox ID="txtaj" CssClass="form-control" runat="server"></asp:TextBox>
</div>
        
    <asp:Label ID="Label5" runat="server" Text="acces"></asp:Label>
    <asp:TextBox ID="txtac" CssClass="form-control" runat="server"></asp:TextBox>

        <div style="margin-left:250px; margin-top:10px;">
    <asp:Label ID="msg" runat="server" Text=""></asp:Label>
       <asp:Button ID="btndm" Class ="btn btn-primary" runat="server" Text="Enregistre" OnClick="btndm_Click" />
</div>
                                 </div>
</div>
           </section>
       </main>
</asp:Content>

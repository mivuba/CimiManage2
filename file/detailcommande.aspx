<%@ Page Title="" Language="C#" MasterPageFile="~/file/cimimanage.Master" AutoEventWireup="true" CodeBehind="detailcommande.aspx.cs" Inherits="CimiManage.file.detailcommande" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

            <main id="main" class="main">
    <section class="section">
<div class="card container w-75">
    <div class="row">
        <div class="col-lg-6">
    <asp:Label ID="Label1" runat="server" Text="service"></asp:Label>
    <asp:DropDownList ID="Dpsc" CssClass="form-control" runat="server"></asp:DropDownList>

    <asp:Label ID="Label2" runat="server" Text="commande"></asp:Label>
    <asp:DropDownList ID="Dpcm" CssClass="form-control" runat="server"></asp:DropDownList>
        
    <asp:Label ID="Label3" runat="server" Text="PU"></asp:Label>
    <asp:TextBox ID="txtpu" CssClass="form-control" runat="server"></asp:TextBox>
        </div>
        <div class="col-lg-6">
    <asp:Label ID="Label4" runat="server" Text="nom_feu"></asp:Label>
    <asp:TextBox ID="txtnf" CssClass="form-control" runat="server"></asp:TextBox>

    <asp:Label ID="Label5" runat="server" Text="date_nass"></asp:Label>
    <asp:TextBox ID="txtdn" Type="date" CssClass="form-control" runat="server"></asp:TextBox>

    <asp:Label ID="Label6" runat="server" Text="date_dece"></asp:Label>
    <asp:TextBox ID="txtdd" Type="date" CssClass="form-control" runat="server"></asp:TextBox>
            </div>
    
    <asp:Label ID="Label7" runat="server" Text="quantite_d_com"></asp:Label>
    <asp:TextBox ID="txtqc" CssClass="form-control" runat="server"></asp:TextBox>

        <div style="margin-left:250px; margin-top:10px;">
    <asp:Label ID="msg" runat="server" Text=""></asp:Label>
    <asp:Button ID="btndt" Class ="btn btn-primary" runat="server" Text="Enregistre" OnClick="btndt_Click" />
            </div>
            </div>
                                 
</div>
           </section>
       </main>
</asp:Content>

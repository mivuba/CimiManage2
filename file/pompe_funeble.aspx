<%@ Page Title="" Language="C#" MasterPageFile="~/file/cimimanage.Master" AutoEventWireup="true" CodeBehind="pompe_funeble.aspx.cs" Inherits="CimiManage.file.pompe_funeble" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <main id="main" class="main">
        
        <section class="section">
            <div class="card container w-75" style="background-color:ButtonShadow">
                <div class="row">
<div class="col-lg-6">
    <asp:Label ID="Label1" runat="server" Text="nom_pompe"></asp:Label>
    <asp:DropDownList ID="Dppompe" CssClass="form-control" runat="server">
         <asp:ListItem>Selectionner le nom de la pompe funeble </asp:ListItem>
         <asp:ListItem Value="muha pompe"> muha pompe </asp:ListItem>
         <asp:ListItem Value="mukaza pompe">mukaza pompe </asp:ListItem>
         <asp:ListItem Value="kanyosha pompe"> kanyosha pompe </asp:ListItem>
    </asp:DropDownList>

        <asp:Label ID="Label2" runat="server" Text="email"></asp:Label>
    <asp:TextBox ID="textml" CssClass="form-control" runat="server"></asp:TextBox>

        <asp:Label ID="Label3" runat="server" Text="nif"></asp:Label>
    <asp:TextBox ID="textnf" CssClass="form-control" runat="server"></asp:TextBox>
    </div>
           <div class="col-lg-6">        
        <asp:Label ID="Label4" runat="server" Text="cod"></asp:Label>
    <asp:TextBox ID="textcd" CssClass="form-control" runat="server"></asp:TextBox>

        <asp:Label ID="Label5" runat="server" Text="statut"></asp:Label>
    <asp:TextBox ID="textstat" CssClass="form-control" runat="server"></asp:TextBox>

        <asp:Label ID="Label6" runat="server" Text="etat"></asp:Label>
    <asp:TextBox ID="textet" CssClass="form-control" runat="server"></asp:TextBox>
 </div>
                     <div class="col-lg-6">
        <asp:Label ID="Label7" runat="server" Text="logo"></asp:Label>
    <asp:FileUpload ID="FileUpload1" CssClass="form-control" runat="server" />

        <asp:Label ID="Label8" runat="server" Text="rc"></asp:Label>
    <asp:TextBox ID="textrc" CssClass="form-control" runat="server"></asp:TextBox>

        <asp:Label ID="Label9" runat="server" Text="sigl"></asp:Label>
    <asp:TextBox ID="textsgl" CssClass="form-control" runat="server"></asp:TextBox>

                     
        <asp:Label ID="Label10" runat="server" Text="date_creation"></asp:Label>
    <asp:TextBox ID="textdatcr" CssClass="form-control" type="date" runat="server"></asp:TextBox>
</div>
                    <div class="col-lg-6">
        <asp:Label ID="Label11" runat="server" Text="telephone"></asp:Label>
    <asp:TextBox ID="texttelp" CssClass="form-control" runat="server"></asp:TextBox>

        <asp:Label ID="Label12" runat="server" Text="facebook"></asp:Label>
    <asp:TextBox ID="textfb" CssClass="form-control" runat="server"></asp:TextBox>

                    
   
     <asp:Label ID="Label13" runat="server" Text="whatsapp"></asp:Label>
 <asp:TextBox ID="textwspp" CssClass="form-control" runat="server"></asp:TextBox>

        <asp:Label ID="Label14" runat="server" Text="adresse"></asp:Label>
    <asp:TextBox ID="textadrs" CssClass="form-control" runat="server"></asp:TextBox>
</div>
      

         <div class="" style="margin-left:250px; margin-top:10px;">


  <asp:TextBox ID="msg" runat="server"></asp:TextBox>
    <asp:Button ID="btnpmp" Class ="btn btn-primary" runat="server" Text="Enregistre" OnClick="btnpmp_Click" />


                 </div>
                </div>
                </div>
            </section>
        </main>

    
 
</asp:Content>

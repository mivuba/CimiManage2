<%@ Page Title="" Language="C#" MasterPageFile="~/file/cimimanage.Master" AutoEventWireup="true" CodeBehind="personne.aspx.cs" Inherits="CimiManage.file.personne" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <main id="main" class="main">
        <section class="section">

            <div class="card container w-50" ><%--style="background-color:ButtonShadow"--%>
                <div class="row">

                    <div class="col-lg-12">
    <asp:Label ID="Label1" runat="server" Text="users"></asp:Label>
    <asp:TextBox ID="txtus" CssClass="form-control" runat="server"></asp:TextBox>
    
    
    <asp:Label ID="Label2" runat="server" Text="pssw"></asp:Label>
<asp:TextBox ID="txtpr" CssClass="form-control" runat="server"></asp:TextBox>

        <asp:Label ID="Label3" runat="server" Text="etat"></asp:Label>
<asp:TextBox ID="txtet" CssClass="form-control" runat="server"></asp:TextBox>
</div>
                    <div style="margin-left:180px; margin-top:10px;">
   <asp:Label ID="msg" runat="server" Text=""></asp:Label>
    <asp:Button ID="btnpers" Class ="btn btn-primary" runat="server" Text="Enregistre" OnClick="btnpers_Click" />

                      </div>  
                    </div>
                </div>
            </section>
        </main>

</asp:Content>

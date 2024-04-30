<%@ Page Title="" Language="C#" MasterPageFile="~/file/cimimanage.Master" AutoEventWireup="true" CodeBehind="utilisateur.aspx.cs" Inherits="CimiManage.file.utilisateur" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
   <main id="main" class="main">
       <section class="section">
            <div class="card container w-75"><%--style="background-color:ButtonShadow"--%>
           <div class="row">
                
                     
            

              <div class="col-lg-6">  
    <asp:Label ID="Label1" class="form-label" runat="server" Text="nom_role"></asp:Label>
                     <asp:DropDownList ID="Dprl" CssClass="form-control" runat="server">
    </asp:DropDownList>
                          
     <asp:Label ID="Label9" class="form-label" runat="server" Text="user_name"></asp:Label>
 <asp:DropDownList ID="Dpprs" CssClass="form-control" runat="server">
 </asp:DropDownList>

     <asp:Label ID="Label10" class="form-label" runat="server" Text="nom_pompe"></asp:Label>
 <asp:DropDownList ID="Dppmp" CssClass="form-control" runat="server">
 </asp:DropDownList>
                   <asp:Label ID="Label2" runat="server" Text="nom_ut"></asp:Label>
 <asp:TextBox ID="txtnu"  CssClass="form-control" runat="server"></asp:TextBox>
                  
   
     <asp:Label ID="Label3" runat="server" Text="prenom_ut"></asp:Label>
 <asp:TextBox ID="txtpu" CssClass="form-control" runat="server"></asp:TextBox>
     </div> 
           
        <div class="col-lg-6">
     <asp:Label ID="Label4" runat="server" Text="telephone"></asp:Label>
 <asp:TextBox ID="txttl" CssClass="form-control" runat="server"></asp:TextBox>

         <asp:Label ID="Label5" runat="server" Text="email"></asp:Label>
 <asp:TextBox ID="txtem" CssClass="form-control" runat="server"></asp:TextBox>
    


     <asp:Label ID="Label6" runat="server" Text="type_client"></asp:Label>
 <asp:TextBox ID="txttypcl" CssClass="form-control" runat="server"></asp:TextBox>
           
     <asp:Label ID="Label7" runat="server" Text="type_personne"></asp:Label>
 <asp:TextBox ID="txttypp" CssClass="form-control" runat="server"></asp:TextBox>

    
     <asp:Label ID="Label8" runat="server" Text="adresse"></asp:Label>
 <asp:TextBox ID="txtadr" CssClass="form-control" runat="server"></asp:TextBox>
</div>
            <div class="" style="margin-left:250px; margin-top:10px;">
      <asp:Label ID="msg" runat="server" Text=""></asp:Label>
    <asp:Button ID="btnutl" Class ="btn btn-primary" runat="server" Text="Enregistre utilisateur" OnClick="btnutl_Click" />
                  
      </div>
               </div>
               </div>
           
           </section>

</main>
</asp:Content>

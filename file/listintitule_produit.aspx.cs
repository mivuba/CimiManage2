using CimiManage.classe;
using CimiManage.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CimiManage.file
{
    public partial class listintitule_produit : System.Web.UI.Page
    {
        intitule_produit_classe np = new intitule_produit_classe();
        IIntitule_produit obj = new Intitule_produitImp();
        int info;
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                getData();
            }
        }
        void getData()
        {
            obj.ChargerList(gdv);
        }

        protected void gdv_RowCommand(object sender, GridViewCommandEventArgs e)
        {

            int index = Convert.ToInt32(e.CommandArgument);//recuperation de l'argument
            if (e.CommandName == "edit")
            {//modification
                Response.Redirect("~/File/intitule_produit.aspx?id_produit=" + index);
            }
            if (e.CommandName == "sup")
            {
                info = obj.Supprimer(index);

                if (info == 1)

                    Response.Redirect("~/File/listintitule_produit.aspx");

            }
        }
    }
}
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
    public partial class listepompe_funeble : System.Web.UI.Page
    {
        pompe_funeble_classe pm = new pompe_funeble_classe();
        Ipompe_funeble obj = new pompe_funebleImp();
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
                Response.Redirect("~/File/pompe_funeble.aspx?id_pompe=" + index);
            }
            if (e.CommandName == "sup")
            {
                info = obj.Supprimer(index);

                if (info == 1)

                    Response.Redirect("~/File/listepompe_funeble.aspx");

            }
        }
    }
}
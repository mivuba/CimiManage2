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
    public partial class listdroit_menu : System.Web.UI.Page
    {
        droit_menu_classe dr = new droit_menu_classe();
        IDroit_menu obj = new Droit_menuImp();
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
                Response.Redirect("~/File/droit_menu.aspx?id_dmenu=" + index);

            }
        }
    }
}
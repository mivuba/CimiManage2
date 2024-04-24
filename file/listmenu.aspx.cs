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
    public partial class listmenu : System.Web.UI.Page
    {
        menu_classe mn = new menu_classe();
        IMenu obj = new MenuImp();
        // int info;
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
                Response.Redirect("~/File/menu.aspx?id_menu=" + index);
            }
        }
    }
}
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
    public partial class listtype_depense : System.Web.UI.Page
    {
        type_depense_classe td = new type_depense_classe();
        IType_depense it = new Type_depenseImp();
        //int info;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                getData();
            }

        }

        void getData()
        {

            it.ChargerList(gdv);

        }

        protected void gdv_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int index = Convert.ToInt32(e.CommandArgument);//recuperation de l'argument
            if (e.CommandName == "edit")
            {//modification
                Response.Redirect("~/File/type_depense.aspx?id_type_dep=" + index);

            }
        }
    }
}
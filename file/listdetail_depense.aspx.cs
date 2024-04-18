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
    public partial class listdetail_depense : System.Web.UI.Page
    {
        detail_depense_classe dp = new detail_depense_classe();
        IDetail_depense obj = new Detail_depenseImp();
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

        protected void gvd_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int index = Convert.ToInt32(e.CommandArgument);//recuperation de l'argument
            if (e.CommandName == "edit")
            {//modification
                Response.Redirect("~/File/detail_depense.aspx?id_det_dep=" + index);

            }

        }
    }
}
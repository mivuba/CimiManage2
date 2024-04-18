using CimiManage.classe;
using CimiManage.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static System.Net.WebRequestMethods;

namespace CimiManage.file
{
    public partial class menu : System.Web.UI.Page
    {
        menu_classe mn = new menu_classe();
        IMenu m = new MenuImp();
        int info;

        string code;

        protected void Page_Load(object sender, EventArgs e)
        {
            code = Request.QueryString["id_menu"];
            if (!IsPostBack)
            {
                if (code != null)
                {
                    btnmn.Text = "Modifier  Depense";
                    afficher();
                }
                else
                {
                    btnmn.Text = "Ajouter Depense";
                }
            }
        }
        void ajouter()
        {
            if (txtnm.Text == "")
            {
                msg.Text = "veuillez saisir le nom de la depense";
            }
            else
            {

                mn.nom_menu = txtnm.Text;
                mn.link = txtlk.Text;
                mn.etat = txtet.Text;
              



                info = m.Ajout(mn);
                if (info == 1)
                {
                    msg.Text = "Enregistrement reussi";
                    txtnm.Text = "";
                    // Response.Redirect("~/File/listepompe_funeble.aspx");

                }
                else

                    msg.Text = "Enregistrement echoue";



            }
        }

        void afficher()
        {

            m.Display(mn, Convert.ToInt32(code));
            txtnm.Text = mn.nom_menu;
            txtlk.Text = mn.link;
            txtet.Text = mn.etat;
        }

        void modifierData()
        {
            if (txtnm.Text == "")
            {
                msg.Text = "veuillez saisir le menu ";
            }
            else
            {
                mn.nom_menu = txtnm.Text;
                mn.link = txtlk.Text;
                mn.etat = txtet.Text;



                info = m.Modify(mn, Convert.ToInt32(code));
                if (info == 1)
                {


                    Response.Redirect("~/File/listmenu.aspx");
                }
                else
                    msg.Text = "Modification echoue";
            }
        }
        protected void btnmn_Click(object sender, EventArgs e)
        {

            if (code == null)
            {

                ajouter();
            }
            else
            {
                modifierData();
            }
        }
    }
}
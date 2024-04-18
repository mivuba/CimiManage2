using CimiManage.classe;
using CimiManage.Controllers;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static System.Net.Mime.MediaTypeNames;

namespace CimiManage.file
{
    public partial class personne : System.Web.UI.Page
    {
        personnes_classe pr = new personnes_classe();
        IPersonnes obj = new PersonnesImp();
        int info;

        string code;
        protected void Page_Load(object sender, EventArgs e)
        {
            code = Request.QueryString["id_pers"];//recuperation de l'id
            if (!IsPostBack)
            {
                if (code != null)
                {
                    btnpers.Text = "Modifier  Personnes";
                    afficher();
                }
                else
                {
                    btnpers.Text = "Ajouter Personnes";
                }
            }
        }

        void ajouter()
        {
            if (txtus.Text == "")
            {
                msg.Text = "veuillez saisir le nom de la pompe_funeble";
            }
            else
            {
           
                pr.user_name = txtus.Text;
                pr.password = txtpr.Text;
                pr.etat = txtet.Text;
               
             

                info = obj.Ajout(pr);
                if (info == 1)
                {
                    msg.Text = "Enregistrement reussi";
                    txtus.Text = "";
                    // Response.Redirect("~/File/listepompe_funeble.aspx");

                }
                else

                    msg.Text = "Enregistrement echoue";



            }
        }

        void afficher() {

            obj.Display(pr, Convert.ToInt32(code));
            txtus.Text = pr.user_name;
            txtpr.Text = pr.password;
            txtet.Text = pr.etat;
           
           
        }
        void modifierData()
        {
            if (txtus.Text == "")
            {
                msg.Text = "veuillez saisir le nom de la Personne";
            }
            else
            {
                pr.user_name = txtus.Text;//affectation
                pr.password = txtpr.Text;
                pr.etat = txtet.Text;
              
         

                info = obj.Modify(pr, Convert.ToInt32(code));
                if (info == 1)
                {


                    Response.Redirect("~/File/listpersonne.aspx");
                }
                else
                    msg.Text = "Modification echoue";
            }
        }
        protected void btnpers_Click(object sender, EventArgs e)
        {


            if (code == null)
            {

                ajouter();
            }
            else {
                modifierData();
            }
        }
    }
}
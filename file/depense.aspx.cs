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
    public partial class depense : System.Web.UI.Page
    {
        depense_classe dp = new depense_classe();
        IDepense ds = new DepenseImp();
        int info;

        string code;
        protected void Page_Load(object sender, EventArgs e)
        {
            code = Request.QueryString["id_dep"];//recuperation de l'id
            if (!IsPostBack)
            {
                if (code != null)
                {
                    btndp.Text = "Modifier  Depense";
                    afficher();
                }
                else
                {
                    btndp.Text = "Ajouter Depense";
                }
            }

        }

        void ajouter()
        {
            if (txttp.Text == "")
            {
                msg.Text = "veuillez saisir le nom de la depense";
            }
            else
            {

                dp.total_depense = txttp.Text;
                dp.mois = txtms.Text;
                dp.annee = txtan.Text;
                dp.statut = txtst.Text;



                info = ds.Ajout(dp);
                if (info == 1)
                {
                    msg.Text = "Enregistrement reussi";
                    txttp.Text = "";
                    // Response.Redirect("~/File/listepompe_funeble.aspx");

                }
                else

                    msg.Text = "Enregistrement echoue";



            }
        }

        void afficher()
        {

            ds.Display(dp, Convert.ToInt32(code));
            txttp.Text = dp.total_depense;
            txtms.Text = dp.mois;
            txtan.Text = dp.annee;
            txtst.Text = dp.statut;


        }
        void modifierData()
        {
            if (txttp.Text == "")
            {
                msg.Text = "veuillez saisir le nom de la Personne";
            }
            else
            {
                dp.total_depense = txttp.Text;
                dp.mois = txtms.Text;
                dp.annee = txtan.Text;
                dp.statut = txtst.Text;



                info = ds.Modify(dp, Convert.ToInt32(code));
                if (info == 1)
                {


                    Response.Redirect("~/File/listdepense.aspx");
                }
                else
                    msg.Text = "Modification echoue";
            }
        }

        protected void btndp_Click(object sender, EventArgs e)
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
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
    public partial class intitule_produit : System.Web.UI.Page
    {
      intitule_produit_classe nt = new intitule_produit_classe();
        IIntitule_produit obj = new Intitule_produitImp();
        int info;

        string code;

        protected void Page_Load(object sender, EventArgs e)
        {

            code = Request.QueryString["id_produit"];//recuperation de l'id
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
            if (txtnp.Text == "")
            {
                msg.Text = "veuillez saisir le nom de la depense";
            }
            else
            {

                nt.nom_produit = txtnp.Text;
               



                info = obj.Ajout(nt);
                if (info == 1)
                {
                    msg.Text = "Enregistrement reussi";
                    txtnp.Text = "";
                    // Response.Redirect("~/File/listepompe_funeble.aspx");

                }
                else

                    msg.Text = "Enregistrement echoue";



            }
        }

        void afficher()
        {

            obj.Display(nt, Convert.ToInt32(code));
            txtnp.Text = nt.nom_produit;
        }

        void modifierData()
        {
            if (txtnp.Text == "")
            {
                msg.Text = "veuillez saisir le menu ";
            }
            else
            {
                nt.nom_produit = txtnp.Text;




                info = obj.Modify(nt, Convert.ToInt32(code));
                if (info == 1)
                {


                    Response.Redirect("~/File/listintitule_produit.aspx");
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
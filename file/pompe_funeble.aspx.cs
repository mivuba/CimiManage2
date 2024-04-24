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
    public partial class pompe_funeble : System.Web.UI.Page
    {
        pompe_funeble_classe pmp = new pompe_funeble_classe();
        Ipompe_funeble obj = new pompe_funebleImp();

        int info;

        string code;
        protected void Page_Load(object sender, EventArgs e)
        {
           //recuperation de l'id

            code = Request.QueryString["id_pompe"];
            if (!IsPostBack)
            {
                if (code != null)
                {
                    btnpmp.Text = "Modifier  pompe";
                    afficher();
                }
                else
                {
                    btnpmp.Text = "Ajouter pompe";
                }
            }
        }

        void ajout()
        {

            if (Dppompe.SelectedValue == "")
            {
                msg.Text = "veuillez saisir le nom de la pompe_funeble";
            }
            else
            {
                //affectation pmp.nom_pompe = textnomp.Text;
                pmp.nom_pompe = Dppompe.SelectedValue;//affectation
                pmp.email = textml.Text;
                pmp.NIF = textnf.Text;
                pmp.code = textcd.Text;
                pmp.statut = textstat.Text;
                pmp.etat = textet.Text;
                pmp.logos = obj.UploadPhoto(FileUpload1);
                pmp.telephone = Convert.ToInt32(texttelp.Text);
                pmp.RC = textrc.Text;
                pmp.sigle = textsgl.Text;
                pmp.date_creation = textdatcr.Text;
                pmp.facebook = textfb.Text;
                pmp.whatshapp = textwspp.Text;
                pmp.adresse = textadrs.Text;

                info = obj.Ajout(pmp);
                if (info == 1)
                {
                    msg.Text = "Enregistrement reussi";
                    // textnomp.Text = "";
                    // Response.Redirect("~/File/listepompe_funeble.aspx");

                }
                else

                    msg.Text = "Enregistrement echoue";



            }

        }

        void afficher()
        {
            obj.Display(pmp, Convert.ToInt32(code));
            // textnomp.Text = pmp.nom_pompe;
            Dppompe.SelectedValue = pmp.nom_pompe;
            textml.Text = pmp.email;
            textnf.Text = pmp.NIF;
            textcd.Text = pmp.code;
            textstat.Text = pmp.statut;
            textet.Text = pmp.etat;
            // FileUpload1.Text = pmp.logos;
            textrc.Text = pmp.RC;
            textsgl.Text = pmp.sigle;
            textdatcr.Text = pmp.date_creation;
            texttelp.Text = pmp.telephone.ToString();
            textfb.Text = pmp.facebook;
            textwspp.Text = pmp.whatshapp;
            textadrs.Text = pmp.adresse;
        }
        void modifierData()
        {

            if (Dppompe.SelectedValue == "")
            {
                msg.Text = "veuillez saisir le nom de la pompe_funeble";
            }
            else
            {
                // pmp.nom_pompe = textnomp.Text;//affectation
                pmp.nom_pompe = Dppompe.SelectedValue;
                pmp.email = textml.Text;
                pmp.NIF = textnf.Text;
                pmp.code = textcd.Text;
                pmp.statut = textstat.Text;
                pmp.etat = textet.Text;
                // pmp.logos = textlog.Text;
                pmp.telephone = Convert.ToInt32(texttelp.Text);
                pmp.RC = textrc.Text;
                pmp.sigle = textsgl.Text;
                pmp.date_creation = textdatcr.Text;
                pmp.facebook = textfb.Text;
                pmp.whatshapp = textwspp.Text;
                pmp.adresse = textadrs.Text;

                info = obj.Modify(pmp, Convert.ToInt32(code));
                if (info == 1)
                {


                    Response.Redirect("~/File/listpompe_funeble.aspx");
                }
                else
                    msg.Text = "Modification echoue";
            }
        }
        protected void btnpmp_Click(object sender, EventArgs e)
        {
            if (code == null)
            {

                ajout();
            }
            else
            {
                modifierData();
            }

        }
    }
}
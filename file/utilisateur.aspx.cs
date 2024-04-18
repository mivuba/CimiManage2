using CimiManage.classe;
using CimiManage.Controllers;
using CimiManage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CimiManage.file
{
    public partial class utilisateur : System.Web.UI.Page
    {
        utilisateur_classe ul = new utilisateur_classe();
        IUtilisateur ut = new UtilisateurImp();
        IPersonnes ps = new PersonnesImp();
        Irole rl = new RoleImp();
        Ipompe_funeble pmp = new pompe_funebleImp();

        int messg;
        string code;
        protected void Page_Load(object sender, EventArgs e)
        {
            code = Request.QueryString["id_ut"];
            if (!IsPostBack)
            {

                Data();
                if (code != null)
                {
                    btnutl.Text = "Modifier l utlisateur";
                    affichager();

                }


            }

        }

        void Data()
        {
            ps.ChargerPers(Dpprs);
            rl.Chargerrole(Dprl);
            pmp.ChargerPomp(Dppmp);
           
        }
        void ajout()
        {
            if (Dpprs.SelectedValue == "-1" || Dprl.SelectedValue == "-1" || Dppmp.SelectedValue == "-1" || txtnu.Text == "")
            {
                msg.Text = "Remplissez tous les chants";
            }
            else
            {
                

                ul.id_pers = Convert.ToInt32(Dpprs.SelectedValue);
                ul.id_role = Convert.ToInt32(Dprl.SelectedValue);
                ul.id_pompe = Convert.ToInt32(Dppmp.SelectedValue);
                ul.nom_ut = txtnu.Text;
                ul.prenom_ut = txtpu.Text;
                ul.telephone = txttl.Text;
                ul.email = txtem.Text;
                ul.type_client = txttypcl.Text;
                ul.type_personne = txttypp.Text;
                ul.adresse = txtadr.Text;

                messg = ut.Ajout(ul);

                if (messg > 0)
                {
                    msg.Text = "Enregistrement reussi";
                    txtnu.Text = "";

                    // Response.Redirect("~/File/listeCommune.aspx");
                }
                else
                {
                    msg.Text = "Enregistrement echoué";
                }

            }
        }
        void affichager()
        {

            ut.Display(ul, Convert.ToInt32(code));
            Dpprs.SelectedValue = ul.id_pers.ToString();
            Dprl.SelectedValue = ul.id_role.ToString();
            Dppmp.SelectedValue = ul.id_pompe.ToString();

            txtnu.Text = ul.nom_ut;
            txtpu.Text = ul.prenom_ut;
            txttl.Text = ul.telephone;
            txtem.Text = ul.email;
            txttypcl.Text = ul.type_client;
            txttypp.Text = ul.type_personne;
            txtadr.Text = ul.adresse;

        }

        void Modifier()
        {

            if (code != null)
            {
                if (Dpprs.SelectedValue == "-1" || Dprl.SelectedValue == "-1" || Dppmp.SelectedValue == "-1" || txtnu.Text == "")
                {
                    msg.Text = "Remplissez tous les chants";
                }
                else
                {
                   
                    ul.id_pers = Convert.ToInt32(Dpprs.SelectedValue);
                    ul.id_role = Convert.ToInt32(Dprl.SelectedValue);
                    ul.id_pompe = Convert.ToInt32(Dppmp.SelectedValue);

                    ul.nom_ut = txtnu.Text;
                    ul.prenom_ut = txtpu.Text;
                    ul.telephone = txttl.Text;
                    ul.email = txtem.Text;
                    ul.type_client = txttypcl.Text;
                    ul.type_personne = txttypp.Text;
                    ul.adresse = txtadr.Text;



                    messg = ut.Modify(ul, Convert.ToInt32(code));
                    if (messg > 0)
                    {
                        Response.Redirect("~/File/listutilisateur.aspx");
                    }
                    else
                    {
                        btnutl.Text = "Ajouter l utilisateur";
                    }
                }
            }
        }

        protected void btnutl_Click(object sender, EventArgs e)
        {
            if (code == null)

                ajout();
            else
            {
                Modifier();
            }

        }
    }
}
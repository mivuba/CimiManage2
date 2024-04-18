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
    public partial class commande : System.Web.UI.Page
    {
        commande_classe cm = new commande_classe();
        ICommande obj = new CommandeImp();
        IUtilisateur ut = new UtilisateurImp();
        IService sv = new ServiceImp();

        int messg;
        string code;
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {

                Data();
               


            }
        }
        void Data()
        {
            ut.Chargerutil(Dput);
            sv.Chargersev(Dpsv);
            

        }
        void ajout()
        {
            if (Dput.SelectedValue == "-1" || Dpsv.SelectedValue == "-1" || txtcd.Text == "")
            {
                msg.Text = "Remplissez tous les chants";
            }
            else
            {


                cm.id_ut = Convert.ToInt32(Dput.SelectedValue);
                cm.id_service = Convert.ToInt32(Dpsv.SelectedValue);
                cm.code_com = txtcd.Text;
                cm.type_com = txttyp.Text;
                cm.reduction = txtrd.Text;
                cm.date_com = txtdt.Text;
                cm.statut = txtst.Text;
                cm.etat = txtet.Text;
                cm.prix_total = txtpt.Text;
                cm.annee = txtann.Text;
                cm.mois = txtm.Text;
                cm.prix_TVA = txtptv.Text;
                cm.type_com_location = txttpc.Text;
                cm.type_com_achat = txttp.Text;

                messg = obj.Ajout(cm);

                if (messg > 0)
                {
                    msg.Text = "Enregistrement reussi";
                    txtcd.Text = "";

                    // Response.Redirect("~/File/listeCommune.aspx");
                }
                else
                {
                    msg.Text = "Enregistrement echoué";
                }

            }
        }

        protected void btncomm_Click(object sender, EventArgs e)
        {

            if (code == null)

                ajout();
        }
    }
}
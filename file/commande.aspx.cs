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
            code = Request.QueryString["id_com"];
            if (!IsPostBack)
            {

                Data();

                if (code != null)
                {
                    btncomm.Text = "Modifier l utlisateur";
                    affichager();

                }


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

        void affichager()
        {

            obj.Display(cm, Convert.ToInt32(code));
            Dput.SelectedValue = cm.id_ut.ToString();
            Dpsv.SelectedValue = cm.id_service.ToString();


            txtcd.Text = cm.code_com;
            txttyp.Text = cm.type_com;
            txtrd.Text = cm.reduction;
            txtdt.Text = cm.date_com;
            txtst.Text = cm.statut;
            txtet.Text = cm.etat;
            txtpt.Text = cm.prix_total;
            txtann.Text = cm.annee;
            txtm.Text = cm.mois;
            txtptv.Text = cm.prix_TVA;
            txttpc.Text = cm.type_com_location;
            txttp.Text = cm.type_com_achat;
         

        }

        void Modifier()
        {

            if (code != null)
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



                    messg = obj.Modify(cm, Convert.ToInt32(code));
                    if (messg > 0)
                    {
                        Response.Redirect("~/File/listcommande.aspx");
                    }
                    else
                    {
                        btncomm.Text = "Ajouter l commande";
                    }
                }
            }
        }

        protected void btncomm_Click(object sender, EventArgs e)
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
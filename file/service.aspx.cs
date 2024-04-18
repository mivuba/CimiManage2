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
    public partial class service : System.Web.UI.Page
    {
        service_classe sv = new service_classe();
        IService obj = new ServiceImp();
        Ipompe_funeble pmp = new pompe_funebleImp();
        IIntitule_produit np = new Intitule_produitImp();

        int messg;
        string code;
        protected void Page_Load(object sender, EventArgs e)
        {
            code = Request.QueryString["id_service"];
            if (!IsPostBack)
            {

                Data();
                if (code != null)
                {
                    btnsv.Text = "Modifier la service";
                    affichager();

                }


            }

        }

        void Data()
        {
            
            pmp.ChargerPomp(Dpnmp);
            np.Chargerintp(Dpnp);

        }
        void ajout()
        {
            if (Dpnmp.SelectedValue == "-1" || Dpnp.SelectedValue == "-1" || txtnv.Text == "")
            {
                msg.Text = "Remplissez tous les chants";
            }
            else
            {


                sv.id_pompe = Convert.ToInt32(Dpnmp.SelectedValue);
                sv.id_produit = Convert.ToInt32(Dpnp.SelectedValue);
                sv.nom_service = txtnv.Text;
                sv.prix_service = txtps.Text;
                sv.longitude = txtlg.Text;
                sv.altitude = txtalt.Text;
               

                messg = obj.Ajout(sv);

                if (messg > 0)
                {
                    msg.Text = "Enregistrement reussi";
                    txtnv.Text = "";

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

            obj.Display(sv, Convert.ToInt32(code));

            Dpnmp.SelectedValue = sv.id_pompe.ToString();
            Dpnp.SelectedValue = sv.id_produit.ToString();

            txtnv.Text = sv.nom_service;
            txtps.Text = sv.prix_service;
            txtlg.Text = sv.longitude;
            txtalt.Text = sv.altitude;
           

        }
        void Modifier()
        {

            if (code != null)
            {
                if (Dpnmp.SelectedValue == "-1" || Dpnp.SelectedValue == "-1" || txtnv.Text == "")
                {
                    msg.Text = "Remplissez tous les chants";
                }
                else
                {

                    sv.id_pompe = Convert.ToInt32(Dpnmp.SelectedValue);
                    sv.id_produit = Convert.ToInt32(Dpnp.SelectedValue);
                    sv.nom_service = txtnv.Text;
                    sv.prix_service = txtps.Text;
                    sv.longitude = txtlg.Text;
                    sv.altitude = txtalt.Text;


                    messg = obj.Modify(sv, Convert.ToInt32(code));
                    if (messg > 0)
                    {
                        Response.Redirect("~/File/listService.aspx");
                    }
                    else
                    {
                        btnsv.Text = "Ajouter la Service";
                    }
                }
            }
        }

        protected void btnsv_Click(object sender, EventArgs e)
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
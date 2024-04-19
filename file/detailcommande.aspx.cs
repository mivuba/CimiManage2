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
    public partial class detailcommande : System.Web.UI.Page
    {
        detail_com_classe dcom = new detail_com_classe();
        IDetail_com dc = new Detail_comImp();
        IService sv = new ServiceImp();
        ICommande com = new CommandeImp();

        int messg;
        string code;
        protected void Page_Load(object sender, EventArgs e)
        {
            code = Request.QueryString["id_detail_com"];
            if (!IsPostBack)
            {

                Data();
                if (code != null)
                {
                    btndt.Text = "Modifier l detailcommande";
                    affichager();

                }


            }

        }
        void Data()
        {

            sv.Chargersev(Dpsc);
            com.Chargercom(Dpcm);

        }

        void ajout()
        {
            if (Dpsc.SelectedValue == "-1" || Dpcm.SelectedValue == "-1" || txtpu.Text == "")
            {
                msg.Text = "Remplissez tous les chants";
            }
            else
            {


              
                dcom.id_service = Convert.ToInt32(Dpsc.SelectedValue);
                dcom.id_com = Convert.ToInt32(Dpcm.SelectedValue);
                dcom.PU = txtpu.Text;
                dcom.nom_feu = txtnf.Text;
                dcom.date_nass = txtdn.Text;
                dcom.date_dece = txtdd.Text;
                dcom.quantite_d_com = txtqc.Text;
               

                messg = dc.Ajout(dcom);

                if (messg > 0)
                {
                    msg.Text = "Enregistrement reussi";
                    txtpu.Text = "";

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

            dc.Display(dcom, Convert.ToInt32(code));

            Dpsc.SelectedValue = dcom.id_service.ToString();
            Dpcm.SelectedValue = dcom.id_com.ToString();

            txtpu.Text = dcom.PU;
            txtnf.Text = dcom.nom_feu;
            txtdn.Text = dcom.date_nass;
            txtdd.Text = dcom.date_dece;
            txtqc.Text = dcom.quantite_d_com;
           

        }
        void Modifier()
        {

            if (code != null)
            {
                if (Dpsc.SelectedValue == "-1" || Dpcm.SelectedValue == "-1" || txtpu.Text == "")
                {
                    msg.Text = "Remplissez tous les chants";
                }
                else
                {


                    dcom.id_service = Convert.ToInt32(Dpsc.SelectedValue);
                    dcom.id_com = Convert.ToInt32(Dpcm.SelectedValue);
                    dcom.PU = txtpu.Text;
                    dcom.nom_feu = txtnf.Text;
                    dcom.date_nass = txtdn.Text;
                    dcom.date_dece = txtdd.Text;
                    dcom.quantite_d_com = txtqc.Text;



                    messg = dc.Modify(dcom, Convert.ToInt32(code));
                    if (messg > 0)
                    {
                        Response.Redirect("~/File/listdetail_commande.aspx");
                    }
                    else
                    {
                        btndt.Text = "Ajouter l detailcommande";
                    }
                }
            }
        }

        protected void btndt_Click(object sender, EventArgs e)
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
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
    public partial class detail_depense : System.Web.UI.Page
    {
        detail_depense_classe dp = new detail_depense_classe();
        IDetail_depense obj = new Detail_depenseImp();
        IType_depense tpd = new Type_depenseImp();
        IDepense d = new DepenseImp();

        int messg;
        string code;
        protected void Page_Load(object sender, EventArgs e)
        {
            code = Request.QueryString["id_det_dep"];
            if (!IsPostBack)
            {

                Data();
                if (code != null)
                {
                    btndp.Text = "Modifier l detail_depense";
                    affichager();

                }


            }
        }

        void Data()
        {
            tpd.Chargertyd(Dptyp);
            d.Chargerdep(Dpdp);
       

        }
        void ajout()
        {
            if (Dptyp.SelectedValue == "-1" || Dpdp.SelectedValue == "-1" || txtqd.Text == "")
            {
                msg.Text = "Remplissez tous les chants";
            }
            else
            {



                dp.id_type_dep = Convert.ToInt32(Dptyp.SelectedValue);
                dp.id_dep = Convert.ToInt32(Dpdp.SelectedValue);
                dp.quantite_depense = txtqd.Text;
                dp.prix_unite = txtpu.Text;
                dp.nom_pers = txtnp.Text;
               
               

                messg = obj.Ajout(dp);

                if (messg > 0)
                {
                    msg.Text = "Enregistrement reussi";
                    txtqd.Text = "";

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

            obj.Display(dp, Convert.ToInt32(code));

            Dptyp.SelectedValue = dp.id_type_dep.ToString();
            Dpdp.SelectedValue = dp.id_dep.ToString();


            txtqd.Text = dp.quantite_depense;
            txtpu.Text = dp.prix_unite;
            txtnp.Text = dp.nom_pers;
           

        }

        void Modifier()
        {

            if (code != null)
            {
                if (Dptyp.SelectedValue == "-1" || Dpdp.SelectedValue == "-1" || txtqd.Text == "")
                {
                    msg.Text = "Remplissez tous les chants";
                }
                else
                {

                    dp.id_type_dep = Convert.ToInt32(Dptyp.SelectedValue);
                    dp.id_dep = Convert.ToInt32(Dpdp.SelectedValue);

                    
                    dp.quantite_depense = txtqd.Text;
                    dp.prix_unite = txtpu.Text;
                    dp.nom_pers = txtnp.Text;
                   



                    messg = obj.Modify(dp, Convert.ToInt32(code));
                    if (messg > 0)
                    {
                        Response.Redirect("~/File/listdetail_depense.aspx");
                    }
                    else
                    {
                        btndp.Text = "Ajouter l detail_depense";
                    }
                }
            }
        }
        protected void btndp_Click(object sender, EventArgs e)
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
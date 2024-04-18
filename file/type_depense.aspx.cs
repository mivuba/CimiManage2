using CimiManage.classe;
using CimiManage.Controllers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CimiManage.file
{
    public partial class type_depense : System.Web.UI.Page
    {

        type_depense_classe ty = new type_depense_classe();
        IType_depense it = new Type_depenseImp();

        Ipompe_funeble p = new pompe_funebleImp();

        int messg;
        string code;
        protected void Page_Load(object sender, EventArgs e)
        {
            code = Request.QueryString["id_type_dep"];
            if (!IsPostBack)
            {

                Data();
                if (code != null)
                {
                    btntp.Text = "Modifier le type_depense ";
                    affichager();

                }

            }
        }
        void Data()
        {
            p.ChargerPomp(Dppompe);
        }

        void ajout()
        {
            if (Dppompe.SelectedValue == "-1" || txtyp.Text == "")
            {
                msg.Text = "Remplissez tous les chants";
            }
            else
            {
                ty.id_pompe = Convert.ToInt32(Dppompe.SelectedValue);
                ty.type_depens = txtyp.Text;
                messg = it.Ajout(ty);

                if (messg > 0)
                {
                    msg.Text = "Enregistrement reussi";
                    txtyp.Text = "";

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

            it.Display(ty, Convert.ToInt32(code));
            Dppompe.SelectedValue = ty.id_pompe.ToString();

            txtyp.Text = ty.type_depens;

        }

        void Modifier()
        {

            if (code != null)
            {
                if (Dppompe.SelectedValue == "-1" || txtyp.Text == "")
                {
                    msg.Text = "Remplissez tous les chants";
                }
                else
                {
                    ty.id_pompe = Convert.ToInt32(Dppompe.SelectedValue);
                    ty.type_depens = txtyp.Text;



                    messg = it.Modify(ty, Convert.ToInt32(code));
                    if (messg > 0)
                    {
                        Response.Redirect("~/File/listtype_depense.aspx");
                    }
                    else
                    {
                        btntp.Text = "Ajouter la type_depense";
                    }
                }
            }
        }

        protected void btntp_Click(object sender, EventArgs e)
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
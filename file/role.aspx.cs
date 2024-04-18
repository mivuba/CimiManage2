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
    public partial class role : System.Web.UI.Page
    {
       role_classe rl = new role_classe();

        Irole r = new RoleImp();
       

        Ipompe_funeble p = new pompe_funebleImp();

        int messg;
        string code;
        protected void Page_Load(object sender, EventArgs e)
        {

            code = Request.QueryString["id_role"];

            if (!IsPostBack)
            {

                Data();

                if (code != null)
                {
                    btnrole.Text = "Modifier le role";
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
            if (Dppompe.SelectedValue == "-1" || txtrl.Text == "")
            {
                msg.Text = "Remplissez tous les chants";
            }
            else
            {
                rl.id_pompe = Convert.ToInt32(Dppompe.SelectedValue);
                rl.nom_role = txtrl.Text;
                messg = r.Ajout(rl);

                if (messg > 0)
                {
                    msg.Text = "Enregistrement reussi";
                    txtrl.Text = "";

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

            r.Display(rl, Convert.ToInt32(code));
            Dppompe.SelectedValue = rl.id_pompe.ToString();

            txtrl.Text = rl.nom_role;

        }
        void Modifier()
        {

            if (code != null)
            {
                if (Dppompe.SelectedValue == "-1" || txtrl.Text == "" )
                {
                    msg.Text = "Remplissez tous les chants";
                }
                else
                {
                    rl.id_pompe = Convert.ToInt32(Dppompe.SelectedValue);
                    rl.nom_role = txtrl.Text;



                    messg = r.Modify(rl, Convert.ToInt32(code));
                    if (messg > 0)
                    {
                        Response.Redirect("~/File/listrole.aspx");
                    }
                    else
                    {
                        btnrole.Text = "Ajouter la role";
                    }
                }
            }
        }
        protected void btnrole_Click(object sender, EventArgs e)
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
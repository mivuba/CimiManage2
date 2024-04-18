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
    public partial class droit_menu : System.Web.UI.Page
    {
        droit_menu_classe dm = new droit_menu_classe();
        IDroit_menu obj = new Droit_menuImp();
        Irole rl = new RoleImp();
        IMenu m = new MenuImp();
        int messg;
        string code;
        protected void Page_Load(object sender, EventArgs e)
        {
            code = Request.QueryString["id_dmenu"];
            if (!IsPostBack)
            {

                Data();
                if (code != null)
                {
                    btndm.Text = "Modifier l drm";
                    affichager();

                }



            }
        }

        void Data()
        {
            
            rl.Chargerrole(Dpnr);
            m.Chargermn(Dpnm);

        }
        void ajout()
        {
            if (Dpnr.SelectedValue == "-1" || Dpnm.SelectedValue == "-1" || txtg.Text == "")
            {
                msg.Text = "Remplissez tous les chants";
            }
            else
            {



                dm.id_role = Convert.ToInt32(Dpnr.SelectedValue);
                dm.id_menu = Convert.ToInt32(Dpnm.SelectedValue);
                dm.gerer = txtg.Text;
                dm.ajouter = txtaj.Text;
                dm.acces = txtac.Text;
                
               

                messg = obj.Ajout(dm);

                if (messg > 0)
                {
                    msg.Text = "Enregistrement reussi";
                    txtg.Text = "";

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

            obj.Display(dm, Convert.ToInt32(code));

            Dpnr.SelectedValue = dm.id_role.ToString();
            Dpnm.SelectedValue = dm.id_menu.ToString();

            txtg.Text = dm.gerer;
            txtaj.Text = dm.ajouter;
            txtac.Text = dm.acces;
            

        }
        void Modifier()
        {

            if (code != null)
            {
                if (Dpnr.SelectedValue == "-1" || Dpnm.SelectedValue == "-1" || txtg.Text == "")
                {
                    msg.Text = "Remplissez tous les chants";
                }
                else
                {

                 

                    dm.id_role = Convert.ToInt32(Dpnr.SelectedValue);
                    dm.id_menu = Convert.ToInt32(Dpnm.SelectedValue);
                    dm.gerer = txtg.Text;
                    dm.ajouter = txtaj.Text;
                    dm.acces = txtac.Text;


                    messg = obj.Modify(dm, Convert.ToInt32(code));
                    if (messg > 0)
                    {
                        Response.Redirect("~/File/listdroit_menu.aspx");
                    }
                    else
                    {
                        btndm.Text = "Ajouter l droit_menu";
                    }
                }
            }
        }

        protected void btndm_Click(object sender, EventArgs e)
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
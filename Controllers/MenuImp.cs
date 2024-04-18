using CimiManage.classe;
using CimiManage.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace CimiManage.Controllers
{
    public class MenuImp : IMenu
    {
        menu m = new menu();
        int r;

        public int Ajout(menu_classe mn)
        {

            using (connection con = new connection())//etablir la connexion
            {
                m.nom_menu = mn.nom_menu;
                m.link = mn.link;
                m.etat = mn.etat;


                con.menu.Add(m);

                if (con.SaveChanges() == 1)
                {
                    con.menu.Add(m);
                    r = 1;
                }
                else
                    r = 0;
                return r;
            }
        }

        public void ChargerList(GridView gdv)
        {
            using (connection con = new connection())//etablir la connexion
            {
                var obj = (from o in con.menu
                           select new
                           {
                               id_menu = o.id_menu,
                               nom_menu = o.nom_menu,
                               link = o.link,
                               etat = o.etat,
                              
                           }).ToList();
                gdv.DataSource = obj;
                gdv.DataBind();

            }
        }

        public void Chargermn(DropDownList dp)
        {
            dp.Items.Clear();
            using (connection con = new connection())
            {

                var obj = (from p in con.menu select p).ToList();
                if (obj != null && obj.Count() > 0)
                {
                    dp.Items.Clear();

                    ListItem item0 = new ListItem();
                    item0.Value = "-1";
                    item0.Text = "Selectionne la personnes";
                    dp.Items.Add(item0);
                    foreach (var data in obj)
                    {
                        ListItem item = new ListItem();
                        item.Value = data.id_menu.ToString();
                        item.Text = data.nom_menu;
                        dp.Items.Add(item);
                    }
                }
                else
                {
                    ListItem item1 = new ListItem();
                    item1.Value = "-1";
                    item1.Text = "Aucune donnee";
                    dp.Items.Add(item1);
                }
            }
        }

        public void Display(menu_classe mu, int id)
        {
            using (connection con = new connection())
            {
                m = con.menu.Where(x => x.id_menu == id).FirstOrDefault();
                mu.nom_menu = m.nom_menu;
                mu.link = m.link;
                mu.etat = m.etat;
               

            }
        }

        public int Modify(menu_classe mu, int id)
        {
            using (connection con = new connection())
            {
                m = con.menu.Where(x => x.id_menu == id).FirstOrDefault();
                m.nom_menu = mu.nom_menu;
                m.link = mu.link;
                m.etat = mu.etat;


                if (con.SaveChanges() == 1)
                {
                    con.menu.Add(m);
                    con.Entry(m).State = EntityState.Modified;
                    r = 1;
                }
                else r = 0;

            }
            return r;
        }
    
    }
}
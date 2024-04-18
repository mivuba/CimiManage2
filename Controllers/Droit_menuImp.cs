using CimiManage.classe;
using CimiManage.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using static System.Net.WebRequestMethods;

namespace CimiManage.Controllers
{
    public class Droit_menuImp : IDroit_menu
    {
        droit_menu d = new droit_menu();
        int b;
        public int Ajout(droit_menu_classe dm)
        {
            using (connection con = new connection())
            {
                d.id_role = dm.id_role;
                d.id_menu = dm.id_menu;
                d.gerer = dm.gerer;
                d.ajouter = dm.ajouter;
                d.acces = dm.acces;

                con.droit_menu.Add(d);
                if (con.SaveChanges() == 1)
                {
                    con.droit_menu.Add(d);
                    b = 1;
                }
                else
                    b = 0;
                return b;
            }
        }

        public void ChargerList(GridView gdv)
        {
            using (connection con = new connection())
            {
                var obj = (from a in con.droit_menu
                           join m in con.menu on a.id_menu equals m.id_menu
                           join r in con.role on a.id_role equals r.id_role

                           select new
                           {
                               id_dmenu = a.id_dmenu,
                               id_role = a.id_role,
                               id_menu = a.id_menu,
                               gerer = a.gerer,
                               ajouter = a.ajouter,
                               acces = a.acces,


                               nom_menu = m.nom_menu,
                               nom_role = r.nom_role,

                           }).ToList();

                gdv.DataSource = obj;
                gdv.DataBind();
            }
        }

        public void Display(droit_menu_classe dmn, int id)
        {
            using (connection con = new connection())
            {
                d = con.droit_menu.Where(x => x.id_dmenu == id).FirstOrDefault();

                dmn.id_role = d.id_role;
                dmn.id_menu = d.id_menu;
                dmn.gerer = d.gerer;
                dmn.ajouter = d.ajouter;
                dmn.acces = d.acces;


            }
        }

        public int Modify(droit_menu_classe dmnu, int id)
        {
            using (connection con = new connection())
            {
                d = con.droit_menu.Where(x => x.id_dmenu == id).FirstOrDefault();

                d.id_role = dmnu.id_role;
                d.id_menu = dmnu.id_menu;
                d.gerer = dmnu.gerer;
                d.ajouter = dmnu.ajouter;
                d.acces = dmnu.acces;

                if (con.SaveChanges() == 1)
                {
                    con.droit_menu.Add(d);
                    con.Entry(d).State = EntityState.Modified;
                    b = 1;
                }
                else b = 0;
            }
            return b;

        
        }

        public int Supprimer(int id)
        {
            using (connection con = new connection())
            {
                d = con.droit_menu.Where(x => x.id_dmenu == id).First();
                if (con.Entry(d).State == EntityState.Detached)
                    con.droit_menu.Attach(d);
                con.droit_menu.Remove(d);
                con.SaveChanges();
                return b = 1;

            }
        }
    }
}
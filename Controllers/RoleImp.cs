using CimiManage.classe;
using CimiManage.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Web;
using System.Web.UI.WebControls;

namespace CimiManage.Controllers
{
    public class RoleImp : Irole
    {
        role r = new role();
        int b;
        private int id;
        public int Ajout(role_classe rl)
        {
            using (connection con = new connection())
            {
                r.id_pompe = rl.id_pompe;
                r.nom_role = rl.nom_role;
                con.role.Add(r);
                if (con.SaveChanges() == 1)
                {
                    con.role.Add(r);
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
                var obj = (from a in con.role
                           join o in con.pompe_funeble on a.id_pompe equals o.id_pompe
                           select new
                           {
                               idrole = a.id_role,
                               id_pompe = a.id_pompe,
                               role = a.nom_role,
                               nom_pomp = o.nom_pompe,
                           }
                            ).ToList();

                gdv.DataSource = obj;
                gdv.DataBind();
            }
        }

        public void Chargerrole(DropDownList dp)
        {
            dp.Items.Clear();
            using (connection con = new connection())
            {

                var obj = (from p in con.role select p).ToList();
                if (obj != null && obj.Count() > 0)
                {
                    dp.Items.Clear();

                    ListItem item0 = new ListItem();
                    item0.Value = "-1";
                    item0.Text = "Selectionne le role";
                    dp.Items.Add(item0);
                    foreach (var data in obj)
                    {
                        ListItem item = new ListItem();
                        item.Value = data.id_role.ToString();
                        item.Text = data.nom_role;
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

        public void Display(role_classe rl, int id)
        {
            using (connection con = new connection())
            {
                r = con.role.Where(x => x.id_role == id).FirstOrDefault();
                //cm.com = h.com;
                if (r != null)
                {
                    rl.id_role = r.id_role;
                    rl.id_pompe = r.id_pompe;
                    rl.nom_role = r.nom_role;
                }
            }
        }

        public int Modify(role_classe rol, int id)
        {
            using (connection con = new connection())
            {
                r = con.role.Where(x => x.id_role == id).FirstOrDefault();
                // h.com = pr.com;
                r.nom_role = rol.nom_role;
                r.id_pompe = rol.id_pompe;
                if (con.SaveChanges() == 1)
                {
                    con.role.Add(r);
                    con.Entry(r).State = EntityState.Modified;
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
                r = con.role.Where(x => x.id_role == id).First();
                if (con.Entry(r).State == EntityState.Detached)
                    con.role.Attach(r);
                con.role.Remove(r);
                con.SaveChanges();
                return b = 1;


            }
        }
    }
}
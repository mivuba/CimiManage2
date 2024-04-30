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
    public class PersonnesImp : IPersonnes
    {
        personnes p = new personnes();
        int r;
        public int Ajout(personnes_classe pr)
        {
            using (connection con = new connection())//etablir la connexion
            {
                p.user_name = pr.user_name;
                p.password = pr.password;
                p.etat = pr.etat;
                con.personnes.Add(p);

                if (con.SaveChanges() == 1)
                {
                    con.personnes.Add(p);
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
                var obj = (from o in con.personnes
                           select new
                           {
                               id_pers = o.id_pers,
                               user_name = o.user_name,
                               password = o.password,
                               etat = o.etat,
                           }).ToList();
                gdv.DataSource = obj;
                gdv.DataBind();

            }
        }

        public void ChargerPers(DropDownList dp)
        {
            dp.Items.Clear();
            using (connection con = new connection())
            {

                var obj = (from p in con.personnes select p).ToList();
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
                        item.Value = data.id_pers.ToString();
                        item.Text = data.user_name;
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

        public int Connect(personnes_classe log, string usersnm, string pswd)
        {
            using (connection con = new connection())
            {
                p = con.personnes.Where(x => x.user_name == usersnm && x.password == pswd && x.etat == "1").FirstOrDefault();

                if (p != null)
                {
                    log.id_pers = p.id_pers;
              
                    log.user_name = p.user_name;
                    log.password = p.password;
                    log.etat = p.etat;
          
                    
                    return r = 1;
                }
                else return r = 0;

            }
        }

        public void Display(personnes_classe prs, int id)
        {
            using (connection con = new connection())
            {
                p = con.personnes.Where(x => x.id_pers == id).FirstOrDefault();
                prs.user_name = p.user_name;
                prs.password = p.password;
                prs.etat = p.etat;
                
            }
        }

        public int Modify(personnes_classe ps, int id)
        {
            using (connection con = new connection())
            {
                p = con.personnes.Where(x => x.id_pers == id).FirstOrDefault();
                p.user_name = ps.user_name;
                p.password = ps.password;
                p.etat = ps.etat;
                

                if (con.SaveChanges() == 1)
                {
                    con.personnes.Add(p);
                    con.Entry(p).State = EntityState.Modified;
                    r = 1;
                }
                else r = 0;

            }
            return r;
        }

        public int Supprimer(int id)
        {
            using (connection con = new connection())
            {
                p = con.personnes.Where(x => x.id_pers == id).First();
                if (con.Entry(p).State == EntityState.Detached)
                    con.personnes.Attach(p);
                con.personnes.Remove(p);
                con.SaveChanges();
                return r = 1;


            }
        }
    }
}
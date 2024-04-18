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
    public class Intitule_produitImp : IIntitule_produit
    {
        intitule_produit ip = new intitule_produit();
        int r;
        public int Ajout(intitule_produit_classe it)
        {
            using (connection con = new connection())//etablir la connexion
            {
                ip.nom_produit = it.nom_produit;
               

                con.intitule_produit.Add(ip);

                if (con.SaveChanges() == 1)
                {
                    con.intitule_produit.Add(ip);
                    r = 1;
                }
                else
                    r = 0;
                return r;
            }
        }

        public void Chargerintp(DropDownList dp)
        {
            dp.Items.Clear();
            using (connection con = new connection())
            {

                var obj = (from p in con.intitule_produit select p).ToList();
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
                        item.Value = data.id_produit.ToString();
                        item.Text = data.nom_produit;
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

        public void ChargerList(GridView gdv)
        {
            using (connection con = new connection())//etablir la connexion
            {
                var obj = (from o in con.intitule_produit
                           select new
                           {
                               id_produit = o.id_produit,
                               nom_produit = o.nom_produit,
                           }).ToList();
                gdv.DataSource = obj;
                gdv.DataBind();

            }
        }

        public void Display(intitule_produit_classe intp, int id)
        {
            using (connection con = new connection())
            {
                ip = con.intitule_produit.Where(x => x.id_produit == id).FirstOrDefault();
                intp.nom_produit = ip.nom_produit;
                
               

            }
        }

        public int Modify(intitule_produit_classe ps, int id)
        {
            using (connection con = new connection())
            {
                
                    ip = con.intitule_produit.Where(x => x.id_produit == id).FirstOrDefault();
                ip.nom_produit = ps.nom_produit;

                if (con.SaveChanges() == 1)
                {
                    con.intitule_produit.Add(ip);
                    con.Entry(ip).State = EntityState.Modified;
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
                ip = con.intitule_produit.Where(x => x.id_produit == id).First();
                if (con.Entry(ip).State == EntityState.Detached)
                    con.intitule_produit.Attach(ip);
                con.intitule_produit.Remove(ip);
                con.SaveChanges();
                return r = 1;

            }
        }
    }
}
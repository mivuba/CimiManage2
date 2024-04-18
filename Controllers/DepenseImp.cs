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
    public class DepenseImp : IDepense
    {
        depense d = new depense();
        int r;
        public int Ajout(depense_classe dp)
        {
            using (connection con = new connection())//etablir la connexion
            {
                d.total_depense = dp.total_depense;
                d.mois = dp.mois;
                d.annee = dp.annee;
                d.statut = dp.statut; 

                con.depense.Add(d);

                if (con.SaveChanges() == 1)
                {
                    con.depense.Add(d);
                    r = 1;
                }
                else
                    r = 0;
                return r;
            }
        }

        public void Chargerdep(DropDownList dp)
        {
            dp.Items.Clear();
            using (connection con = new connection())
            {

                var obj = (from p in con.depense select p).ToList();
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
                        item.Value = data.id_dep.ToString();
                        item.Text = data.total_depense;
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
                var obj = (from o in con.depense
                           select new
                           {
                               id_dep = o.id_dep,
                               total_depense = o.total_depense,
                               mois = o.mois,
                               annee = o.annee,
                               statut = o.statut,
                           }).ToList();
                gdv.DataSource = obj;
                gdv.DataBind();

            }
        }

        public void Display(depense_classe ds, int id)
        {

            using (connection con = new connection())
            {
                d = con.depense.Where(x => x.id_dep == id).FirstOrDefault();
                ds.total_depense = d.total_depense;
                ds.mois = d.mois;
                ds.annee = d.annee;
                ds.statut = d.statut;

            }
        }

        public int Modify(depense_classe ps, int id)
        {
            using (connection con = new connection())
            {
                d = con.depense.Where(x => x.id_dep == id).FirstOrDefault();
                d.total_depense = ps.total_depense;
                d.mois = ps.mois;
                d.annee = ps.annee;
                d.statut = ps.statut;


                if (con.SaveChanges() == 1)
                {
                    con.depense.Add(d);
                    con.Entry(d).State = EntityState.Modified;
                    r = 1;
                }
                else r = 0;

            }
            return r;
        }
    }
}
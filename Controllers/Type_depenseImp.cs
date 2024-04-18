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
    public class Type_depenseImp : IType_depense
    {
        type_depense tp = new type_depense();
        int b;
        public int Ajout(type_depense_classe td)
        {

            using (connection con = new connection())
            {
                tp.id_pompe = td.id_pompe;
                tp.type_depens = td.type_depens;
                con.type_depense.Add(tp);
                if (con.SaveChanges() == 1)
                {
                    con.type_depense.Add(tp);
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
                var obj = (from a in con.type_depense
                           join o in con.pompe_funeble on a.id_pompe equals o.id_pompe
                           select new
                           {
                               id_type_dep = a.id_type_dep,
                               id_pompe = a.id_pompe,
                               type_depenss = a.type_depens,
                               nom_pomp = o.nom_pompe,
                           }
                            ).ToList();

                gdv.DataSource = obj;
                gdv.DataBind();
            }
        }

        public void Chargertyd(DropDownList dp)
        {
            dp.Items.Clear();
            using (connection con = new connection())
            {

                var obj = (from p in con.type_depense select p).ToList();
                if (obj != null && obj.Count() > 0)
                {
                    dp.Items.Clear();

                    ListItem item0 = new ListItem();
                    item0.Value = "-1";
                    item0.Text = "Selectionne la type_depense";
                    dp.Items.Add(item0);
                    foreach (var data in obj)
                    {
                        ListItem item = new ListItem();
                        item.Value = data.id_type_dep.ToString();
                        item.Text = data.type_depens;
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

        public void Display(type_depense_classe typed, int id)
        {
            using (connection con = new connection())
            {
                tp = con.type_depense.Where(x => x.id_type_dep == id).FirstOrDefault();
                //cm.com = h.com;
                if (tp != null)
                {
                    typed.id_type_dep = tp.id_type_dep;
                    typed.id_pompe = tp.id_pompe;
                    typed.type_depens = tp.type_depens;
                }
            }
        }

        public int Modify(type_depense_classe tpd, int id)
        {
            using (connection con = new connection())
            {
                tp = con.type_depense.Where(x => x.id_type_dep == id).FirstOrDefault();
                // h.com = pr.com;
                tp.type_depens = tpd.type_depens;
                tp.id_pompe = tpd.id_pompe;
                if (con.SaveChanges() == 1)
                {
                    con.type_depense.Add(tp);
                    con.Entry(tp).State = EntityState.Modified;
                    b = 1;
                }
                else b = 0;

            }
            return b;
        
    }
    }
}
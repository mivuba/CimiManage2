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
    public class Detail_depenseImp : IDetail_depense
    {
        detail_depense d = new detail_depense();
        int b;
        public int Ajout(detail_depense_classe dtp)
        {
            using (connection con = new connection())
            {
                d.id_type_dep = dtp.id_type_dep;
                d.id_dep = dtp.id_dep;
                d.quantite_depense = dtp.quantite_depense;
                d.prix_unite = dtp.prix_unite;
                d.nom_pers = dtp.nom_pers;

                con.detail_depense.Add(d);
                if (con.SaveChanges() == 1)
                {
                    con.detail_depense.Add(d);
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
                var obj = (from a in con.detail_depense
                           join tp in con.type_depense on a.id_type_dep equals tp.id_type_dep
                           join d in con.depense on a.id_dep equals d.id_dep

                           select new
                           {
                               id_det_dep = a.id_det_dep,
                               id_type_dep = a.id_type_dep,
                               id_dep = a.id_dep,
                               quantite_depense = a.quantite_depense,
                               prix_unite = a.prix_unite,
                               nom_pers = a.nom_pers,
                              

                               type_depens = tp.type_depens,
                               total_depense = d.total_depense,

                           }).ToList();

                gdv.DataSource = obj;
                gdv.DataBind();
            }
        }

        public void Display(detail_depense_classe dpt, int id)
        {
            using (connection con = new connection())
            {
                d = con.detail_depense.Where(x => x.id_det_dep == id).FirstOrDefault();

                dpt.id_type_dep = d.id_type_dep;
               dpt.id_dep = d.id_dep;
               dpt.quantite_depense = d.quantite_depense;
               dpt.prix_unite = d.prix_unite;
                dpt.nom_pers = d.nom_pers;
               

            }
        }

        public int Modify(detail_depense_classe detdp, int id)
        {

            using (connection con = new connection())
            {
                d = con.detail_depense.Where(x => x.id_det_dep == id).FirstOrDefault();

                d.id_type_dep = detdp.id_type_dep;
                d.id_dep = detdp.id_dep;
                d.quantite_depense = detdp.quantite_depense;
                d.prix_unite = detdp.prix_unite;
                d.nom_pers = detdp.nom_pers;
              

                if (con.SaveChanges() == 1)
                {
                    con.detail_depense.Add(d);
                    con.Entry(d).State = EntityState.Modified;
                    b = 1;
                }
                else b = 0;
            }
            return b;
        }
    }
}
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
    public class Detail_comImp : IDetail_com
    {
        detail_com d = new detail_com();
        int b;

        public int Ajout(detail_com_classe dtc)
        {

            using (connection con = new connection())//etablir la connexion
            {
                d.id_com = dtc.id_com;
                d.id_service = dtc.id_service;
                d.PU = dtc.PU;
                d.nom_feu = dtc.nom_feu;
                d.date_nass = dtc.date_nass;
                d.date_dece = dtc.date_dece;
                d.quantite_d_com = dtc.quantite_d_com;


                con.detail_com.Add(d);
                if (con.SaveChanges() == 1)
                {
                    con.detail_com.Add(d);
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
                var obj = (from a in con.detail_com
                           join i in con.service on a.id_service equals i.id_service
                           join p in con.commande on a.id_com equals p.id_com

                           select new
                           {
                               id_detail_com = a.id_detail_com,
                               id_service = a.id_service,
                               id_com = a.id_com,
                               PU = a.PU,
                               nom_feu = a.nom_feu,
                               date_nass = a.date_nass,
                               date_dece = a.date_dece,
                               quantite_d_com = a.quantite_d_com,



                               type_com = p.type_com,
                               nom_service = i.nom_service,

                           }).ToList();

                gdv.DataSource = obj;
                gdv.DataBind();
            }
        }

        public void Display(detail_com_classe dcom, int id)
        {
            using (connection con = new connection())
            {
                d = con.detail_com.Where(x => x.id_detail_com == id).FirstOrDefault();

                dcom.id_service = d.id_service;
                dcom.id_com = d.id_com;
                dcom.PU = d.PU;
                dcom.nom_feu = d.nom_feu;
                dcom.date_nass = d.date_nass;
                dcom.date_dece = d.date_dece;
                dcom.quantite_d_com = d.quantite_d_com;


            }
       
    }

        public int Modify(detail_com_classe dcd, int id)
        {
            using (connection con = new connection())
            {
                d = con.detail_com.Where(x => x.id_detail_com == id).FirstOrDefault();

                d.id_service = dcd.id_service;
                d.id_com = dcd.id_com;
                d.PU = dcd.PU;
                d.nom_feu = dcd.nom_feu;
                d.date_nass = dcd.date_nass;
                d.date_dece = dcd.date_dece;
                d.quantite_d_com = dcd.quantite_d_com;




                if (con.SaveChanges() == 1)
                {
                    con.detail_com.Add(d);
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
                d = con.detail_com.Where(x => x.id_detail_com == id).First();
                if (con.Entry(d).State == EntityState.Detached)
                    con.detail_com.Attach(d);
                con.detail_com.Remove(d);
                con.SaveChanges();
                return b = 1;

            }
        }
    }

    }



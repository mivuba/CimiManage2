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
    public class ServiceImp : IService
    {
        service d = new service();
        int b;
        public int Ajout(service_classe sv)
        {

            using (connection con = new connection())
            {
                d.id_pompe = sv.id_pompe;
                d.id_produit = sv.id_produit;
                d.nom_service = sv.nom_service;
                d.prix_service = sv.prix_service;
                d.longitude = sv.longitude;
                d.altitude = sv.altitude;

 

                con.service.Add(d);
                if (con.SaveChanges() == 1)
                {
                    con.service.Add(d);
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
                var obj = (from a in con.service
                           join i in con.intitule_produit on a.id_produit equals i.id_produit
                           join p in con.pompe_funeble on a.id_pompe equals p.id_pompe

                           select new
                           {
                               id_service = a.id_service,
                               id_pompe = a.id_pompe,
                               id_produit = a.id_produit,
                               nom_service = a.nom_service,
                               prix_service = a.prix_service,
                               longitude = a.longitude,
                               altitude = a.altitude,



                               nom_produit = i.nom_produit,
                               nom_pompe = p.nom_pompe,

                           }).ToList();

                gdv.DataSource = obj;
                gdv.DataBind();
            }
        }

        public void Chargersev(DropDownList dp)
        {
            dp.Items.Clear();
            using (connection con = new connection())
            {

                var obj = (from p in con.service select p).ToList();
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
                        item.Value = data.id_service.ToString();
                        item.Text = data.nom_service;
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

        public void Display(service_classe sev, int id)
        {
            using (connection con = new connection())
            {
                d = con.service.Where(x => x.id_service == id).FirstOrDefault();

                sev.id_pompe = d.id_pompe;
                sev.id_produit = d.id_produit;
                sev.nom_service = d.nom_service;
                sev.prix_service = d.prix_service;
                sev.longitude = d.longitude;
                sev.altitude = d.altitude;


            }
        }

        public int Modify(service_classe svc, int id)
        {
            using (connection con = new connection())
            {
                d = con.service.Where(x => x.id_service == id).FirstOrDefault();

                d.id_pompe = svc.id_pompe;
                d.id_produit = svc.id_produit;
                d.nom_service = svc.nom_service;
                d.prix_service = svc.prix_service;
                d.longitude = svc.longitude;
                d.altitude = svc.altitude;


            if (con.SaveChanges() == 1)
                {
                    con.service.Add(d);
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
                d = con.service.Where(x => x.id_service == id).First();
                if (con.Entry(d).State == EntityState.Detached)
                    con.service.Attach(d);
                con.service.Remove(d);
                con.SaveChanges();
                return b = 1;

            }
        }
    }
    }

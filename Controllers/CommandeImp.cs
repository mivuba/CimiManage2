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
    public class CommandeImp : ICommande
    {
        commande d = new commande();
        int b;
        public int Ajout(commande_classe cm)
        {
            using (connection con = new connection())
            {
                d.id_ut = cm.id_ut;
                d.id_service = cm.id_service;
                d.code_com = cm.code_com;
                d.type_com = cm.type_com;
                d.reduction = cm.reduction;
                d.date_com = cm.date_com;
                d.statut = cm.statut;
                d.etat = cm.etat;
                d.prix_total = cm.prix_total;
                d.annee = cm.annee;
                d.mois = cm.mois;
                d.prix_TVA = cm.prix_TVA;
                d.type_com_location = cm.type_com_location;
                d.type_com_achat = cm.type_com_achat;



                con.commande.Add(d);
                if (con.SaveChanges() == 1)
                {
                    con.commande.Add(d);
                    b = 1;
                }
                else
                    b = 0;
                return b;
            }
        }

        public void Chargercom(DropDownList dp)
        {

            dp.Items.Clear();
            using (connection con = new connection())
            {

                var obj = (from p in con.commande select p).ToList();
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
                        item.Value = data.id_com.ToString();
                        item.Text = data.type_com;
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
            using (connection con = new connection())
            {
                var obj = (from a in con.commande
                           join i in con.service on a.id_service equals i.id_service
                           join p in con.utilisateur on a.id_ut equals p.id_ut

                           select new
                           {
                               id_com = a.id_com,
                               id_service = a.id_service,
                               id_ut = a.id_ut,
                               code_com = a.code_com,
                               type_com = a.type_com,
                               reduction = a.reduction,
                               date_com = a.date_com,
                               statut = a.statut,
                               etat = a.etat,
                               prix_total = a.prix_total,
                               annee = a.annee,
                               mois = a.mois,
                               prix_TVA = a.prix_TVA,
                               type_com_location = a.type_com_location,
                               type_com_achat = a.type_com_achat,

                               nom_ut = p.nom_ut,
                               nom_service = i.nom_service,

                           }).ToList();

                gdv.DataSource = obj;
                gdv.DataBind();
            }
        }

        public void Display(commande_classe com, int id)
        {
            using (connection con = new connection())
            {
                d = con.commande.Where(x => x.id_com == id).FirstOrDefault();

                 com.id_service = d.id_service;
                 com.id_ut = d.id_ut;
                 com.code_com = d.code_com;
                 com.type_com = d.type_com;
                 com.reduction = d.reduction;
                 com.date_com = d.date_com;
                 com.statut = d.statut;
                 com.etat = d.etat;
                 com.prix_total = d.prix_total;
                 com.annee = d.annee;
                 com.mois = d.mois;
                 com.prix_TVA = d.prix_TVA;
                 com.type_com_location = d.type_com_location;
                 com.type_com_achat = d.type_com_achat;


            }
        }

        public int Modify(commande_classe comm, int id)
        {
            using (connection con = new connection())
            {
                d = con.commande.Where(x => x.id_com == id).FirstOrDefault();

                d.id_service = comm.id_service;
                d.id_ut = comm.id_ut;
                d.code_com = comm.code_com;
                d.type_com = comm.type_com;
                d.reduction = comm.reduction;
                d.date_com = comm.date_com;
                d.statut = comm.statut;
                d.etat = comm.etat;
                d.prix_total = comm.prix_total;
                d.annee = comm.annee;
                d.mois = comm.mois;
                d.prix_TVA = comm.prix_TVA;
                d.type_com_location = comm.type_com_location;
                d.type_com_achat = comm.type_com_achat;


                if (con.SaveChanges() == 1)
                {
                    con.commande.Add(d);
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
                d = con.commande.Where(x => x.id_com == id).First();
                if (con.Entry(d).State == EntityState.Detached)
                    con.commande.Attach(d);
                con.commande.Remove(d);
                con.SaveChanges();
                return b = 1;

            }
        }
    }
}
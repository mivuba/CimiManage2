using CimiManage.classe;
using CimiManage.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace CimiManage.Controllers
{
    public class UtilisateurImp : IUtilisateur
    {
        utilisateur u = new utilisateur();
        int b;
        public int Ajout(utilisateur_classe ut)
        {
            using (connection con = new connection())//etablir la connexion
            {
             u.id_pers = ut.id_pers;
             u .id_role = ut.id_role;
             u .id_pompe = ut.id_pompe;
             u .nom_ut = ut.nom_ut;
             u .prenom_ut = ut.prenom_ut;
             u .telephone = ut.telephone;
             u .email = ut.email;
             u .type_client = ut.type_client;
             u.type_personne = ut.type_personne;
             u.adresse = ut.adresse;

                con.utilisateur.Add(u);
            if (con.SaveChanges() == 1)
            {
                con.utilisateur.Add(u);
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
                var obj = (from a in con.utilisateur
                           join ps in con.personnes on a.id_pers equals ps.id_pers
                           join r in con.role on a.id_role equals r.id_role
                           join p in con.pompe_funeble on a.id_pompe equals p.id_pompe
                           select new
                           {
                               id_ut = a.id_ut,
                               id_pers = a.id_pers,
                               id_role = a.id_role,
                               id_pompe = a.id_pompe,
                               nom_ut = a.nom_ut,
                               prenom_ut = a.prenom_ut,
                               telephone = a.telephone,
                               email = a.email,
                               type_client = a.type_client,
                               type_personne = a.type_personne,
                               adresse = a.adresse,
                               user_name = ps.user_name,
                               nom_role = r.nom_role,
                               nom_pompe = p.nom_pompe,

                           }).ToList();

                gdv.DataSource = obj;
                gdv.DataBind();
            }
        }

        public void Chargerutil(DropDownList dp)
        {
            dp.Items.Clear();
            using (connection con = new connection())
            {

                var obj = (from p in con.utilisateur select p).ToList();
                if (obj != null && obj.Count() > 0)
                {
                    dp.Items.Clear();

                    ListItem item0 = new ListItem();
                    item0.Value = "-1";
                    item0.Text = "Selectionne la utilisateur";
                    dp.Items.Add(item0);
                    foreach (var data in obj)
                    {
                        ListItem item = new ListItem();
                        item.Value = data.id_ut.ToString();
                        item.Text = data.nom_ut;
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
       
        public void Display(utilisateur_classe util, int id)
        {
            using (connection con = new connection())
            {
                u = con.utilisateur.Where(x => x.id_ut == id).FirstOrDefault();
                util.id_pers = u.id_pers;
                util.id_role = u.id_role;
                util.id_pompe = u.id_pompe;
                util.nom_ut = u.nom_ut;
                util.prenom_ut = u.prenom_ut;
                util.telephone = u.telephone;
                util.email = u.email;
                util.type_client = u.type_client;
                util.type_personne = u.type_personne;
                util.adresse = u.adresse;

            }
        }

        public int Modify(utilisateur_classe utili, int id)
        {
            using (connection con = new connection())
            {
            u = con.utilisateur.Where(x => x.id_ut == id).FirstOrDefault();

                u.id_pers = utili.id_pers;
                u.id_role = utili.id_role;
                u.id_pompe = utili.id_pompe;
                u.nom_ut = utili.nom_ut;
                u.prenom_ut = utili.prenom_ut;
                u.telephone = utili.telephone;
                u.email = utili.email;
                u.type_client = utili.type_client;
                u.type_personne = utili.type_personne;
                u.adresse = utili.adresse;

                if (con.SaveChanges() == 1)
                {
                    con.utilisateur.Add(u);
                    con.Entry(u).State = EntityState.Modified;
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
                u = con.utilisateur.Where(x => x.id_ut == id).First();

                if (con.Entry(u).State == EntityState.Detached)
                    con.utilisateur.Attach(u);
                con.utilisateur.Remove(u);
                con.SaveChanges();
                return b = 1;

            }
        }
    }
}
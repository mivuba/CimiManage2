using CimiManage.classe;
using CimiManage.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace CimiManage.Controllers
{
    public class pompe_funebleImp : Ipompe_funeble
    {
        pompe_funeble p = new pompe_funeble();
        int r;
        public int Ajout(pompe_funeble_classe pomp)
        {
            using (connection con = new connection())//etablir la connexion
            {
                p.nom_pompe = pomp.nom_pompe;
                p.email = pomp.email;
                p.NIF = pomp.NIF;
                p.code = pomp.code;
                p.statut = pomp.statut;
                p.etat = pomp.etat;
                p.logos = pomp.logos;
                p.telephone = pomp.telephone;
                p.RC = pomp.RC;
                p.sigle = pomp.sigle;
                p.date_creation = pomp.date_creation;
                p.facebook = pomp.facebook;
                p.whatshapp = pomp.whatshapp;
                p.adresse = pomp.adresse;
                con.pompe_funeble.Add(p);

                if (con.SaveChanges() == 1)
                {
                    con.pompe_funeble.Add(p);
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
                var obj = (from o in con.pompe_funeble
                           select new
                           {
                               id_pompe = o.id_pompe,
                               nom_p = o.nom_pompe,
                               mail = o.email,
                               nif = o.NIF,
                               cod = o.code,
                               statut = o.statut,
                               etat = o.etat,
                               logo = o.logos,
                               phone = o.telephone,
                               rc = o.RC,
                               sigl = o.sigle,
                               date_creation = o.date_creation,
                               facebook = o.facebook,
                               whatsapp = o.whatshapp,
                               adress = o.adresse,
                           }).ToList();
                gdv.DataSource = obj;
                gdv.DataBind();

            }
        }

        public void ChargerPomp(DropDownList dp)
        {
            dp.Items.Clear();
            using (connection con = new connection())
            {

                var obj = (from p in con.pompe_funeble select p).ToList();
                if (obj != null && obj.Count() > 0)
                {
                    dp.Items.Clear();

                    ListItem item0 = new ListItem();
                    item0.Value = "-1";
                    item0.Text = "Selectionne la pompe_funeble";
                    dp.Items.Add(item0);
                    foreach (var data in obj)
                    {
                        ListItem item = new ListItem();
                        item.Value = data.id_pompe.ToString();       
                        item.Text = data.nom_pompe;
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

        public void Display(pompe_funeble_classe pm, int id)
        {
            using (connection con = new connection())
            {
                p = con.pompe_funeble.Where(x => x.id_pompe == id).FirstOrDefault();
                pm.nom_pompe = p.nom_pompe;
                pm.email = p.email;
                pm.NIF = p.NIF;
                pm.code = p.code;
                pm.statut = p.statut;
                pm.etat = p.etat;
               //pm.logos = p.logos;
                pm.telephone = p.telephone;
                pm.RC = p.RC;
                pm.sigle = p.sigle;
                pm.date_creation = p.date_creation;
                pm.facebook = p.facebook;
                pm.whatshapp = p.whatshapp;
                pm.adresse = p.adresse;
            }
        }

        public int Modify(pompe_funeble_classe pmpe, int id)
        {
            using (connection con = new connection())
            {
                p = con.pompe_funeble.Where(x => x.id_pompe == id).FirstOrDefault();
                p.nom_pompe = pmpe.nom_pompe;
                p.email = pmpe.email;
                p.NIF = pmpe.NIF;
                p.code = pmpe.code;
                p.statut = pmpe.statut;
                p.etat = pmpe.etat;
                p.logos = pmpe.logos;
                p.telephone = pmpe.telephone;
                p.RC = pmpe.RC;
                p.sigle = pmpe.sigle;
                p.date_creation = pmpe.date_creation;
                p.facebook = pmpe.facebook;
                p.whatshapp = pmpe.whatshapp;
                p.adresse = pmpe.adresse;

                if (con.SaveChanges() == 1)
                {
                    con.pompe_funeble.Add(p);
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
                p = con.pompe_funeble.Where(x => x.id_pompe == id).First();
                if (con.Entry(p).State == EntityState.Detached)
                    con.pompe_funeble.Attach(p);
                con.pompe_funeble.Remove(p);

                con.SaveChanges();
                return r = 1;


            }
        }

        public string UploadPhoto(FileUpload fileUpload)
        {
            if (fileUpload.HasFile)
            {
                string filename = Guid.NewGuid().ToString() + Path.GetExtension(fileUpload.FileName);
                string filePath = HttpContext.Current.Server.MapPath("~/photos/") + filename;
                fileUpload.SaveAs(filePath);
                return "/photos/" + filename;
            }
            return null;

        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CimiManage.classe
{
    public class utilisateur_classe
    {
        public int id_ut { get; set; }
        public int id_pers { get; set; }
        public int id_role { get; set; }
        public int id_pompe { get; set; }
        public string nom_ut { get; set; }
        public string prenom_ut { get; set; }
        public string telephone { get; set; }
        public string email { get; set; }
        public string type_client { get; set; }
        public string type_personne { get; set; }
        public string adresse { get; set; }
    }
}
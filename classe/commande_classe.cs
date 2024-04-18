using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CimiManage.classe
{
    public class commande_classe
    {
        public int id_com { get; set; }
        public int id_ut { get; set; }
        public int id_service { get; set; }
        public string code_com { get; set; }
        public string type_com { get; set; }
        public string reduction { get; set; }
        public string date_com { get; set; }
        public string statut { get; set; }
        public string etat { get; set; }
        public string prix_total { get; set; }
        public string annee { get; set; }
        public string mois { get; set; }
        public string prix_TVA { get; set; }
        public string type_com_location { get; set; }
        public string type_com_achat { get; set; }
    }
}
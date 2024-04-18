using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CimiManage.classe
{
    public class service_classe
    {
        public int id_service { get; set; }
        public int id_pompe { get; set; }
        public int id_produit { get; set; }
        public string nom_service { get; set; }
        public string prix_service { get; set; }
        public string longitude { get; set; }
        public string altitude { get; set; }
    }
}
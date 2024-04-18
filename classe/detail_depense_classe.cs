using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CimiManage.classe
{
    public class detail_depense_classe
    {
        public int id_det_dep { get; set; }
        public int id_dep { get; set; }
        public int id_type_dep { get; set; }
        public string quantite_depense { get; set; }
        public string prix_unite { get; set; }
        public string nom_pers { get; set; }
    }
}
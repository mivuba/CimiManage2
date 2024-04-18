using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CimiManage.classe
{
    public class detail_com_classe
    {
        public int id_detail_com { get; set; }
        public int id_com { get; set; }
        public int id_service { get; set; }
        public string PU { get; set; }
        public string nom_feu { get; set; }
        public string date_nass { get; set; }
        public string date_dece { get; set; }
        public string quantite_d_com { get; set; }
    }
}
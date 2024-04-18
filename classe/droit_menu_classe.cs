using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CimiManage.classe
{
    public class droit_menu_classe
    {
        public int id_dmenu { get; set; }
        public int id_role { get; set; }
        public int id_menu { get; set; }
        public string gerer { get; set; }
        public string ajouter { get; set; }
        public string acces { get; set; }
    }
}
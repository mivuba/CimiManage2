using CimiManage.classe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;

namespace CimiManage.Controllers
{
    internal interface IDroit_menu
    {
        int Ajout(droit_menu_classe dm);
        void ChargerList(GridView gdv);
        void Display(droit_menu_classe dmn, int id);
        int Modify(droit_menu_classe dmnu, int id);
        int Supprimer(int id);
    }
}

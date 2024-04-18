using CimiManage.classe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;

namespace CimiManage.Controllers
{
    internal interface IMenu
    {
        int Ajout(menu_classe mn);
        void ChargerList(GridView gdv);
        void Display(menu_classe mu, int id);
        int Modify(menu_classe mu, int id);
        void Chargermn(DropDownList dp);
    }
}

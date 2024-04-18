using CimiManage.classe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;

namespace CimiManage.Controllers
{
    internal interface IDepense
    {
        int Ajout(depense_classe dp);
        void ChargerList(GridView gdv);
        void Display(depense_classe ds, int id);
        int Modify(depense_classe ps, int id);
        void Chargerdep(DropDownList dp);
    }
}

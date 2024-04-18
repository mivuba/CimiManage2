using CimiManage.classe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;

namespace CimiManage.Controllers
{
    internal interface IType_depense
    {
        int Ajout(type_depense_classe td);
        void ChargerList(GridView gdv);
        void Display(type_depense_classe typed, int id);
        int Modify(type_depense_classe tpd, int id);
        void Chargertyd(DropDownList dp);
    }
}

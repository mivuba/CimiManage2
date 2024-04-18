using CimiManage.classe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;

namespace CimiManage.Controllers
{
    internal interface Irole
    {
        int Ajout(role_classe rl);
        void ChargerList(GridView gdv);
        void Display(role_classe rl, int id);
        int Modify(role_classe rol, int id);
        int Supprimer(int id);
        void Chargerrole(DropDownList dp);
    }
}

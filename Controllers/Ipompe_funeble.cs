using CimiManage.classe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;

namespace CimiManage.Controllers
{
    internal interface Ipompe_funeble
    {
        int Ajout(pompe_funeble_classe pomp);
        void ChargerList(GridView gdv);
        void Display(pompe_funeble_classe pm, int id);
        int Modify(pompe_funeble_classe pmpe, int id);
        int Supprimer(int id);
        void ChargerPomp(DropDownList dp);
    }
}

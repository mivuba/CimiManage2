using CimiManage.classe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;

namespace CimiManage.Controllers
{
    internal interface IDetail_depense
    {
        int Ajout(detail_depense_classe dtp);
        void ChargerList(GridView gdv);
        void Display(detail_depense_classe dpt, int id);
        int Modify(detail_depense_classe detdp, int id);
    }
}

using CimiManage.classe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;

namespace CimiManage.Controllers
{
    internal interface IDetail_com
    {
        int Ajout(detail_com_classe dtc);
        void ChargerList(GridView gdv);
        void Display(detail_com_classe dcom, int id);
        int Modify(detail_com_classe dcd, int id);
        int Supprimer(int id);
    }
}

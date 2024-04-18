using CimiManage.classe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;

namespace CimiManage.Controllers
{
    internal interface IService
    {
        int Ajout(service_classe sv);
        void ChargerList(GridView gdv);
        void Display(service_classe sev, int id);
        int Modify(service_classe svc, int id);
        int Supprimer(int id);
        void Chargersev(DropDownList dp);
    }
}

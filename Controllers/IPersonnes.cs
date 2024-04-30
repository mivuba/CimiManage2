using CimiManage.classe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;

namespace CimiManage.Controllers
{
    internal interface IPersonnes
    {
        int Ajout(personnes_classe pr);
        void ChargerList(GridView gdv);
        void Display(personnes_classe prs, int id);
        int Modify(personnes_classe ps, int id);
        int Supprimer(int id);
        void ChargerPers(DropDownList dp);
        int Connect(personnes_classe log, string usersnm, string pswd);
    }
}

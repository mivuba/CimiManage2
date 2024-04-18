using CimiManage.classe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;

namespace CimiManage.Controllers
{
    internal interface IUtilisateur
    {
        int Ajout(utilisateur_classe ut);
        void ChargerList(GridView gdv);
        void Display(utilisateur_classe util, int id);
        int Modify(utilisateur_classe utili, int id);
        int Supprimer(int id);
        void Chargerutil(DropDownList dp);
    }
}

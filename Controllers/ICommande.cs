using CimiManage.classe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;

namespace CimiManage.Controllers
{
    internal interface ICommande
    {
        int Ajout(commande_classe cm);
        void ChargerList(GridView gdv);
        void Display(commande_classe com, int id);
        int Modify(commande_classe comm, int id);
        int Supprimer(int id);
        void Chargercom(DropDownList dp);
    }
}

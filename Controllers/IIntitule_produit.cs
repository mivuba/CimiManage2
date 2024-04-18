using CimiManage.classe;
using CimiManage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;

namespace CimiManage.Controllers
{
    internal interface IIntitule_produit
    {
       
        int Ajout(intitule_produit_classe it);
        void ChargerList(GridView gdv);
        void Display(intitule_produit_classe intp, int id);
        int Modify(intitule_produit_classe ps, int id);
        void Chargerintp(DropDownList dp);
        int Supprimer(int id);
    }
}

using System.Collections.Generic;
using CSHARP.Models;

namespace CSHARP.Services
{
    public interface ICommandeService
    {
        List<Commande> GetAllCommandes();
        Commande GetCommandeById(int id);
        void AddCommande(Commande commande);
        void UpdateCommande(Commande commande);
        void DeleteCommande(int id);
    }
}

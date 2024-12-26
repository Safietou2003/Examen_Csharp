using System.Collections.Generic;
using System.Linq;
using CSHARP.Models;

namespace CSHARP.Repository.Impl
{
    public class CommandeRepositoryImpl : ICommandeRepository
    {
        private List<Commande> commandes = new List<Commande>();

        public IEnumerable<Commande> GetAll()
        {
            return commandes;
        }

        public Commande GetById(int id)
        {
            return commandes.FirstOrDefault(c => c.Id == id);
        }

        public void Add(Commande commande)
        {
            commandes.Add(commande);
        }

        public void Update(Commande commande)
        {
            var existingCommande = GetById(commande.Id);
            if (existingCommande != null)
            {
                existingCommande.Date = commande.Date;
                existingCommande.Montant = commande.Montant;
                existingCommande.Statut = commande.Statut;
                existingCommande.ClientId = commande.ClientId;
            }
        }

        public void Delete(int id)
        {
            var commande = GetById(id);
            if (commande != null)
            {
                commandes.Remove(commande);
            }
        }
    }
}

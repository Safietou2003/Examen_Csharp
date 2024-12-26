using System.Collections.Generic;
using System.Linq;
using CSHARP.Models;

namespace CSHARP.Repository.Impl
{
    public class PaiementRepositoryImpl : IPaiementRepository
    {
        private List<Paiement> paiements = new List<Paiement>();

        public IEnumerable<Paiement> GetAll()
        {
            return paiements;
        }

        public Paiement GetById(int id)
        {
            return paiements.FirstOrDefault(p => p.Id == id);
        }

        public void Add(Paiement paiement)
        {
            paiements.Add(paiement);
        }

        public void Update(Paiement paiement)
        {
            var existingPaiement = GetById(paiement.Id);
            if (existingPaiement != null)
            {
                existingPaiement.Type = paiement.Type;
                existingPaiement.Montant = paiement.Montant;
                existingPaiement.Reference = paiement.Reference;
                existingPaiement.Date = paiement.Date;
                existingPaiement.FactureId = paiement.FactureId;
            }
        }

        public void Delete(int id)
        {
            var paiement = GetById(id);
            if (paiement != null)
            {
                paiements.Remove(paiement);
            }
        }
    }
}


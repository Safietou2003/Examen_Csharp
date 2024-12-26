using System.Collections.Generic;
using System.Linq;
using CSHARP.Models;

namespace CSHARP.Repository.Impl
{
    public class FactureRepositoryImpl : IFactureRepository
    {
        private List<Facture> factures = new List<Facture>();

        public IEnumerable<Facture> GetAll()
        {
            return factures;
        }

        public Facture GetById(int id)
        {
            return factures.FirstOrDefault(f => f.Id == id);
        }

        public void Add(Facture facture)
        {
            factures.Add(facture);
        }

        public void Update(Facture facture)
        {
            var existingFacture = GetById(facture.Id);
            if (existingFacture != null)
            {
                existingFacture.Date = facture.Date;
                existingFacture.Montant = facture.Montant;
                existingFacture.CommandeId = facture.CommandeId;
            }
        }

        public void Delete(int id)
        {
            var facture = GetById(id);
            if (facture != null)
            {
                factures.Remove(facture);
            }
        }
    }
}

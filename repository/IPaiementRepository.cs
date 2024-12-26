using System.Collections.Generic;
using CSHARP.Models;

namespace CSHARP.Repository
{
    public interface IPaiementRepository
    {
        IEnumerable<Paiement> GetAll();
        Paiement GetById(int id);
        void Add(Paiement paiement);
        void Update(Paiement paiement);
        void Delete(int id);
    }
}


using System.Collections.Generic;
using CSHARP.Models;

namespace CSHARP.Repository
{
    public interface IFactureRepository
    {
        IEnumerable<Facture> GetAll();
        Facture GetById(int id);
        void Add(Facture facture);
        void Update(Facture facture);
        void Delete(int id);
    }
}

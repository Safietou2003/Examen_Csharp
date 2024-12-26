using System.Collections.Generic;
using CSHARP.Models;

namespace CSHARP.Repository
{
    public interface ICommandeRepository
    {
        IEnumerable<Commande> GetAll();
        Commande GetById(int id);
        void Add(Commande commande);
        void Update(Commande commande);
        void Delete(int id);
    }
}

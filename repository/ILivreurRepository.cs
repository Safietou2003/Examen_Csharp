using System.Collections.Generic;
using CSHARP.Models;

namespace CSHARP.Repository
{
    public interface ILivreurRepository
    {
        IEnumerable<Livreur> GetAll();
        Livreur GetById(int id);
        void Add(Livreur livreur);
        void Update(Livreur livreur);
        void Delete(int id);
    }
}

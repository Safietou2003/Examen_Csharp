using System.Collections.Generic;
using CSHARP.Models;

namespace CSHARP.Repository
{
    public interface IProduitRepository
    {
        IEnumerable<Produit> GetAll();
        Produit GetById(int id);
        void Add(Produit produit);
        void Update(Produit produit);
        void Delete(int id);
    }
}

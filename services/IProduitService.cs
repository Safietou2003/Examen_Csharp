using System.Collections.Generic;
using CSHARP.Models;

namespace CSHARP.Services
{
    public interface IProduitService
    {
        List<Produit> GetAllProduits();
        Produit GetProduitById(int id);
        void AddProduit(Produit produit);
        void UpdateProduit(Produit produit);
        void DeleteProduit(int id);
    }
}

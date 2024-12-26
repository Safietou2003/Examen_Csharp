using System.Collections.Generic;
using System.Linq;
using CSHARP.Models;

namespace CSHARP.Repository.Impl
{
    public class ProduitRepositoryImpl : IProduitRepository
    {
        private List<Produit> produits = new List<Produit>();

        public IEnumerable<Produit> GetAll()
        {
            return produits;
        }

        public Produit GetById(int id)
        {
            return produits.FirstOrDefault(p => p.Id == id);
        }

        public void Add(Produit produit)
        {
            produits.Add(produit);
        }

        public void Update(Produit produit)
        {
            var existingProduit = GetById(produit.Id);
            if (existingProduit != null)
            {
                existingProduit.Libelle = produit.Libelle;
                existingProduit.QuantiteStock = produit.QuantiteStock;
                existingProduit.PrixUnitaire = produit.PrixUnitaire;
                existingProduit.QuantiteSeuil = produit.QuantiteSeuil;
                existingProduit.Images = produit.Images;
            }
        }

        public void Delete(int id)
        {
            var produit = GetById(id);
            if (produit != null)
            {
                produits.Remove(produit);
            }
        }
    }
}

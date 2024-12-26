using System.Collections.Generic;
using System.Linq;
using CSHARP.Models;
using CSHARP.Repository;

namespace CSHARP.Services.Impl
{
    public class ProduitServiceImpl : IProduitService
    {
        private readonly IProduitRepository _produitRepository;

        public ProduitServiceImpl(IProduitRepository produitRepository)
        {
            _produitRepository = produitRepository;
        }

        public List<Produit> GetAllProduits()
        {
            return _produitRepository.GetAll().ToList();
        }

        public Produit GetProduitById(int id)
        {
            return _produitRepository.GetById(id);
        }

        public void AddProduit(Produit produit)
        {
            _produitRepository.Add(produit);
        }

        public void UpdateProduit(Produit produit)
        {
            _produitRepository.Update(produit);
        }

        public void DeleteProduit(int id)
        {
            _produitRepository.Delete(id);
        }
    }
}


using Microsoft.AspNetCore.Mvc;
using CSHARP.Models;
using CSHARP.Services;

namespace CSHARP.Controllers
{
    public class ProduitController : Controller
    {
        private readonly IProduitService _produitService;

        public ProduitController(IProduitService produitService)
        {
            _produitService = produitService;
        }

        public IActionResult Index()
        {
            var produits = _produitService.GetAllProduits();
            return View(produits);
        }

        public IActionResult Details(int id)
        {
            var produit = _produitService.GetProduitById(id);
            if (produit == null)
            {
                return NotFound();
            }
            return View(produit);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Produit produit)
        {
            if (ModelState.IsValid)
            {
                _produitService.AddProduit(produit);
                return RedirectToAction(nameof(Index));
            }
            return View(produit);
        }

        public IActionResult Edit(int id)
        {
            var produit = _produitService.GetProduitById(id);
            if (produit == null)
            {
                return NotFound();
            }
            return View(produit);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Produit produit)
        {
            if (id != produit.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _produitService.UpdateProduit(produit);
                return RedirectToAction(nameof(Index));
            }
            return View(produit);
        }

        public IActionResult Delete(int id)
        {
            var produit = _produitService.GetProduitById(id);
            if (produit == null)
            {
                return NotFound();
            }
            return View(produit);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            _produitService.DeleteProduit(id);
            return RedirectToAction(nameof(Index));
        }
    }
}

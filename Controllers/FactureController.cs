using Microsoft.AspNetCore.Mvc;
using CSHARP.Models;
using CSHARP.Services;

namespace CSHARP.Controllers
{
    public class FactureController : Controller
    {
        private readonly IFactureService _factureService;

        public FactureController(IFactureService factureService)
        {
            _factureService = factureService;
        }

        public IActionResult Index()
        {
            var factures = _factureService.GetAllFactures();
            return View(factures);
        }

        public IActionResult Details(int id)
        {
            var facture = _factureService.GetFactureById(id);
            if (facture == null)
            {
                return NotFound();
            }
            return View(facture);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Facture facture)
        {
            if (ModelState.IsValid)
            {
                _factureService.AddFacture(facture);
                return RedirectToAction(nameof(Index));
            }
            return View(facture);
        }

        public IActionResult Edit(int id)
        {
            var facture = _factureService.GetFactureById(id);
            if (facture == null)
            {
                return NotFound();
            }
            return View(facture);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Facture facture)
        {
            if (id != facture.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _factureService.UpdateFacture(facture);
                return RedirectToAction(nameof(Index));
            }
            return View(facture);
        }

        public IActionResult Delete(int id)
        {
            var facture = _factureService.GetFactureById(id);
            if (facture == null)
            {
                return NotFound();
            }
            return View(facture);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            _factureService.DeleteFacture(id);
            return RedirectToAction(nameof(Index));
        }
    }
}

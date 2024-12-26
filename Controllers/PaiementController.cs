using Microsoft.AspNetCore.Mvc;
using CSHARP.Models;
using CSHARP.Services;

namespace CSHARP.Controllers
{
    public class PaiementController : Controller
    {
        private readonly IPaiementService _paiementService;

        public PaiementController(IPaiementService paiementService)
        {
            _paiementService = paiementService;
        }

        public IActionResult Index()
        {
            var paiements = _paiementService.GetAllPaiements();
            return View(paiements);
        }

        public IActionResult Details(int id)
        {
            var paiement = _paiementService.GetPaiementById(id);
            if (paiement == null)
            {
                return NotFound();
            }
            return View(paiement);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Paiement paiement)
        {
            if (ModelState.IsValid)
            {
                _paiementService.AddPaiement(paiement);
                return RedirectToAction(nameof(Index));
            }
            return View(paiement);
        }

        public IActionResult Edit(int id)
        {
            var paiement = _paiementService.GetPaiementById(id);
            if (paiement == null)
            {
                return NotFound();
            }
            return View(paiement);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Paiement paiement)
        {
            if (id != paiement.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _paiementService.UpdatePaiement(paiement);
                return RedirectToAction(nameof(Index));
            }
            return View(paiement);
        }

        public IActionResult Delete(int id)
        {
            var paiement = _paiementService.GetPaiementById(id);
            if (paiement == null)
            {
                return NotFound();
            }
            return View(paiement);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            _paiementService.DeletePaiement(id);
            return RedirectToAction(nameof(Index));
        }
    }
}

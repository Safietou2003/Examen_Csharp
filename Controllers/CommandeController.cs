using Microsoft.AspNetCore.Mvc;
using CSHARP.Models;
using CSHARP.Services;

namespace CSHARP.Controllers
{
    public class CommandeController : Controller
    {
        private readonly ICommandeService _commandeService;

        public CommandeController(ICommandeService commandeService)
        {
            _commandeService = commandeService;
        }

        public IActionResult Index()
        {
            var commandes = _commandeService.GetAllCommandes();
            return View(commandes);
        }

        public IActionResult Details(int id)
        {
            var commande = _commandeService.GetCommandeById(id);
            if (commande == null)
            {
                return NotFound();
            }
            return View(commande);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Commande commande)
        {
            if (ModelState.IsValid)
            {
                _commandeService.AddCommande(commande);
                return RedirectToAction(nameof(Index));
            }
            return View(commande);
        }

        public IActionResult Edit(int id)
        {
            var commande = _commandeService.GetCommandeById(id);
            if (commande == null)
            {
                return NotFound();
            }
            return View(commande);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Commande commande)
        {
            if (id != commande.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _commandeService.UpdateCommande(commande);
                return RedirectToAction(nameof(Index));
            }
            return View(commande);
        }

        public IActionResult Delete(int id)
        {
            var commande = _commandeService.GetCommandeById(id);
            if (commande == null)
            {
                return NotFound();
            }
            return View(commande);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            _commandeService.DeleteCommande(id);
            return RedirectToAction(nameof(Index));
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using CSHARP.Models;
using CSHARP.Services;

namespace CSHARP.Controllers
{
    public class LivreurController : Controller
    {
        private readonly ILivreurService _livreurService;

        public LivreurController(ILivreurService livreurService)
        {
            _livreurService = livreurService;
        }

        public IActionResult Index()
        {
            var livreurs = _livreurService.GetAllLivreurs();
            return View(livreurs);
        }

        public IActionResult Details(int id)
        {
            var livreur = _livreurService.GetLivreurById(id);
            if (livreur == null)
            {
                return NotFound();
            }
            return View(livreur);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Livreur livreur)
        {
            if (ModelState.IsValid)
            {
                _livreurService.AddLivreur(livreur);
                return RedirectToAction(nameof(Index));
            }
            return View(livreur);
        }

        public IActionResult Edit(int id)
        {
            var livreur = _livreurService.GetLivreurById(id);
            if (livreur == null)
            {
                return NotFound();
            }
            return View(livreur);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Livreur livreur)
        {
            if (id != livreur.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _livreurService.UpdateLivreur(livreur);
                return RedirectToAction(nameof(Index));
            }
            return View(livreur);
        }

        public IActionResult Delete(int id)
        {
            var livreur = _livreurService.GetLivreurById(id);
            if (livreur == null)
            {
                return NotFound();
            }
            return View(livreur);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            _livreurService.DeleteLivreur(id);
            return RedirectToAction(nameof(Index));
        }
    }
}

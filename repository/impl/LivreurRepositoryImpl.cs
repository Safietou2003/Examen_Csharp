using System.Collections.Generic;
using System.Linq;
using CSHARP.Models;

namespace CSHARP.Repository.Impl
{
    public class LivreurRepositoryImpl : ILivreurRepository
    {
        private List<Livreur> livreurs = new List<Livreur>();

        public IEnumerable<Livreur> GetAll()
        {
            return livreurs;
        }

        public Livreur GetById(int id)
        {
            return livreurs.FirstOrDefault(l => l.Id == id);
        }

        public void Add(Livreur livreur)
        {
            livreurs.Add(livreur);
        }

        public void Update(Livreur livreur)
        {
            var existingLivreur = GetById(livreur.Id);
            if (existingLivreur != null)
            {
                existingLivreur.Nom = livreur.Nom;
                existingLivreur.Prenom = livreur.Prenom;
                existingLivreur.Telephone = livreur.Telephone;
            }
        }

        public void Delete(int id)
        {
            var livreur = GetById(id);
            if (livreur != null)
            {
                livreurs.Remove(livreur);
            }
        }
    }
}

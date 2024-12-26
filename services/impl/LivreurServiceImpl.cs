using System.Collections.Generic;
using System.Linq;
using CSHARP.Models;
using CSHARP.Repository;

namespace CSHARP.Services.Impl
{
    public class LivreurServiceImpl : ILivreurService
    {
        private readonly ILivreurRepository _livreurRepository;

        public LivreurServiceImpl(ILivreurRepository livreurRepository)
        {
            _livreurRepository = livreurRepository;
        }

        public List<Livreur> GetAllLivreurs()
        {
            return _livreurRepository.GetAll().ToList();
        }

        public Livreur GetLivreurById(int id)
        {
            return _livreurRepository.GetById(id);
        }

        public void AddLivreur(Livreur livreur)
        {
            _livreurRepository.Add(livreur);
        }

        public void UpdateLivreur(Livreur livreur)
        {
            _livreurRepository.Update(livreur);
        }

        public void DeleteLivreur(int id)
        {
            _livreurRepository.Delete(id);
        }
    }
}


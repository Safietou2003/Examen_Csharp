using System.Collections.Generic;
using System.Linq;
using CSHARP.Models;
using CSHARP.Repository;

namespace CSHARP.Services.Impl
{
    public class PaiementServiceImpl : IPaiementService
    {
        private readonly IPaiementRepository _paiementRepository;

        public PaiementServiceImpl(IPaiementRepository paiementRepository)
        {
            _paiementRepository = paiementRepository;
        }

        public List<Paiement> GetAllPaiements()
        {
            return _paiementRepository.GetAll().ToList();
        }

        public Paiement GetPaiementById(int id)
        {
            return _paiementRepository.GetById(id);
        }

        public void AddPaiement(Paiement paiement)
        {
            _paiementRepository.Add(paiement);
        }

        public void UpdatePaiement(Paiement paiement)
        {
            _paiementRepository.Update(paiement);
        }

        public void DeletePaiement(int id)
        {
            _paiementRepository.Delete(id);
        }
    }
}

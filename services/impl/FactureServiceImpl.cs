using System.Collections.Generic;
using System.Linq;
using CSHARP.Models;
using CSHARP.Repository;

namespace CSHARP.Services.Impl
{
    public class FactureServiceImpl : IFactureService
    {
        private readonly IFactureRepository _factureRepository;

        public FactureServiceImpl(IFactureRepository factureRepository)
        {
            _factureRepository = factureRepository;
        }

        public List<Facture> GetAllFactures()
        {
            return _factureRepository.GetAll().ToList();
        }

        public Facture GetFactureById(int id)
        {
            return _factureRepository.GetById(id);
        }

        public void AddFacture(Facture facture)
        {
            _factureRepository.Add(facture);
        }

        public void UpdateFacture(Facture facture)
        {
            _factureRepository.Update(facture);
        }

        public void DeleteFacture(int id)
        {
            _factureRepository.Delete(id);
        }
    }
}

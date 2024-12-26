using System.Collections.Generic;
using System.Linq;
using CSHARP.Models;
using CSHARP.Repository;

namespace CSHARP.Services.Impl
{
    public class CommandeServiceImpl : ICommandeService
    {
        private readonly ICommandeRepository _commandeRepository;

        public CommandeServiceImpl(ICommandeRepository commandeRepository)
        {
            _commandeRepository = commandeRepository;
        }

        public List<Commande> GetAllCommandes()
        {
            return _commandeRepository.GetAll().ToList();
        }

        public Commande GetCommandeById(int id)
        {
            return _commandeRepository.GetById(id);
        }

        public void AddCommande(Commande commande)
        {
            _commandeRepository.Add(commande);
        }

        public void UpdateCommande(Commande commande)
        {
            _commandeRepository.Update(commande);
        }

        public void DeleteCommande(int id)
        {
            _commandeRepository.Delete(id);
        }
    }
}


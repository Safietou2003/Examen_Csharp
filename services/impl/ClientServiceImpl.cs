using System.Collections.Generic;
using System.Linq;
using CSHARP.Models;
using CSHARP.Repository;

namespace CSHARP.Services.Impl
{
    public class ClientServiceImpl : IClientService
    {
        private readonly IClientRepository _clientRepository;

        public ClientServiceImpl(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }

        public List<Client> GetAllClients()
        {
            return _clientRepository.GetAll().ToList();
        }

        public Client GetClientById(int id)
        {
            return _clientRepository.GetById(id);
        }

        public void AddClient(Client client)
        {
            _clientRepository.Add(client);
        }

        public void UpdateClient(Client client)
        {
            _clientRepository.Update(client);
        }

        public void DeleteClient(int id)
        {
            _clientRepository.Delete(id);
        }
    }
}

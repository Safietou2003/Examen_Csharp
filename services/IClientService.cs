using System.Collections.Generic;
using CSHARP.Models;

namespace CSHARP.Services
{
    public interface IClientService
    {
        List<Client> GetAllClients();
        Client GetClientById(int id);
        void AddClient(Client client);
        void UpdateClient(Client client);
        void DeleteClient(int id);
    }
}


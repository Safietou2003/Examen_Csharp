using System.Collections.Generic;
using System.Linq;
using CSHARP.Models;

namespace CSHARP.Repository.Impl
{
    public class ClientRepositoryListImpl : IClientRepository
    {
        private List<Client> clients = new List<Client>();

        public IEnumerable<Client> GetAll()
        {
            return clients;
        }

        public Client GetById(int id)
        {
            return clients.FirstOrDefault(c => c.Id == id);
        }

        public void Add(Client client)
        {
            clients.Add(client);
        }

        public void Update(Client client)
        {
            var existingClient = GetById(client.Id);
            if (existingClient != null)
            {
                existingClient.Nom = client.Nom;
                existingClient.Prenom = client.Prenom;
                existingClient.Telephone = client.Telephone;
                existingClient.Adresse = client.Adresse;
                existingClient.Solde = client.Solde;
            }
        }

        public void Delete(int id)
        {
            var client = GetById(id);
            if (client != null)
            {
                clients.Remove(client);
            }
        }
    }
}

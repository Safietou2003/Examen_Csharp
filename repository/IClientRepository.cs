using System.Collections.Generic;
using CSHARP.Models;

namespace CSHARP.Repository
{
    public interface IClientRepository
    {
        IEnumerable<Client> GetAll();
        Client GetById(int id);
        void Add(Client client);
        void Update(Client client);
        void Delete(int id);
    }
}

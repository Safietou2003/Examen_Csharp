using System.Collections.Generic;
using CSHARP.Models;

namespace CSHARP.Services
{
    public interface IPaiementService
    {
        List<Paiement> GetAllPaiements();
        Paiement GetPaiementById(int id);
        void AddPaiement(Paiement paiement);
        void UpdatePaiement(Paiement paiement);
        void DeletePaiement(int id);
    }
}

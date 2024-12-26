using System.Collections.Generic;
using CSHARP.Models;

namespace CSHARP.Services
{
    public interface IFactureService
    {
        List<Facture> GetAllFactures();
        Facture GetFactureById(int id);
        void AddFacture(Facture facture);
        void UpdateFacture(Facture facture);
        void DeleteFacture(int id);
    }
}

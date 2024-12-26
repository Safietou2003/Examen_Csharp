using System.Collections.Generic;
using CSHARP.Models;

namespace CSHARP.Services
{
    public interface ILivreurService
    {
        List<Livreur> GetAllLivreurs();
        Livreur GetLivreurById(int id);
        void AddLivreur(Livreur livreur);
        void UpdateLivreur(Livreur livreur);
        void DeleteLivreur(int id);
    }
}

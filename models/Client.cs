using System.Collections.Generic;

namespace CSHARP.Models
{
    public class Client
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Telephone { get; set; }
        public string Adresse { get; set; }
        public decimal Solde { get; set; }

        public ICollection<Commande> Commandes { get; set; }

        public override string ToString()
        {
            return $"Client[id={Id}, nom='{Nom}', prenom='{Prenom}', telephone='{Telephone}', adresse='{Adresse}', solde={Solde}]";
        }

        public bool Equals(Client other)
        {
            if (this == other) return true;
            if (other == null) return false;
            return Id == other.Id &&
                   Nom == other.Nom &&
                   Prenom == other.Prenom &&
                   Telephone == other.Telephone &&
                   Adresse == other.Adresse &&
                   Solde == other.Solde;
        }
    }
}


using System;

namespace CSHARP.Models
{
    public class Commande
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public decimal Montant { get; set; }
        public string Statut { get; set; }
        public int ClientId { get; set; }
        public Client Client { get; set; }
        public Facture Facture { get; set; }

        public override string ToString()
        {
            return $"Commande[id={Id}, date={Date}, montant={Montant}, statut='{Statut}', clientId={ClientId}]";
        }

        public bool Equals(Commande other)
        {
            if (this == other) return true;
            if (other == null) return false;
            return Id == other.Id &&
                   Date == other.Date &&
                   Montant == other.Montant &&
                   Statut == other.Statut &&
                   ClientId == other.ClientId;
        }
    }
}

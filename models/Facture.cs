using System;
using System.Collections.Generic;

namespace CSHARP.Models
{
    public class Facture
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public decimal Montant { get; set; }
        public int CommandeId { get; set; }
        public Commande Commande { get; set; }
        public ICollection<Paiement> Paiements { get; set; }

        public override string ToString()
        {
            return $"Facture[id={Id}, date={Date}, montant={Montant}, commandeId={CommandeId}]";
        }

        public bool Equals(Facture other)
        {
            if (this == other) return true;
            if (other == null) return false;
            return Id == other.Id &&
                   Date == other.Date &&
                   Montant == other.Montant &&
                   CommandeId == other.CommandeId;
        }
    }
}

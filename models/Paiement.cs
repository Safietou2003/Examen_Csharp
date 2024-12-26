using System;

namespace CSHARP.Models
{
    public class Paiement
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public decimal Montant { get; set; }
        public string Reference { get; set; }
        public DateTime Date { get; set; }
        public int FactureId { get; set; }
        public Facture Facture { get; set; }

        public override string ToString()
        {
            return $"Paiement[id={Id}, type='{Type}', montant={Montant}, reference='{Reference}', date={Date}, factureId={FactureId}]";
        }

        public bool Equals(Paiement other)
        {
            if (this == other) return true;
            if (other == null) return false;
            return Id == other.Id &&
                   Type == other.Type &&
                   Montant == other.Montant &&
                   Reference == other.Reference &&
                   Date == other.Date &&
                   FactureId == other.FactureId;
        }
    }
}

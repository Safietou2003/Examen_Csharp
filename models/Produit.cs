namespace CSHARP.Models
{
    public class Produit
    {
        public int Id { get; set; }
        public string Libelle { get; set; }
        public int QuantiteStock { get; set; }
        public decimal PrixUnitaire { get; set; }
        public int QuantiteSeuil { get; set; }
        public string Images { get; set; }

        public override string ToString()
        {
            return $"Produit[id={Id}, libelle='{Libelle}', quantiteStock={QuantiteStock}, prixUnitaire={PrixUnitaire}, quantiteSeuil={QuantiteSeuil}, images='{Images}']";
        }

        public bool Equals(Produit other)
        {
            if (this == other) return true;
            if (other == null) return false;
            return Id == other.Id &&
                   Libelle == other.Libelle &&
                   QuantiteStock == other.QuantiteStock &&
                   PrixUnitaire == other.PrixUnitaire &&
                   QuantiteSeuil == other.QuantiteSeuil &&
                   Images == other.Images;
        }
    }
}

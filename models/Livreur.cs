namespace CSHARP.Models
{
    public class Livreur
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Telephone { get; set; }

        public override string ToString()
        {
            return $"Livreur[id={Id}, nom='{Nom}', prenom='{Prenom}', telephone='{Telephone}']";
        }

        public bool Equals(Livreur other)
        {
            if (this == other) return true;
            if (other == null) return false;
            return Id == other.Id &&
                   Nom == other.Nom &&
                   Prenom == other.Prenom &&
                   Telephone == other.Telephone;
        }
    }
}

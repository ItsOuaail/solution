namespace GestionRH.Models
{
    public abstract class Personnel : Personne
    {
        public string Bureau { get; set; }
        public Personnel(string code, string nom, string prenom, string bureau) : base(code, nom, prenom)
        {
            this.Bureau = bureau;
        }

        public abstract double CalculerSalaire();
        
    }
}
namespace GestionRH.Models
{
    public class Administratif : Personnel
    {
        public Administratif(string code, string nom, string prenom, string bureau)
            : base(code, nom, prenom, bureau)
        {
        }

        public override double CalculerSalaire()
        {
            return 5000;
        }
    }
}

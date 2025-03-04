namespace GestionRH.Models
{
    public class Etudiant : Personne
    {
        public string Niveau { get; set; }
        public double MoyenneAnnuelle { get; set;}

        public Etudiant(string code, string nom, string prenom, string niveau, double moyenneAnnuelle) : base(code, nom, prenom)
        {
            this.Niveau = niveau;
            this.MoyenneAnnuelle = moyenneAnnuelle;
        }
    }
}
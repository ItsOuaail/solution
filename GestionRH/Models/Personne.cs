namespace GestRH.Models
{
    public abstract class Personne
    {
        public string Code { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }

        public Personne(string code, string nom, string prenom){
            this.Code = code;
            this.Nom = nom;
            this.Prenom = prenom;
        }
        
            }
}
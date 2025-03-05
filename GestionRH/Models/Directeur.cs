using System;
namespace GestionRH.Models
{
    public class Directeur : Personnel
    {
        private static Directeur instance;
        public double PrimeDeplacement { get; private set; }=2000;
        private Directeur(string code, string nom, string prenom, string bureau)
            : base(code, nom, prenom, bureau)
        {
        }
        public static Directeur GetInstance(string code, string nom, string prenom, string bureau)
        {
            if (instance == null)
            {
                instance = new Directeur(code, nom, prenom, bureau);
            }
            else
            {
                Console.WriteLine("Erreur: Un seul directeur peut exister !");
            }
            return instance;
        }
        public override double CalculerSalaire()
        {
            return 10000 + PrimeDeplacement;
        }
    }
}
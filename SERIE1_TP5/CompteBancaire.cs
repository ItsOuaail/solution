using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SERIE1_TP5
{
    internal class CompteBancaire
    {
        public int Numero { get; private set; }
        public string NomClient { get; set; }
        public string PrenomClient { get; set; }
        public double Solde { get; private set; }
        public List<string> Historique { get; private set; }

        public CompteBancaire(int numero, string nom, string prenom)
        {
            Numero = numero;
            NomClient = nom;
            PrenomClient = prenom;
            Solde = 0;
            Historique = new List<string>();
        }

        public void Crediter(double montant)
        {
            Solde += montant;
            Historique.Add($"+{montant} Dhs | Nouveau solde: {Solde} Dhs");
        }

        public bool Debiter(double montant)
        {
            if (montant > Solde) return false;
            Solde -= montant;
            Historique.Add($"-{montant} Dhs | Nouveau solde: {Solde} Dhs");
            return true;
        }

        public void AfficherHistorique()
        {
            Console.WriteLine($"=== Historique du compte {Numero} ===");
            foreach (var op in Historique)
                Console.WriteLine(op);
        }
    }
}

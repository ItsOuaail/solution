using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SERIE2_TP1
{
    internal class Employee
    {
        public string Nom { get; set; }
        public double Salaire { get; set; }
        public string Poste { get; set; }
        public DateTime DateEmbauche { get; set; }

        public Employee(string nom, double salaire, string poste, DateTime dateEmbauche)
        {
            Nom = nom;
            Salaire = salaire;
            Poste = poste;
            DateEmbauche = dateEmbauche;
        }

        public void AfficherInfos()
        {
            Console.WriteLine($"Nom: {Nom}, Poste: {Poste}, Salaire: {Salaire} Dhs, Embauché le: {DateEmbauche.ToShortDateString()}");
        }
    }
}

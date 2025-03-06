using System;
using System.Collections.Generic;
namespace GestionRH.Models
{
    public class Enseignant : Personnel
    {
        public string Grade { get; set; }
        public int VolumeHoraire { get; set; }
        private Dictionary<string, Groupe> Groupes { get; set; }
        public Enseignant(string code, string nom, string prenom, string bureau, string grade, int volumeHoraire) : base(code, nom, prenom, bureau)
        {
            Grade = grade;
            VolumeHoraire = volumeHoraire;
            Groupes = new Dictionary<string, Groupe>();
        }
        public void AjouterGroupe(Groupe groupe)
        {
            Groupes[groupe.Nom] = groupe;
        }

        public override double CalculerSalaire()
        {
            int tarif = Grade switch
            {
                "PA" => 300,
                "PH" => 350,
                "PES" => 400,
                _ => 0
            };
            return VolumeHoraire * tarif;
        }

        public void AfficherEnseignant()
        {
            Console.WriteLine($"Enseignant: {Nom} {Prenom}, Grade: {Grade}, Bureau: {Bureau}");
            Console.WriteLine("Groupes enseignés:");
            foreach (var kvp in Groupes)
            {
                Console.WriteLine($" - {kvp.Key}");
                kvp.Value.AfficherGroupe();
            }
        }
    }
}
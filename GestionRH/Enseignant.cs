using System;
using System.Collections.Generic;
namespace GestionRH.Models
{
    public class Enseignant : Personne
    {
        public string Grade { get; set; }
        public int VolumeHoraire { get; set; }
        private Dictionary<string, Groupe> Groupes { get; set; }
        public Enseignant(string nom, string prenom, string grade, int volumeHoraire) : base(nom, prenom)
        {
            Grade = grade;
            VolumeHoraire = volumeHoraire;
            Groupes = new Dictionary<string, Groupe>();
        }
        public void AjouterGroupe(Groupe groupe)
        {
            Groupes[groupe.Nom] = groupe
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
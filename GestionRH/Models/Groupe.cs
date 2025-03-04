using System;
using System.Collections.Generic;

namespace GestionRH.Models
{
    public class Groupe
    {
        public string Nom { get; set; }
        public List<Etudiants> listeEtudiants;

        public Groupe(string nom)
        {
            Nom = nom;
            listeEtudiants = new List<Etudiants>();
        }

        public void AjouterEtudiant(Etudiants etudiant)
        {
            listeEtudiants.Add(etudiant);
        }

        public void AfficherGroupe()
        {
            Console.WriteLine("Groupe : " {Nom});
            foreach (Etudiants etudiant in listeEtudiants)
            {
                Console.WriteLine($"Nom : {etudiant.Nom} Prenom : {etudiant.Prenom} Niveau : {etudiant.Niveau}");
            }
        }
    }
}
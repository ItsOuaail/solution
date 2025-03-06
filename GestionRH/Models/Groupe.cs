using System;
using System.Collections.Generic;

namespace GestionRH.Models
{
    public class Groupe
    {
        public string Nom { get; set; }
        private List<Etudiant> listeEtudiants { get; set; }

        public Groupe(string nom)
        {
            Nom = nom;
            listeEtudiants = new List<Etudiant>();
        }

        public void AjouterEtudiant(Etudiant etudiant)
        {
            listeEtudiants.Add(etudiant);
        }

        public void AfficherGroupe()
        {
            Console.WriteLine($"Groupe : {Nom}");
            foreach (Etudiant etudiant in listeEtudiants)
            {
                Console.WriteLine($"Nom : {etudiant.Nom} Prenom : {etudiant.Prenom} Niveau : {etudiant.Niveau}");
            }
        }
    }
}

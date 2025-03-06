using System;
using GestionRH.Models;

class Program
{
    static void Main()
    {
        RessourcesHumaines grh = new RessourcesHumaines();

        // Création des objets
        Enseignant e1 = new Enseignant("E001", "Ali", "Ahmed", "Bureau 12", "PA", 40);
        Groupe g1 = new Groupe("Groupe 1");
        g1.AjouterEtudiant(new Etudiant("S001", "Sara", "Mehdi", "2ème année", 15.5));

        e1.AjouterGroupe(g1);
        grh.AjouterPersonnel(e1);

        Administratif a1 = new Administratif("A001", "Nadia", "Karim", "Bureau 5");
        grh.AjouterPersonnel(a1);

        Directeur d1 = Directeur.GetInstance("D001", "Omar", "Ben", "Bureau Directeur");

        // Test des méthodes
        grh.AfficherEnseignants();
        Console.WriteLine($"Salaire de {e1.Nom}: {e1.CalculerSalaire()} DH");
        Console.WriteLine($"Salaire de {a1.Nom}: {a1.CalculerSalaire()} DH");
        Console.WriteLine($"Salaire du Directeur: {d1.CalculerSalaire()} DH");
    }
}

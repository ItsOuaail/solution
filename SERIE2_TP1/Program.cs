using SERIE2_TP1;
using System;

internal class Program
{
    static void Main()
    {
        // Création de la gestion des employés
        GestionEmployes gestion = new GestionEmployes();

        // Ajout de quelques employés
        gestion.AjouterEmploye(new Employee("Ahmed", 5000, "Développeur", new DateTime(2020, 5, 10)));
        gestion.AjouterEmploye(new Employee("Nadia", 7000, "Manager", new DateTime(2018, 8, 23)));
        gestion.AjouterEmploye(new Employee("Karim", 4000, "Technicien", new DateTime(2021, 3, 15)));

        // Afficher les employés
        gestion.AfficherTousLesEmployes();

        // Création du Directeur (Singleton)
        Directeur directeur = Directeur.GetInstance();
        directeur.SetGestionEmployes(gestion);

        // Affichage des statistiques
        directeur.AfficherStatistiques();

        // Suppression d'un employé
        gestion.SupprimerEmploye("Karim");

        // Afficher après suppression
        gestion.AfficherTousLesEmployes();

        // Affichage des statistiques après modification
        directeur.AfficherStatistiques();
    }
}

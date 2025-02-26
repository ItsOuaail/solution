using System;
using System.Collections.Generic;

public class Repertoire
{
    public string Nom { get; set; }
    public int NbrFichiers => fichiers.Count;
    private List<Fichier> fichiers;

    public Repertoire(string nom)
    {
        Nom = nom;
        fichiers = new List<Fichier>();
    }

    public void Afficher()
    {
        Console.WriteLine($"Répertoire: {Nom}");
        if (fichiers.Count == 0)
        {
            Console.WriteLine("Aucun fichier.");
        }
        else
        {
            foreach (var fichier in fichiers)
            {
                Console.WriteLine($"- {fichier.Nom}.{fichier.Extension} ({fichier.Taille} KB)");
            }
        }
    }

    public int Rechercher(string nom)
    {
        return fichiers.FindIndex(f => f.Nom == nom);
    }

    public void Ajouter(Fichier fichier)
    {
        if (NbrFichiers < 30)
        {
            fichiers.Add(fichier);
            Console.WriteLine($"{fichier.Nom}.{fichier.Extension} ajouté.");
        }
        else
        {
            Console.WriteLine("Le répertoire est plein.");
        }
    }

    public void Supprimer(string nom)
    {
        int index = Rechercher(nom);
        if (index != -1)
        {
            fichiers.RemoveAt(index);
            Console.WriteLine($"{nom} supprimé.");
        }
        else
        {
            Console.WriteLine("Fichier introuvable.");
        }
    }

    public void Renommer(string ancienNom, string nouveauNom)
    {
        int index = Rechercher(ancienNom);
        if (index != -1)
        {
            fichiers[index].Nom = nouveauNom;
            Console.WriteLine($"Fichier renommé en {nouveauNom}.");
        }
        else
        {
            Console.WriteLine("Fichier introuvable.");
        }
    }

    public void ModifierTaille(string nom, float nouvelleTaille)
    {
        int index = Rechercher(nom);
        if (index != -1)
        {
            fichiers[index].Taille = nouvelleTaille;
            Console.WriteLine($"Taille de {nom} modifiée.");
        }
        else
        {
            Console.WriteLine("Fichier introuvable.");
        }
    }

    public void AfficherPDFs()
    {
        Console.WriteLine("Fichiers PDF:");
        foreach (var fichier in fichiers)
        {
            if (fichier.Extension.ToLower() == "pdf")
            {
                Console.WriteLine($"- {fichier.Nom}.{fichier.Extension}");
            }
        }
    }

    public float GetTaille()
    {
        float totalSizeKB = 0;
        foreach (var fichier in fichiers)
        {
            totalSizeKB += fichier.Taille;
        }
        return totalSizeKB / 1024; // Convert KB to MB
    }
}

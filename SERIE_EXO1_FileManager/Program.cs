using System;

class Program
{
    static void Main()
    {
        Repertoire rep = new Repertoire("Mes Documents");

        rep.Ajouter(new Fichier("rapport", "pdf", 500));
        rep.Ajouter(new Fichier("photo", "jpg", 1200));
        rep.Ajouter(new Fichier("presentation", "ppt", 3000));

        rep.Afficher();

        Console.WriteLine($"Taille totale du répertoire: {rep.GetTaille()} MB");

        rep.AfficherPDFs();

        rep.Renommer("photo", "image_voyage");
        rep.Supprimer("rapport");
        rep.Afficher();
    }
}

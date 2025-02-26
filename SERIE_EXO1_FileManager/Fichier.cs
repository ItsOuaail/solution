public class Fichier
{
    public string Nom { get; set; }
    public string Extension { get; set; }
    public float Taille { get; set; } // in KB

    public Fichier(string nom, string extension, float taille)
    {
        Nom = nom;
        Extension = extension;
        Taille = taille;
    }
}

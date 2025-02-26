using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serie1_TP2_ConsommationCafe
{
    internal class Programmer
    {
        public int ID { get; private set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public int Bureau { get; set; }

        public Programmer(int id, string nom, string prenom, int bureau)
        {
            ID = id;
            Nom = nom;
            Prenom = prenom;
            Bureau = bureau;
        }

        public void Afficher()
        {
            Console.WriteLine($"ID: {ID}, Nom: {Nom}, Prénom: {Prenom}, Bureau: {Bureau}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace GestionRH.Models
{
    public class RessourcesHumaines : IRessourcesHumaines
    {
        private List<Personnel> listGRH = new List<Personnel>();
        public void AjouterPersonnel(Personnel p)
        {
            listeGRH.Add(p);
        }

        public void AfficherEnseignants()
        {
            foreach (var p in listeGRH.OfType<Enseignant>())
            {
                p.AfficherEnseignant();
            }
        }

        public int RechercherEns(string code)
        {
            var index = listGRH.FindIndex(p => p is Enseignant && p.Code == code);
            return index >= 0 ? index : -1;
        }
    }
}
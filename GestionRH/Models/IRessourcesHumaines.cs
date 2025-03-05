using System;
using System.Collections.Generic;

namespace GestionRH.Models
{
    public interface IRessourcesHumaines
    {
        void AfficherEnseignants();
        int RechercherEns(string code);
    }
}

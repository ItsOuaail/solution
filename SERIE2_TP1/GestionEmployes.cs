using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SERIE2_TP1
{
    internal class GestionEmployes
    {
        private List<Employee> employes;

        public GestionEmployes()
        {
            employes = new List<Employee>();
        }

        public void AjouterEmploye(Employee employe)
        {
            employes.Add(employe);
            Console.WriteLine($"Employé {employe.Nom} ajouté.");
        }

        public void SupprimerEmploye(string nom)
        {
            var employe = employes.FirstOrDefault(e => e.Nom == nom);
            if (employe != null)
            {
                employes.Remove(employe);
                Console.WriteLine($"Employé {nom} supprimé.");
            }
            else
            {
                Console.WriteLine($"Aucun employé trouvé avec le nom {nom}.");
            }
        }

        public double CalculerSalaireTotal()
        {
            return employes.Sum(e => e.Salaire);
        }

        public double CalculerSalaireMoyen()
        {
            if (employes.Count == 0) return 0;
            return employes.Average(e => e.Salaire);
        }

        public void AfficherTousLesEmployes()
        {
            Console.WriteLine("\n=== Liste des employés ===");
            if (employes.Count == 0)
            {
                Console.WriteLine("Aucun employé enregistré.");
                return;
            }

            foreach (var employe in employes)
            {
                employe.AfficherInfos();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDF
{
    internal class Poulailler
    {

        public string Nom;
        public int CapaciteMaximale;
        public List<Poule> Poules;

        public Poulailler(string nom, int capaciteMaximale)
        {
            Nom = nom;
            CapaciteMaximale = capaciteMaximale;
            Poules = new List<Poule>();
        }

        public void AjouterPoule(Poule poule)
        {
            if (Poules.Count < CapaciteMaximale)
            {
                Poules.Add(poule);
                Console.WriteLine("La poule a été ajoutée au poulailler.");
            }
            else
            {
                Console.WriteLine("Le poulailler est plein. Impossible d'ajouter une nouvelle poule.");
            }
        }

        public void AfficherPoules()
        {
            Console.WriteLine($"Poulailler : {Nom}");
            Console.WriteLine("Liste des poules :");

            for (int i = 0; i < Poules.Count; i++)
            {
                Console.WriteLine($"Poule {i + 1}: {Poules[i].Nom}");
            }

            Console.WriteLine($"Total de poules : {Poules.Count}");
        }

        public void SupprimerPoule(int numeroAffichage)
        {
            if (numeroAffichage >= 1 && numeroAffichage <= Poules.Count)
            {
                Poules.RemoveAt(numeroAffichage - 1);
                Console.WriteLine("La poule a été supprimée du poulailler.");
            }
            else
            {
                Console.WriteLine("Numéro d'affichage invalide. Veuillez spécifier un numéro valide.");
            }
        }
    }
}

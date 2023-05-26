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

        public string Nom { get; set; }
        public int CapaciteMaximale { get; set; }
        public List<Poule> Poules { get; set; }

        public Poulailler(string nom, int capaciteMaximale)
        {
            Nom = nom;
            CapaciteMaximale = capaciteMaximale;
            Poules = new List<Poule>();
        }

        public void AjouterPoule(Poulailler poulailler, Poule poule)
        {
            if (poulailler.Poules.Count < CapaciteMaximale)
            {
                poulailler.Poules.Add(poule);
                Console.WriteLine($"La poule {poule.nom} a été ajoutée au poulailler.\n");
            }
            else
            {
                Console.WriteLine("Le poulailler est plein. Impossible d'ajouter une nouvelle poule.");
            }
        }

        public void SupprimerPoule(Poulailler poulailler, string nomPoule)
        {
            Poule pouleASupprimer = poulailler.Poules.Find(p => p.nom == nomPoule);
            if (pouleASupprimer != null)
            {
                poulailler.Poules.Remove(pouleASupprimer);
                Console.WriteLine("La poule " + nomPoule + " a été supprimée du poulailler.\n");
            }
            else
            {
                Console.WriteLine("La poule " + nomPoule + " n'a pas été trouvée dans le poulailler.\n");
            }
        }

        public void afficherPoulailler()
        {
            Console.WriteLine("Poules du pouillailer "+ Nom+":");
            for (int i = 0; i < Poules.Count; i++)
            {
                Console.WriteLine($"Poule no"+i+": "+Poules[i].nom);
            }
            Console.WriteLine("\nCapacite max du poulailler "+Nom +": "+CapaciteMaximale+"\n");
        }
    }

}

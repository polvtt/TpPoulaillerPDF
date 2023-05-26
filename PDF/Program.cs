using PDF;
using System.Collections.Generic;

// Instanciation d'un poule Ginger
Poule ginger = new Poule("Ginger", "gauloise", 0.8, Taille.L);
Poule ez = new Poule("ez", "gauloise", 0.8, Taille.L);

// Affichage de cette poule
ginger.Afficher();

Poulailler P1 = new Poulailler("P1",20);

P1.AjouterPoule(P1,ginger);
P1.AjouterPoule(P1,ez);
P1.afficherPoulailler();

P1.SupprimerPoule(P1, "ez");
P1.afficherPoulailler();
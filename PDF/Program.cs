using PDF;
using System.Collections.Generic;

// Instanciation d'un poule Ginger
Poule ginger = new Poule("Ginger", "gauloise", 0.8, Taille.L);
Poule ez = new Poule("ez", "gauloise", 0.8, Taille.L);

// Affichage de cette poule
ginger.Afficher();

Poulailler P1 = new Poulailler("P1",20);
Poulailler P2 = new Poulailler("P2", 5);

P1.AjouterPoule(P1,ginger);
P2.AjouterPoule(P2,ez);
P1.afficherPoulailler();
P2.afficherPoulailler();

//P1.SupprimerPoule(P1, "ez");
P1.afficherPoulailler();
P2.afficherPoulailler();

Poulailler P3 = P1.FusionnerPoulaillers(P1, P2);
P3.afficherPoulailler();


# SimulationsPretsBancaires
#### Application de bureau permettant de gérer des prêts, de calculer les mensualités et d’afficher l’échéancier complet.
#### Elle permet également de filtrer et trier les prêts, d’exporter les échéanciers en CSV et de visualiser (bonus) le capital restant dû sous forme de graphique.

## Fonctionnalités
###### Ajouter, modifier et supprimer des prêts.
###### Calcul automatique de la mensualité.
###### Affichage d’un tableau des prêts avec : emprunteur, montant, taux, durée, date, mensualité.
###### Filtrage par nom d’emprunteur et montant minimum.
###### Génération d’un échéancier détaillé (numéro, date, intérêts, principal, reste dû).
###### Export CSV de l’échéancier.
###### (Bonus) Graphique du capital restant dû.
###### Sauvegarde et chargement persistants via JSON.

## Lancer l’application
###### Ouvrir le projet dans Visual Studio 2022+.
###### Compiler le projet (.NET 6+ recommandé).
###### Exécuter FormulairePrincipal comme formulaire de démarrage.
###### Ajouter des prêts et tester les fonctionnalités depuis l’interface.

## Choix techniques
###### Langage : C#
###### .NET 6+ (WinForms)
###### Design des Interfaces faites avec la boites outils de Visual Studio 2022
###### Persistance : JSON pour la simplicité (possibilité de passer à SQLite + EF Core).
###### Interface graphique : WinForms, simple et intuitive.
######Filtres et tris : LINQ pour rechercher par emprunteur ou montant minimum.
###### Export CSV : UTF-8 avec séparateur ;.
###### Calcul mensualité : Formule classique d’un prêt amortissable.

## Limites
###### La persistance via JSON n’est pas adaptée aux bases volumineuses.
###### La gestion graphique du capital restant dû est en option et non dynamique.
###### Pas de gestion multi-utilisateurs ni sécurité.

## Jeux d’essai
###### Exemple de prêts à ajouter pour tester :
    Emprunteur	  Montant(€)	Taux annuel(%)	 Durée (mois)	  Date début
    Alice	      2000	           2	            12	          2025-01-01
    Bob	          5000	           5	            24	          2025-02-15
    Charlie	      10000	           3.5	            36	          2025-03-10

## Tester filtres :
###### Nom : “Alice” → seul le prêt d’Alice s’affiche.
###### Montant minimum : 4000 → seuls Bob et Charlie s’affichent.
###### Générer l’échéancier et exporter en CSV pour vérifier les calculs.

## Structure du projet
###### /Forms          -> Interfaces WinForms
###### /Models         -> Classes Prets et Echeance
###### /Services       -> Persistance, calculs, export CSV
###### Program.cs      -> Point d’entrée
###### README.md       -> Documentation
###### prets.json      -> Données persistantes

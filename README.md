# SimulationsPretsBancaires
### Application de bureau permettant de gérer des prêts, de calculer les mensualités et d’afficher l’échéancier complet et de visualiser le capital restant dû sous forme de graphique.
### Elle permet également de filtrer et trier les prêts, de selectionner un prêt et d’exporter les échéanciers en CSV.

## Fonctionnalités
###### Ajouter, modifier et supprimer des prêts.
###### Calcul automatique de la mensualité.
###### Affichage d’un tableau des prêts avec : emprunteur, montant, taux, durée, date, mensualité.
###### Filtrage par nom d’emprunteur et montant minimum.
###### Génération d’un échéancier détaillé (numéro, date, intérêts, principal, reste dû).
###### Affichage automatique après la génération de l’échéancier montrant l’évolution décroissante du capital restant dû.
###### L’utilisateur peut visualiser la progression du remboursement au fil des mois et la est synchronisé avec le tableau.
###### Export CSV de l’échéancier.
###### Graphique du capital restant dû.
###### Sauvegarde et chargement persistant via JSON.

## Lancement de l’application
###### Cloner l'application dans un dossier de votre choix
###### Dans ce dossier ouvre invite de commandes et taper: git clone https://github.com/dabofonsa/SimulationsPretsBancaires.git
###### Ouvrir le projet dans Visual Studio 2022+.
###### Compiler le projet (.NET 6+ recommandé).
###### Exécuter FormulairePrincipal comme formulaire de démarrage.
###### Vous pouvez aussi lancer l'exécutable "SimulationsPretsBancaires.exe" qui se trouve aussi dans le chemin :  /SimulationsPretsBancaires/bin/Debug/net8.0-windows/SimulationsPretsBancaires.exe
###### Ajouter des prêts et tester les fonctionnalités depuis l’interface.

## Choix techniques
###### Langage : C#
###### .NET 6+ (WinForms)
###### Design des Interfaces faites avec la boites outils de Visual Studio 2022
###### Persistance : JSON pour la simplicité.
###### Interface graphique : WinForms, simple et intuitive.
###### Filtres et tris : LINQ pour rechercher par emprunteur ou montant minimum.
###### Export CSV : UTF-8 avec séparateur ;.
###### Calcul mensualité : Formule classique d’un prêt amortissable.

## Limites
###### La persistance via JSON n’est pas adaptée aux bases volumineuses.
###### La gestion graphique du capital restant dû est en option et non dynamique.
###### Pas de gestion multi-utilisateurs ni sécurité.

## Jeux d’essai
###### Exemple de prêts à ajouter pour tester :     
        | Emprunteur | Montant(€) | Taux annuel(%) | Durée(mois) | Date début   | Mensualité(€) |
        | ---------- | ---------- | -------------- | ------------| ------------ | --------------|
        |  Alice     |  2000      |    2           |   12        |  9736.31     |   166.20      |
        |  Nicolas   |  5000      |    5           |   24        |  9471.82     |   219.36      |
        |  Claude    |  10000     |    3.5         |   36        |  9206.59     |   292.86      |
    
###### Exemple du tableau d'écheanceier de ALICE
        | N° Échéance | Date Échéance | Intérêts (€) | Principal (€) | Reste Dû (€) |           
        | ----------- | ------------- | ------------ | ------------- | ------------ |   
        | 1           | 2025-02-01    | 3.33         | 162.87        | 1837.13      |
        | 2           | 2025-03-01    | 3.06         | 163.14        | 1673.99      |
        | 3           | 2025-04-01    | 2.79         | 163.41        | 1510.58      |
        | 4           | 2025-05-01    | 2.52         | 163.68        | 1346.90      |
        | 5           | 2025-06-01    | 2.25         | 163.95        | 1182.95      |
        | 6           | 2025-07-01    | 1.97         | 164.23        | 1018.72      |
        | 7           | 2025-08-01    | 1.70         | 164.50        | 854.22       |
        | 8           | 2025-09-01    | 1.43         | 164.77        | 689.45       |
        | 9           | 2025-10-01    | 1.15         | 165.05        | 524.40       |
        | 10          | 2025-11-01    | 0.87         | 165.33        | 359.07       |
        | 11          | 2025-12-01    | 0.60         | 165.60        | 193.47       |
        | 12          | 2026-01-01    | 0.32         | 165.88        | 0.00         |

## Tester filtres par "Nom Emprunteur" ou par "Montant Minimum Prêt"
###### Nom : "Alice"  seul le prêt d’Alice s’affiche.
###### Montant minimum : 4000  seuls Bob et Charlie s’affichent.
###### Générer l’échéancier et exporter en CSV pour vérifier les calculs.

## Structure du projet
###### /Forms         ----> Interfaces WinForms
###### /Models        ----> Classes Prets et Echeance
###### /Services      ----> Persistance, calculs, export CSV
###### Program.cs     ----> Point d’entrée
###### README.md      ----> Documentation
###### prets.json     ----> Données persistantes

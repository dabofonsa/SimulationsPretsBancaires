using SimulationsPretsBancaires.Models;
using SimulationsPretsBancaires.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimulationsPretsBancaires.Forms
{
    // Formulaire principal de l'application - Gestion de la liste des prêts
    // Implémente les fonctionnalités CRUD et les filtres LINQ
    public partial class FormulairePrincipal : Form
    {
        // Service de persistance des prêts en JSON
        private readonly PersistancePretsJson service;
        //private BindingSource sourceDonnees = new BindingSource();


        // Constructeur : initialise le formulaire et charge les données
        public FormulairePrincipal()
        {
            InitializeComponent();
            service = new PersistancePretsJson();
            ChargerDonnees();

            // Configuration de la fenêtre et Titre
            Text = "Gestion des Prêts Bancaires";
            Width = 1150;
            Height = 850;
            StartPosition = FormStartPosition.CenterScreen;

            // Liaison des événements aux boutons de recherche
            btnRechercher.Click += (s, e) => AppliquerFiltre();
            btnRafraichirTableau.Click += (s, e) => RafraichirTableau();

            // Liaison des événements aux boutons CRUD
            btnAjouterPret.Click += (s, e) => AjouterPret();
            btnModifierPret.Click += (s, e) => ModifierPret();
            btnSupprimerPret.Click += (s, e) => SupprimerPret();

            // Filtrage automatique lors de la saisie
            champRechercherEmprunteur.TextChanged += (s, e) => AppliquerFiltre();
            champMontantMinimumPret.ValueChanged += (s, e) => AppliquerFiltre();

            // Liaison des événements pour l'échéancier
            btnAfficherEcheancier.Click += (s, e) => AfficherEcheancier();
            btnExporterEcheancierCSV.Click += (s, e) => ExporterEcheancierCSV();

            // Gere de l'état des champs de recherche
            MettreAJourEtatChampsRecherche();
        }

        // Charge tous les prêts depuis la persistance et les affiche dans le tableau
        // Calcule également la mensualité pour chaque prêt
        private void ChargerDonnees()
        {
            // Récupération de tous les prêts
            var prets = service.RecupererTous();

            // Calcul de la mensualité pour chaque prêt
            foreach (var pret in prets)
            {
                // Calcul et affectation de la mensualité
                pret.Mensualite = CalculateurPret.CalculerMensualite(pret.Montant, pret.TauxAnnuel, pret.DureeMois);
            }

            // Liaison au tableau via BindingSource
            sourceDonnees.DataSource = prets;
            tableauDesPrets.DataSource = sourceDonnees;
            AppliquerFiltre();
        }


        // Récupère le prêt actuellement sélectionné dans le tableau
        // Affiche un message si aucune ligne n'est sélectionnée
        private Prets ObtenirPretSelectionne()
        {
            // Vérifie si une ligne est sélectionnée
            if (tableauDesPrets.CurrentRow?.DataBoundItem is Prets pretSelectionne)
            {
                // Retourne le prêt sélectionné
                return pretSelectionne;
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un prêt.", "Aucun prêt sélectionné", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
        }


        // Applique les filtres de recherche avec LINQ (US5)
        // Filtre par nom d'emprunteur OU par montant minimum (exclusif)
        private void AppliquerFiltre()
        {
            // Récupère la liste actuelle des prêts déjà chargée dans le BindingSource
            var liste = ((List<Prets>)sourceDonnees.DataSource).ToList();

            // Récupère les valeurs saisies par l'utilisateur pour filtrer
            string recherche = champRechercherEmprunteur.Text?.Trim() ?? string.Empty;
            double montantMin = (double)champMontantMinimumPret.Value;

            // Commence avec l'ensemble complet des prêts
            IEnumerable<Prets> filtre = liste;

            // Si l'utilisateur a saisi un nom d'emprunteur
            if (!string.IsNullOrWhiteSpace(recherche))
            {
                // Filtre les prêts dont le nom contient la chaîne recherchée (insensible à la casse)
                filtre = filtre.Where(p => (p.NomEmprunteur ?? string.Empty)
                    .IndexOf(recherche, StringComparison.OrdinalIgnoreCase) >= 0);
            }
            // Sinon, si un montant minimum est renseigné
            else if (montantMin > 0)
            {
                // Filtre les prêts dont le montant est supérieur ou égal au montant minimum
                filtre = filtre.Where(p => p.Montant >= montantMin);
            }

            // Tri les résultats par nom d'emprunteur pour une meilleure lisibilité
            filtre = filtre.OrderBy(p => p.NomEmprunteur);

            // Met à jour la source du tableaDesPrets avec la liste filtrée
            sourceDonnees.DataSource = filtre.ToList();
            tableauDesPrets.Refresh(); // Rafraîchit l'affichage
        }



        // Gère l'exclusivité des champs de recherche
        // Si un champ est utilisé, l'autre est désactivé pour éviter les conflits
        private void MettreAJourEtatChampsRecherche()
        {
            // Si on saisie dans le "champ Nom Emprunteur" alors on désactive le "champ Montant minimum"
            champRechercherEmprunteur.TextChanged += (s, e) =>
            {
                if (!string.IsNullOrWhiteSpace(champRechercherEmprunteur.Text))
                    champMontantMinimumPret.Enabled = false;
                else
                    champMontantMinimumPret.Enabled = true;
            };

            // Si on saisie dans le champ "champ Montant minimum"  alors on désactive le "champ Nom Emprunteur"
            champMontantMinimumPret.ValueChanged += (s, e) =>
            {
                if (champMontantMinimumPret.Value > 0)
                    champRechercherEmprunteur.Enabled = false;
                else
                    champRechercherEmprunteur.Enabled = true;
            };

            // Le bouton Rechercher applique le filtre actif
            btnRechercher.Click += (s, e) => AppliquerFiltre();
        }


        // Recharge toutes les données si aucun filtre n'est actif
        private void btnRechercher_Click(object sender, EventArgs e)
        {
            var nom = champRechercherEmprunteur.Text?.Trim();
            var montant = (double)champMontantMinimumPret.Value;

            if (string.IsNullOrEmpty(nom) && montant == 0)
            {
                // Aucun filtre actif → recharge tous les prêts
                ChargerDonnees();
            }
            else
            {
                // Applique le filtre saisi
                AppliquerFiltre();
            }
        }


        // Réinitialise tous les filtres et recharge l'intégralité des données dans le tableau
        private void RafraichirTableau()
        {
            // Réinitialisation des champs de recherche
            champRechercherEmprunteur.Text = string.Empty;
            champMontantMinimumPret.Value = 0;

            // Rechargement complet depuis la persistance
            ChargerDonnees();

            // Réactivation de tous les champs
            champRechercherEmprunteur.Enabled = true;
            champMontantMinimumPret.Enabled = true;
        }


        // Ouvre le formulaire d'ajout d'un nouveau prêt 
        // Sauvegarde le prêt si l'utilisateur confirme
        private void AjouterPret()
        {
            var formulairePret = new FormulairePret();
            if (formulairePret.ShowDialog() == DialogResult.OK)
            {
                service.Ajouter(formulairePret.Prets);
                ChargerDonnees();
            }
        }


        // Ouvre le formulaire de modification du prêt sélectionné
        // Met à jour les données si l'utilisateur confirme
        private void ModifierPret()
        {
            var pretSelectionne = ObtenirPretSelectionne();
            if (pretSelectionne == null) return;

            var formulairePret = new FormulairePret(pretSelectionne);
            if (formulairePret.ShowDialog() == DialogResult.OK)
            {
                service.Modifier(formulairePret.Prets);
                ChargerDonnees();
            }
        }


        // Supprime le prêt sélectionné après confirmation
        private void SupprimerPret()
        {
            var pretSelectionne = ObtenirPretSelectionne();
            if (pretSelectionne == null) return;

            // Demande de confirmation avant suppression
            var confirmation = MessageBox.Show(
                $"Êtes-vous sûr de vouloir supprimer le prêt de {pretSelectionne.NomEmprunteur} ?",
                "Confirmer la suppression",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            // Si l'utilisateur confirme, suppression du prêt
            if (confirmation == DialogResult.Yes)
            {
                service.Supprimer(pretSelectionne.Id);
                ChargerDonnees();
            }
        }


        // Génère et affiche l'échéancier détaillé du prêt sélectionné 
        private void AfficherEcheancier()
        {
            // Récupération du prêt sélectionné
            var pretSelectionne = ObtenirPretSelectionne();
            if (pretSelectionne == null) return;

            // Génération de la liste des échéances
            var echeancier = pretSelectionne.GenererEcheancier();

            // Ouverture du formulaire d'affichage de l'échéancier
            var formulaireEcheancier = new FormulaireEcheancier(echeancier, pretSelectionne);
            formulaireEcheancier.ShowDialog();
        }


        // Exporte l'échéancier du prêt sélectionné au format CSV
        private void ExporterEcheancierCSV()
        {
            var pretSelectionne = ObtenirPretSelectionne();
            if (pretSelectionne == null) return;

            // Boîte de dialogue pour choisir l'emplacement du fichier CSV
            using (var dialogueEnregistrement = new SaveFileDialog())
            {
                dialogueEnregistrement.Filter = "Fichiers CSV (*.csv)|*.csv";
                dialogueEnregistrement.FileName = $"Echeancier_{pretSelectionne.NomEmprunteur}.csv";

                // Si l'utilisateur confirme l'emplacement
                if (dialogueEnregistrement.ShowDialog() == DialogResult.OK)
                {
                    // Récupére le chemin du fichier et génére l'échéancier avec l'extension CSV
                    var cheminFichier = dialogueEnregistrement.FileName;
                    var écheancier = pretSelectionne.GenererEcheancier();

                    // Export via le service dédié
                    ExporterFichierCSV.ExporterEcheancier(écheancier, cheminFichier);

                    // Message de confirmation de l'exportation de l'échéancier
                    MessageBox.Show(
                        "L'échéancier a été exporté avec succès.",
                        "Exportation réussie",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
        }
    }
}
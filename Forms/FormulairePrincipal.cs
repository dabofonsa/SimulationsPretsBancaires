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
    public partial class FormulairePrincipal : Form
    {
        private readonly PersistancePretsJson service;
        //private BindingSource sourceDonnees = new BindingSource();

        public FormulairePrincipal()
        {
            InitializeComponent(); // Initialise tous les composants créés par le Designer
            service = new PersistancePretsJson();
            ChargerDonnees();

            Text = "Gestion des Prêts Bancaires";
            Width = 800;
            Height = 600;
            StartPosition = FormStartPosition.CenterScreen;

            // Lier les événements aux méthodes
            btnAjouterPret.Click += (s, e) => AjouterPret();
            btnModifierPret.Click += (s, e) => ModifierPret();
            btnSupprimerPret.Click += (s, e) => SupprimerPret();
       
            champRechercherEmprunteur.TextChanged += (s, e) => AppliquerFiltre();
            champMontantMinimumPret.ValueChanged += (s, e) => AppliquerFiltre();

            btnAfficherEcheancier.Click += (s, e) => AfficherEcheancier();
            btnExporterEcheancierCSV.Click += (s, e) => ExporterEcheancierCSV();

        }

            private void ChargerDonnees()
            {
            var prets = service.RecupererTous();
            sourceDonnees.DataSource = prets;
            tableauDesPrets.DataSource = sourceDonnees;
            AppliquerFiltre();

            foreach (var pret in prets)
            {
                pret.Mensualite = CalculateurPret.CalculerMensualite(pret.Montant, pret.TauxAnnuel, pret.DureeMois);
            }
            sourceDonnees.DataSource = prets;

        }

        private Prets ObtenirPretSelectionne()
        {
            if (tableauDesPrets.CurrentRow?.DataBoundItem is Prets pretSelectionne)
            {
                return pretSelectionne;
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un prêt.", "Aucun prêt sélectionné", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
        }


        //private void AppliquerFiltre()
        //{
        //    var filtreEmprunteur = champRechercherEmprunteur.Text.ToLower();
        //    var montantMinimum = champMontantMinimumPret.Value;
        //    var pretsFiltres = service.RecupererTous().Where(pret =>
        //        pret.NomEmprunteur.ToLower().Contains(filtreEmprunteur) &&
        //        pret.Montant >= montantMinimum).ToList();
        //    sourceDonnees.DataSource = pretsFiltres;
        //    tableauDePrets.Refresh();

        //}


        private void AppliquerFiltre()
        {
            IEnumerable<Prets> liste = service.RecupererTous();
            string recherche = champRechercherEmprunteur.Text?.Trim() ?? string.Empty;
            double montantMin = (double)champMontantMinimumPret.Value;

            var filtre = liste.Where(p => (p.NomEmprunteur ?? string.Empty).IndexOf(recherche, StringComparison.OrdinalIgnoreCase) >= 0)
                              .Where(p => p.Montant >= montantMin)
                              .OrderBy(p => p.NomEmprunteur)
                              .ToList();

            sourceDonnees.DataSource = filtre;
            tableauDesPrets.Refresh();
        }

        private void AjouterPret()
        {
            var formulairePret = new FormulairePret();
            if (formulairePret.ShowDialog() == DialogResult.OK)
            {
                service.Ajouter(formulairePret.Prets);
                ChargerDonnees();
            }
        }

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

        private void SupprimerPret()
        {
            var pretSelectionne = ObtenirPretSelectionne();
            if (pretSelectionne == null) return;

            var confirmation = MessageBox.Show($"Êtes-vous sûr de vouloir supprimer le prêt de {pretSelectionne.NomEmprunteur} ?",
                                               "Confirmer la suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmation == DialogResult.Yes)
            {
                service.Supprimer(pretSelectionne.Id);
                ChargerDonnees();
            }
        }

        private void AfficherEcheancier()
        {
            var pretSelectionne = ObtenirPretSelectionne();
            if (pretSelectionne == null) return;

            // 🔹 Génère la liste des échéances à partir du prêt
            var echeancier = pretSelectionne.GenererEcheancier();

            // 🔹 Ouvre le formulaire avec les données
            var formulaireEcheancier = new FormulaireEcheancier(echeancier, pretSelectionne);
            formulaireEcheancier.ShowDialog();
        }


        private void ExporterEcheancierCSV()
        {
            var pretSelectionne = ObtenirPretSelectionne();
            if (pretSelectionne == null) return;

            using (var dialogueEnregistrement = new SaveFileDialog())
            {
                dialogueEnregistrement.Filter = "Fichiers CSV (*.csv)|*.csv";
                dialogueEnregistrement.FileName = $"Echeancier_{pretSelectionne.NomEmprunteur}.csv";
                if (dialogueEnregistrement.ShowDialog() == DialogResult.OK)
                {
                    var cheminFichier = dialogueEnregistrement.FileName;
                    var échéancier = pretSelectionne.GenererEcheancier();
                    ExporterFichierCSV.ExporterEcheancier(échéancier, cheminFichier);
                    MessageBox.Show("L'échéancier a été exporté avec succès.", "Exportation réussie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}

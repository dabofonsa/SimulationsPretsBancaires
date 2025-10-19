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
            service = new PersistancePretsJson();
            Text = "Gestion des Prêts Bancaires";
            Width = 800;
            Height = 600;
            StartPosition = FormStartPosition.CenterScreen;

            InitializeComponent(); // Initialise tous les composants créés dans le design
            ChargerDonnees();

            // Lier les événements aux méthodes
            btnAjouterPret.Click += (s, e) => AjouterPret();
            btnModifierPret.Click += (s, e) => ModifierPret();
            btnSupprimerPret.Click += (s, e) => SupprimerPret();
            champRechercherEmprunteur.TextChanged += (s, e) => AppliquerFiltre();
            champMontantMinimumPret.ValueChanged += (s, e) => AppliquerFiltre();

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
            if (tableauDesPrets.CurrentRow?.DataBoundItem is Prets pretSelectionne)
            {
                var formulairePret = new FormulairePret(pretSelectionne);
                if (formulairePret.ShowDialog() == DialogResult.OK)
                {
                    service.Modifier(formulairePret.Prets);
                    ChargerDonnees();
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un prêt à modifier.", "Aucun prêt sélectionné", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void SupprimerPret()
        {
            if (tableauDesPrets.CurrentRow?.DataBoundItem is Prets pretSelectionne)
            {
                var confirmation = MessageBox.Show($"Êtes-vous sûr de vouloir supprimer le prêt de {pretSelectionne.NomEmprunteur} ?", "Confirmer la suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmation == DialogResult.Yes)
                {
                    service.Supprimer(pretSelectionne.Id);
                    ChargerDonnees();
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un prêt à supprimer.", "Aucun prêt sélectionné", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

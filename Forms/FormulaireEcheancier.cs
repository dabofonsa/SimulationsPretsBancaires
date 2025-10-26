using SimulationsPretsBancaires.Models;
using SimulationsPretsBancaires.Services;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace SimulationsPretsBancaires.Forms
{
    // Formulaire affichant l'échéancier d'un prêt et permettant l'export en CSV
    public partial class FormulaireEcheancier : Form
    {
        private List<Echeance> echeancier;  // Liste des échéances à afficher
        private Prets pret;                  // Prêt correspondant à l'échéancier
        private Prets pretSelectionne;       // Prêt sélectionné (optionnel)

        // Constructeur avec juste le prêt (non utilisé pour affichage)
        public FormulaireEcheancier(Prets pretSelectionne)
        {
            this.pretSelectionne = pretSelectionne;
        }

        // Constructeur principal : initialise le formulaire avec l'échéancier
        public FormulaireEcheancier(List<Echeance> echeancierPret, Prets pretSelectionne)
        {
            InitializeComponent(); // Initialise les composants du Designer

            echeancier = echeancierPret ?? new List<Echeance>();
            pret = pretSelectionne;

            //  Configuration de la fenêtre et Titre 
            Text = $"Échéancier et courbe d'évolurion du capital restant dû de l'Emprunteur: {pret.NomEmprunteur}";
            Width = 1350;
            Height = 750;
            StartPosition = FormStartPosition.CenterScreen;

            // Mettre à jour le label avec le nom de l’emprunteur
            labelTitreEcheancier.Text = $"Voici l'échéancier de l'emprunteur : {pret.NomEmprunteur}";
            // Mettre à jour le label avec le nom de l’emprunteur
            labelCourbe.Text = $"Courbe d'évolution du capital restant dû de l'emprunteur : {pret.NomEmprunteur}";      

            // Lier les boutons aux actions
            btnValiderExportCSV.Click += (s, e) => ExporterCSV();
            btnFermerCSV.Click += (s, e) => Close();

            ChargerEcheancier();
            DessinerGraphique();

            // Mettre la fenêtre en plein écran
            WindowState = FormWindowState.Maximized;
        }

        // Charge les données dans le DataGridView ( tableauDEcheancier )
        private void ChargerEcheancier()
        {
            // Réinitialise la source de données pour forcer le rafraîchissement
            tableauDEcheancier.DataSource = null;
            tableauDEcheancier.DataSource = echeancier;

        }

        // Méthode pour exporter l'échéancier en CSV
        private void ExporterCSV()
        {
            // Ouvre une boîte de dialogue pour choisir l'emplacement du fichier
            using var sfd = new SaveFileDialog
            {
                // Filtre pour fichiers CSV
                Filter = "Fichiers CSV (*.csv)|*.csv",
                FileName = $"echeancier_pret_{pret.Id}.csv"
            };

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                // Utilise le service d'exportation pour sauvegarder le fichier
                try
                {
                    // Appel au service d'exportation CSV
                    ExporterFichierCSV.ExporterEcheancier(echeancier, sfd.FileName);
                    // Affiche un message de succès
                    MessageBox.Show($"Export CSV effectué : {sfd.FileName}", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                // Gestion des erreurs lors de l'exportation
                catch (Exception ex)
                {
                    // Affiche un message d'erreur en cas d'échec
                    MessageBox.Show($"Erreur lors de l’export CSV : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //Méthode optionnelle pour dessiner un graphique(non utilisée)

        private void DessinerGraphique()
        {
            // Vérifie que la liste de l’échéancier n’est pas vide
            if (echeancier == null || echeancier.Count == 0)
                return;

            // Nettoyer le graphique avant de le redessiner
            courbeCapitalRestant.Series.Clear();

            // Créer une nouvelle série pour le graphique
            var serie = new Series("Capital restant dû")
            {
                ChartType = SeriesChartType.Line,
                BorderWidth = 2,
                Color = System.Drawing.Color.RoyalBlue
            };

            // Ajouter les points (échéance -> capital restant dû)
            foreach (var e in echeancier)
            {
                serie.Points.AddXY(e.NumeroEcheance, e.ResteDu);
            }

            // Ajouter la série au graphique
            courbeCapitalRestant.Series.Add(serie);

            // Configuration des axes
            var zone = courbeCapitalRestant.ChartAreas[0];
            zone.AxisX.Title = "Numéro d’échéance (mois)";
            zone.AxisY.Title = "Capital restant dû (€)";
            zone.AxisX.MajorGrid.LineColor = System.Drawing.Color.LightGray;
            zone.AxisY.MajorGrid.LineColor = System.Drawing.Color.LightGray;

            // Ajouter un titre clair
            courbeCapitalRestant.Titles.Clear();
            courbeCapitalRestant.Titles.Add("Évolution du capital restant dû");
        }       

    }
}

using SimulationsPretsBancaires.Models;
using SimulationsPretsBancaires.Services;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

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
            Text = $"Échéancier de l'Emprunteur {pret.NomEmprunteur}";
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
            //DessinerGraphique(); // Option pour graphique futur
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

        // Méthode optionnelle pour dessiner un graphique (non utilisée)
        //private void DessinerGraphique()
        //{
        //    graphique.Series.Clear();
        //
        //    var serie = new Series("Capital restant dû")
        //    {
        //        ChartType = SeriesChartType.Line,
        //        XValueType = ChartValueType.Int32,
        //        YValueType = ChartValueType.Double,
        //        BorderWidth = 2
        //    };
        //
        //    foreach (var e in echeancier)
        //    {
        //        serie.Points.AddXY(e.Numero, e.ResteDu);
        //    }
        //
        //    graphique.Series.Add(serie);
        //
        //    if (graphique.ChartAreas.Count == 0)
        //        graphique.ChartAreas.Add(new ChartArea("Principale"));
        //
        //    var zone = graphique.ChartAreas[0];
        //    zone.AxisX.Title = "Échéance (mois)";
        //    zone.AxisY.Title = "Capital restant dû (€)";
        //    zone.AxisX.Interval = 1;
        //}
    }
}

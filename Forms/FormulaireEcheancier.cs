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
    public partial class FormulaireEcheancier : Form
    {
        private List<Echeance> echeancier;
        private Prets pret;
        private Prets pretSelectionne;

        public FormulaireEcheancier(Prets pretSelectionne)
        {
            this.pretSelectionne = pretSelectionne;
        }

        public FormulaireEcheancier(List<Echeance> echeancierPret, Prets pretSelectionne)
        {
            InitializeComponent(); // 🔹 Appelle les éléments créés dans le Designer

            echeancier = echeancierPret ?? new List<Echeance>();
            pret = pretSelectionne;

            Text = $"Échéancier - {pret.NomEmprunteur}";
            StartPosition = FormStartPosition.CenterParent;

            // Événements des boutons
            btnValiderExportCSV.Click += (s, e) => ExporterCSV();
            btnFermerCSV.Click += (s, e) => Close();

            ChargerEcheancier();
            //DessinerGraphique();
        }

        private void ChargerEcheancier()
        {
            //tableauDEcheancier.AutoGenerateColumns = false;
            tableauDEcheancier.DataSource = null;
            tableauDEcheancier.DataSource = echeancier;

        }

       

        private void ExporterCSV()
        {
            using var sfd = new SaveFileDialog
            {
                Filter = "Fichiers CSV (*.csv)|*.csv",
                FileName = $"echeancier_pret_{pret.Id}.csv"
            };

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ExporterFichierCSV.ExporterEcheancier(echeancier, sfd.FileName);
                    MessageBox.Show($"Export CSV effectué : {sfd.FileName}", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erreur lors de l’export CSV : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}

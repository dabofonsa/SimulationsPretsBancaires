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
    internal partial class FormulairePret : Form
    {
        public Prets Prets { get; private set; }
        public FormulairePret( Prets pret = null )
        {
            InitializeComponent();

            Prets = pret != null
                ? new Prets
                {
                    Id = pret.Id,
                    NomEmprunteur = pret.NomEmprunteur,
                    Montant = pret.Montant,
                    TauxAnnuel = pret.TauxAnnuel,
                    DureeMois = pret.DureeMois,
                    DateDebut = pret.DateDebut
                }
                : new Prets { DateDebut = DateTime.Today };

            Text = pret == null ? "Ajouter un prêt" : "Modifier un prêt";

            ChargerDepuisModele();
            MettreAJourMensualite();

            // Attachements d’événements (optionnel si tu ne les as pas faits via le Designer)
            numMontant.ValueChanged += (s, e) => MettreAJourMensualite();
            numTauxAnnuel.ValueChanged += (s, e) => MettreAJourMensualite();
            numDuree.ValueChanged += (s, e) => MettreAJourMensualite();
            btnValider.Click += (s, e) => ValiderEtFermer();
            btnAnnuler.Click += (s, e) => DialogResult = DialogResult.Cancel;
        }

        // C#
        private void ChargerDepuisModele()
        {
            txtEmprunteur.Text = Prets.NomEmprunteur ?? string.Empty;

            decimal montant = (decimal)Prets.Montant;
            if (montant < numMontant.Minimum) montant = numMontant.Minimum;
            if (montant > numMontant.Maximum) montant = numMontant.Maximum;
            numMontant.Value = montant;

            numTauxAnnuel.Value = (decimal)Prets.TauxAnnuel;
            numDuree.Value = Prets.DureeMois == 0 ? 12 : Prets.DureeMois;
            dateDeDebut.Value = Prets.DateDebut == default ? DateTime.Today : Prets.DateDebut;
        }

        private void MettreAJourMensualite()
        {
            double montant = (double)numMontant.Value;
            double taux = (double)numTauxAnnuel.Value;
            int duree = (int)numDuree.Value;
            double mensualite = CalculateurPret.CalculerMensualite(montant, taux, duree);
            valeurMensualite.Text = mensualite.ToString("N2");
        }

        private void ValiderEtFermer()
        {
            if (string.IsNullOrWhiteSpace(txtEmprunteur.Text))
            {
                MessageBox.Show("Nom Emprunteur requis.");
                return;
            }

            if (numMontant.Value <= 0)
            {
                MessageBox.Show("Montant doit être supérieur à 0.");
                return;
            }

            if (numDuree.Value < 1)
            {
                MessageBox.Show("Durée doit être supérieur ou égal à 1.");
                return;
            }

            if (numTauxAnnuel.Value < 0)
            {
                MessageBox.Show("Taux doit être supérieur ou égal à 0.");
                return;
            }

            Prets.NomEmprunteur = txtEmprunteur.Text.Trim();
            Prets.Montant = (double)numMontant.Value;
            Prets.TauxAnnuel = (double)numTauxAnnuel.Value;
            Prets.DureeMois = (int)numDuree.Value;
            Prets.DateDebut = dateDeDebut.Value.Date;

            // ✅ Ajout de cette ligne pour stocker la mensualité dans l'objet
            Prets.Mensualite = CalculateurPret.CalculerMensualite(
                Prets.Montant,
                Prets.TauxAnnuel,
                Prets.DureeMois
            );

            Prets.NomEmprunteur = txtEmprunteur.Text.Trim();
            Prets.Montant = (double)numMontant.Value;
            Prets.TauxAnnuel = (double)numTauxAnnuel.Value;
            Prets.DureeMois = (int)numDuree.Value;
            Prets.DateDebut = dateDeDebut.Value.Date;

            DialogResult = DialogResult.OK;
        }
    }
}

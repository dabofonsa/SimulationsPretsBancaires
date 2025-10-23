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
    // Formulaire pour créer, modifier ou supprimer un prêt
    internal partial class FormulairePret : Form
    {
        // Propriété représentant le prêt manipulé
        public Prets Prets { get; private set; }

        // Constructeur : initialise le formulaire et charge les valeurs du prêt s'il existe
        public FormulairePret(Prets pret = null)
        {
            InitializeComponent();


            // Si un prêt est passé en paramètre, créer une copie pour modification
            // Sinon, créer un nouveau prêt avec la date du jour
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

            //  Configuration de la fenêtre et Titre du formulaire selon l'action
            Text = pret == null ? "Ajouter un prêt" : "Modifier un prêt";
            Width = 700;
            Height = 600;
            StartPosition = FormStartPosition.CenterScreen;

            // Remplit les champs du formulaire avec les données du modèle
            ChargerDepuisModele();

            // Calcule la mensualité au démarrage
            MettreAJourMensualite();

            // Liaison des événements aux contrôles
            numMontant.ValueChanged += (s, e) => MettreAJourMensualite();
            numTauxAnnuel.ValueChanged += (s, e) => MettreAJourMensualite();
            numDuree.ValueChanged += (s, e) => MettreAJourMensualite();
            btnValider.Click += (s, e) => ValiderEtFermer();
            btnAnnuler.Click += (s, e) => DialogResult = DialogResult.Cancel;
        }

        // Remplit les champs du formulaire à partir de l’objet Prets
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


        // Calcule et affiche la mensualité selon les valeurs entrées
        private void MettreAJourMensualite()
        {
            double montant = (double)numMontant.Value;
            double taux = (double)numTauxAnnuel.Value;
            int duree = (int)numDuree.Value;
            double mensualite = CalculateurPret.CalculerMensualite(montant, taux, duree);
            valeurMensualite.Text = mensualite.ToString("N2");
        }


        // Vérifie la validité des données et ferme le formulaire si tout est correct
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
                MessageBox.Show("Durée doit être supérieure ou égale à 1.");
                return;
            }

            if (numTauxAnnuel.Value < 0)
            {
                MessageBox.Show("Taux doit être supérieur ou égal à 0.");
                return;
            }

            // Mise à jour des propriétés du prêt avec les valeurs saisies
            Prets.NomEmprunteur = txtEmprunteur.Text.Trim();
            Prets.Montant = (double)numMontant.Value;
            Prets.TauxAnnuel = (double)numTauxAnnuel.Value;
            Prets.DureeMois = (int)numDuree.Value;
            Prets.DateDebut = dateDeDebut.Value.Date;

            // Calcul et stockage de la mensualité dans le modèle
            Prets.Mensualite = CalculateurPret.CalculerMensualite(
                Prets.Montant,
                Prets.TauxAnnuel,
                Prets.DureeMois
            );

            // Ferme le formulaire avec succès
            DialogResult = DialogResult.OK;
        }
    }
}

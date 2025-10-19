using SimulationsPretsBancaires.Services;
using System;
using System.Linq;
namespace SimulationsPretsBancaires.Forms
{
    partial class FormulairePrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing && (components != null))
        //    {
        //        components.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            tableauDesPrets = new DataGridView();
            champRechercherEmprunteur = new TextBox();
            champMontantMinimumPret = new NumericUpDown();
            btnAjouterPret = new Button();
            btnModifierPret = new Button();
            btnSupprimerPret = new Button();
            btnAfficherEcheancier = new Button();
            btnExporterEcheancierCSV = new Button();
            sourceDonnees = new BindingSource(components);
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            Id = new DataGridViewTextBoxColumn();
            NomEmprunteur = new DataGridViewTextBoxColumn();
            Montant = new DataGridViewTextBoxColumn();
            TauxAnnuel = new DataGridViewTextBoxColumn();
            DureeMois = new DataGridViewTextBoxColumn();
            DateDebut = new DataGridViewTextBoxColumn();
            Mensualite = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)tableauDesPrets).BeginInit();
            ((System.ComponentModel.ISupportInitialize)champMontantMinimumPret).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sourceDonnees).BeginInit();
            SuspendLayout();
            // 
            // tableauDesPrets
            // 
            tableauDesPrets.AllowUserToOrderColumns = true;
            tableauDesPrets.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableauDesPrets.Columns.AddRange(new DataGridViewColumn[] { Id, NomEmprunteur, Montant, TauxAnnuel, DureeMois, DateDebut, Mensualite });
            tableauDesPrets.Location = new Point(12, 145);
            tableauDesPrets.Name = "tableauDesPrets";
            tableauDesPrets.RowHeadersWidth = 51;
            tableauDesPrets.Size = new Size(944, 307);
            tableauDesPrets.TabIndex = 0;
            // 
            // champRechercherEmprunteur
            // 
            champRechercherEmprunteur.Location = new Point(45, 96);
            champRechercherEmprunteur.Name = "champRechercherEmprunteur";
            champRechercherEmprunteur.PlaceholderText = "Entrez le nom du emprunteur";
            champRechercherEmprunteur.Size = new Size(234, 27);
            champRechercherEmprunteur.TabIndex = 1;
            // 
            // champMontantMinimumPret
            // 
            champMontantMinimumPret.Location = new Point(312, 96);
            champMontantMinimumPret.Name = "champMontantMinimumPret";
            champMontantMinimumPret.Size = new Size(147, 27);
            champMontantMinimumPret.TabIndex = 3;
            // 
            // btnAjouterPret
            // 
            btnAjouterPret.Location = new Point(546, 94);
            btnAjouterPret.Name = "btnAjouterPret";
            btnAjouterPret.Size = new Size(116, 29);
            btnAjouterPret.TabIndex = 4;
            btnAjouterPret.Text = "Ajouter";
            btnAjouterPret.UseVisualStyleBackColor = true;
            // 
            // btnModifierPret
            // 
            btnModifierPret.Location = new Point(690, 94);
            btnModifierPret.Name = "btnModifierPret";
            btnModifierPret.Size = new Size(94, 29);
            btnModifierPret.TabIndex = 5;
            btnModifierPret.Text = "Modifier";
            btnModifierPret.UseVisualStyleBackColor = true;
            // 
            // btnSupprimerPret
            // 
            btnSupprimerPret.Location = new Point(817, 94);
            btnSupprimerPret.Name = "btnSupprimerPret";
            btnSupprimerPret.Size = new Size(94, 29);
            btnSupprimerPret.TabIndex = 6;
            btnSupprimerPret.Text = "Supprimer";
            btnSupprimerPret.UseVisualStyleBackColor = true;
            // 
            // btnAfficherEcheancier
            // 
            btnAfficherEcheancier.Location = new Point(27, 530);
            btnAfficherEcheancier.Name = "btnAfficherEcheancier";
            btnAfficherEcheancier.Size = new Size(94, 29);
            btnAfficherEcheancier.TabIndex = 7;
            btnAfficherEcheancier.Text = "Echeancier";
            btnAfficherEcheancier.UseVisualStyleBackColor = true;
            // 
            // btnExporterEcheancierCSV
            // 
            btnExporterEcheancierCSV.Location = new Point(194, 530);
            btnExporterEcheancierCSV.Name = "btnExporterEcheancierCSV";
            btnExporterEcheancierCSV.Size = new Size(127, 29);
            btnExporterEcheancierCSV.TabIndex = 8;
            btnExporterEcheancierCSV.Text = "Exporter CSV";
            btnExporterEcheancierCSV.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 67);
            label1.Name = "label1";
            label1.Size = new Size(131, 20);
            label1.TabIndex = 9;
            label1.Text = "Nom Empreuntuer";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(312, 67);
            label2.Name = "label2";
            label2.Size = new Size(65, 20);
            label2.TabIndex = 10;
            label2.Text = "Montant";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(45, 26);
            label3.Name = "label3";
            label3.Size = new Size(304, 20);
            label3.TabIndex = 11;
            label3.Text = "Rechercher par nom emprunteur ou montant";
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "Identifiant";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.Width = 125;
            // 
            // NomEmprunteur
            // 
            NomEmprunteur.DataPropertyName = "NomEmprunteur";
            NomEmprunteur.HeaderText = "Nom Emprunteur";
            NomEmprunteur.MinimumWidth = 6;
            NomEmprunteur.Name = "NomEmprunteur";
            NomEmprunteur.Width = 125;
            // 
            // Montant
            // 
            Montant.DataPropertyName = "Montant";
            Montant.HeaderText = "Montant";
            Montant.MinimumWidth = 6;
            Montant.Name = "Montant";
            Montant.Width = 125;
            // 
            // TauxAnnuel
            // 
            TauxAnnuel.DataPropertyName = "TauxAnnuel";
            TauxAnnuel.HeaderText = "Taux (%)";
            TauxAnnuel.MinimumWidth = 6;
            TauxAnnuel.Name = "TauxAnnuel";
            TauxAnnuel.Width = 125;
            // 
            // DureeMois
            // 
            DureeMois.DataPropertyName = "DureeMois";
            DureeMois.HeaderText = "Durée (Mois)";
            DureeMois.MinimumWidth = 6;
            DureeMois.Name = "DureeMois";
            DureeMois.Width = 125;
            // 
            // DateDebut
            // 
            DateDebut.DataPropertyName = "DateDebut";
            DateDebut.HeaderText = "Date de début";
            DateDebut.MinimumWidth = 6;
            DateDebut.Name = "DateDebut";
            DateDebut.Width = 125;
            // 
            // Mensualite
            // 
            Mensualite.DataPropertyName = "Mensualite";
            Mensualite.HeaderText = "Mensualité";
            Mensualite.MinimumWidth = 6;
            Mensualite.Name = "Mensualite";
            Mensualite.Width = 125;
            // 
            // FormulairePrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(976, 584);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnExporterEcheancierCSV);
            Controls.Add(btnAfficherEcheancier);
            Controls.Add(btnSupprimerPret);
            Controls.Add(btnModifierPret);
            Controls.Add(btnAjouterPret);
            Controls.Add(champMontantMinimumPret);
            Controls.Add(champRechercherEmprunteur);
            Controls.Add(tableauDesPrets);
            Name = "FormulairePrincipal";
            Text = "FormulaireEcheancier";
            ((System.ComponentModel.ISupportInitialize)tableauDesPrets).EndInit();
            ((System.ComponentModel.ISupportInitialize)champMontantMinimumPret).EndInit();
            ((System.ComponentModel.ISupportInitialize)sourceDonnees).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView tableauDesPrets;
        private TextBox champRechercherEmprunteur;
        private NumericUpDown champMontantMinimumPret;
        private Button btnAjouterPret;
        private Button btnModifierPret;
        private Button btnSupprimerPret;
        private Button btnAfficherEcheancier;
        private Button btnExporterEcheancierCSV;
        private BindingSource sourceDonnees = new BindingSource();
        private Label label1;
        private Label label2;
        private Label label3;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn NomEmprunteur;
        private DataGridViewTextBoxColumn Montant;
        private DataGridViewTextBoxColumn TauxAnnuel;
        private DataGridViewTextBoxColumn DureeMois;
        private DataGridViewTextBoxColumn DateDebut;
        private DataGridViewTextBoxColumn Mensualite;
    }
}
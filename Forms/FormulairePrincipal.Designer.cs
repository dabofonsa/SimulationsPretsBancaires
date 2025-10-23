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
            Id = new DataGridViewTextBoxColumn();
            NomEmprunteur = new DataGridViewTextBoxColumn();
            Montant = new DataGridViewTextBoxColumn();
            TauxAnnuel = new DataGridViewTextBoxColumn();
            DureeMois = new DataGridViewTextBoxColumn();
            DateDebut = new DataGridViewTextBoxColumn();
            Mensualite = new DataGridViewTextBoxColumn();
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
            btnRechercher = new Button();
            btnRafraichirTableau = new Button();
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
            tableauDesPrets.Location = new Point(21, 230);
            tableauDesPrets.Name = "tableauDesPrets";
            tableauDesPrets.RowHeadersWidth = 51;
            tableauDesPrets.Size = new Size(1015, 417);
            tableauDesPrets.TabIndex = 0;
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
            NomEmprunteur.Width = 130;
            // 
            // Montant
            // 
            Montant.DataPropertyName = "Montant";
            Montant.HeaderText = "Montant Emprunté";
            Montant.MinimumWidth = 6;
            Montant.Name = "Montant";
            Montant.Width = 130;
            // 
            // TauxAnnuel
            // 
            TauxAnnuel.DataPropertyName = "TauxAnnuel";
            TauxAnnuel.HeaderText = "Taux Annuel (%)";
            TauxAnnuel.MinimumWidth = 6;
            TauxAnnuel.Name = "TauxAnnuel";
            TauxAnnuel.Width = 130;
            // 
            // DureeMois
            // 
            DureeMois.DataPropertyName = "DureeMois";
            DureeMois.HeaderText = "Durée (Mois)";
            DureeMois.MinimumWidth = 6;
            DureeMois.Name = "DureeMois";
            DureeMois.Width = 130;
            // 
            // DateDebut
            // 
            DateDebut.DataPropertyName = "DateDebut";
            DateDebut.HeaderText = "Date de début";
            DateDebut.MinimumWidth = 6;
            DateDebut.Name = "DateDebut";
            DateDebut.Width = 130;
            // 
            // Mensualite
            // 
            Mensualite.DataPropertyName = "Mensualite";
            Mensualite.HeaderText = "Mensualité";
            Mensualite.MinimumWidth = 6;
            Mensualite.Name = "Mensualite";
            Mensualite.Width = 130;
            // 
            // champRechercherEmprunteur
            // 
            champRechercherEmprunteur.Location = new Point(70, 93);
            champRechercherEmprunteur.Name = "champRechercherEmprunteur";
            champRechercherEmprunteur.PlaceholderText = "Entrez le nom du emprunteur";
            champRechercherEmprunteur.Size = new Size(234, 27);
            champRechercherEmprunteur.TabIndex = 1;
            // 
            // champMontantMinimumPret
            // 
            champMontantMinimumPret.Increment = new decimal(new int[] { 200, 0, 0, 0 });
            champMontantMinimumPret.Location = new Point(321, 93);
            champMontantMinimumPret.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            champMontantMinimumPret.Name = "champMontantMinimumPret";
            champMontantMinimumPret.Size = new Size(147, 27);
            champMontantMinimumPret.TabIndex = 3;
            // 
            // btnAjouterPret
            // 
            btnAjouterPret.Location = new Point(659, 94);
            btnAjouterPret.Name = "btnAjouterPret";
            btnAjouterPret.Size = new Size(116, 36);
            btnAjouterPret.TabIndex = 4;
            btnAjouterPret.Text = "Ajouter";
            btnAjouterPret.UseVisualStyleBackColor = true;
            // 
            // btnModifierPret
            // 
            btnModifierPret.Location = new Point(814, 93);
            btnModifierPret.Name = "btnModifierPret";
            btnModifierPret.Size = new Size(94, 37);
            btnModifierPret.TabIndex = 5;
            btnModifierPret.Text = "Modifier";
            btnModifierPret.UseVisualStyleBackColor = true;
            // 
            // btnSupprimerPret
            // 
            btnSupprimerPret.Location = new Point(942, 93);
            btnSupprimerPret.Name = "btnSupprimerPret";
            btnSupprimerPret.Size = new Size(94, 37);
            btnSupprimerPret.TabIndex = 6;
            btnSupprimerPret.Text = "Supprimer";
            btnSupprimerPret.UseVisualStyleBackColor = true;
            // 
            // btnAfficherEcheancier
            // 
            btnAfficherEcheancier.Location = new Point(57, 678);
            btnAfficherEcheancier.Name = "btnAfficherEcheancier";
            btnAfficherEcheancier.Size = new Size(210, 41);
            btnAfficherEcheancier.TabIndex = 7;
            btnAfficherEcheancier.Text = "Afficher L'Echéancier";
            btnAfficherEcheancier.UseVisualStyleBackColor = true;
            // 
            // btnExporterEcheancierCSV
            // 
            btnExporterEcheancierCSV.Location = new Point(358, 678);
            btnExporterEcheancierCSV.Name = "btnExporterEcheancierCSV";
            btnExporterEcheancierCSV.Size = new Size(223, 41);
            btnExporterEcheancierCSV.TabIndex = 8;
            btnExporterEcheancierCSV.Text = "Exporter L'Echeancier en CSV";
            btnExporterEcheancierCSV.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(70, 56);
            label1.Name = "label1";
            label1.Size = new Size(131, 20);
            label1.TabIndex = 9;
            label1.Text = "Nom Empreuntuer";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(321, 56);
            label2.Name = "label2";
            label2.Size = new Size(132, 20);
            label2.TabIndex = 10;
            label2.Text = "Montant minimum";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(134, 9);
            label3.Name = "label3";
            label3.Size = new Size(699, 31);
            label3.TabIndex = 11;
            label3.Text = "Rechercher Un Prêt par \"Nom Emprunteur\" ou \"Montant Minimum\"";
            // 
            // btnRechercher
            // 
            btnRechercher.Location = new Point(512, 92);
            btnRechercher.Name = "btnRechercher";
            btnRechercher.Size = new Size(105, 38);
            btnRechercher.TabIndex = 12;
            btnRechercher.Text = "Rechercher";
            btnRechercher.UseVisualStyleBackColor = true;
            // 
            // btnRafraichirTableau
            // 
            btnRafraichirTableau.Location = new Point(466, 153);
            btnRafraichirTableau.Name = "btnRafraichirTableau";
            btnRafraichirTableau.Size = new Size(201, 40);
            btnRafraichirTableau.TabIndex = 13;
            btnRafraichirTableau.Text = "Mettre à jour le Tableau";
            btnRafraichirTableau.UseVisualStyleBackColor = true;
            // 
            // FormulairePrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1269, 745);
            Controls.Add(btnRafraichirTableau);
            Controls.Add(btnRechercher);
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
        private Button btnRechercher;
        private Button btnRafraichirTableau;
    }
}
namespace SimulationsPretsBancaires.Forms
{
    partial class FormulairePret
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelEmprunteur = new Label();
            labelMontant = new Label();
            labelTauxAnnuel = new Label();
            labelDuree = new Label();
            labelDateDebut = new Label();
            txtEmprunteur = new TextBox();
            numMontant = new NumericUpDown();
            numTauxAnnuel = new NumericUpDown();
            numDuree = new NumericUpDown();
            dateDeDebut = new DateTimePicker();
            btnValider = new Button();
            btnAnnuler = new Button();
            labelMensualite = new Label();
            valeurMensualite = new TextBox();
            ((System.ComponentModel.ISupportInitialize)numMontant).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numTauxAnnuel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numDuree).BeginInit();
            SuspendLayout();
            // 
            // labelEmprunteur
            // 
            labelEmprunteur.AutoSize = true;
            labelEmprunteur.Location = new Point(80, 39);
            labelEmprunteur.Name = "labelEmprunteur";
            labelEmprunteur.Size = new Size(123, 20);
            labelEmprunteur.TabIndex = 0;
            labelEmprunteur.Text = "Nom Emprunteur";
            // 
            // labelMontant
            // 
            labelMontant.AutoSize = true;
            labelMontant.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            labelMontant.Location = new Point(80, 94);
            labelMontant.Name = "labelMontant";
            labelMontant.Size = new Size(65, 20);
            labelMontant.TabIndex = 1;
            labelMontant.Text = "Montant (€)";
            // 
            // labelTauxAnnuel
            // 
            labelTauxAnnuel.AutoSize = true;
            labelTauxAnnuel.Location = new Point(80, 149);
            labelTauxAnnuel.Name = "labelTauxAnnuel";
            labelTauxAnnuel.Size = new Size(88, 20);
            labelTauxAnnuel.TabIndex = 2;
            labelTauxAnnuel.Text = "Taux Annuel (%)";
            // 
            // labelDuree
            // 
            labelDuree.AutoSize = true;
            labelDuree.Location = new Point(80, 204);
            labelDuree.Name = "labelDuree";
            labelDuree.Size = new Size(95, 20);
            labelDuree.TabIndex = 3;
            labelDuree.Text = "Durée (mois)";
            // 
            // labelDateDebut
            // 
            labelDateDebut.AutoSize = true;
            labelDateDebut.Location = new Point(80, 262);
            labelDateDebut.Name = "labelDateDebut";
            labelDateDebut.Size = new Size(62, 20);
            labelDateDebut.TabIndex = 4;
            labelDateDebut.Text = "Date de";
            // 
            // txtEmprunteur
            // 
            txtEmprunteur.Location = new Point(243, 36);
            txtEmprunteur.Name = "txtEmprunteur";
            txtEmprunteur.Size = new Size(321, 27);
            txtEmprunteur.TabIndex = 6;
            // 
            // numMontant
            // 
            numMontant.DecimalPlaces = 2;
            numMontant.Increment = new decimal(new int[] { 100, 0, 0, 0 });
            numMontant.Location = new Point(243, 87);
            numMontant.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            numMontant.Minimum = new decimal(new int[] { 10, 0, 0, 0 });
            numMontant.Name = "numMontant";
            numMontant.Size = new Size(150, 27);
            numMontant.TabIndex = 7;
            // 
            // numTauxAnnuel
            //            
            numTauxAnnuel.DecimalPlaces = 2;
            numTauxAnnuel.Increment = new decimal(new int[] { 1, 0, 0, 0 });
            numTauxAnnuel.Location = new Point(243, 142);
            numTauxAnnuel.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            numTauxAnnuel.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
            numTauxAnnuel.Name = "numTauxAnnuel";
            numTauxAnnuel.Size = new Size(150, 27);
            numTauxAnnuel.TabIndex = 8;
            // 
            // numDuree
            // 
            numDuree.Location = new Point(243, 197);
            numDuree.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numDuree.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numDuree.Name = "numDuree";
            numDuree.Size = new Size(150, 27);
            numDuree.TabIndex = 9;
            // 
            // dateDeDebut
            // 
            dateDeDebut.Location = new Point(243, 257);
            dateDeDebut.Name = "dateDeDebut";
            dateDeDebut.Size = new Size(264, 27);
            dateDeDebut.TabIndex = 10;
            // 
            // btnValider
            // 
            btnValider.Location = new Point(169, 375);
            btnValider.Name = "btnValider";
            btnValider.Size = new Size(94, 29);
            btnValider.TabIndex = 12;
            btnValider.Text = "Valider";
            btnValider.UseVisualStyleBackColor = true;
            // 
            // btnAnnuler
            // 
            btnAnnuler.Location = new Point(349, 375);
            btnAnnuler.Name = "btnAnnuler";
            btnAnnuler.Size = new Size(94, 29);
            btnAnnuler.TabIndex = 13;
            btnAnnuler.Text = "Annuler";
            btnAnnuler.UseVisualStyleBackColor = true;
            // 
            // labelMensualite
            // 
            labelMensualite.AutoSize = true;
            labelMensualite.Location = new Point(80, 315);
            labelMensualite.Name = "labelMensualite";
            labelMensualite.Size = new Size(81, 20);
            labelMensualite.TabIndex = 14;
            labelMensualite.Text = "Mensualité (€)";
            // 
            // valeurMensualite
            // 
            valeurMensualite.Location = new Point(243, 308);
            valeurMensualite.Name = "valeurMensualite";
            valeurMensualite.Size = new Size(150, 27);
            valeurMensualite.TabIndex = 15;
            valeurMensualite.TextAlign = HorizontalAlignment.Center;
            // 
            // FormulairePret
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(626, 450);
            Controls.Add(valeurMensualite);
            Controls.Add(labelMensualite);
            Controls.Add(btnAnnuler);
            Controls.Add(btnValider);
            Controls.Add(dateDeDebut);
            Controls.Add(numDuree);
            Controls.Add(numTauxAnnuel);
            Controls.Add(numMontant);
            Controls.Add(txtEmprunteur);
            Controls.Add(labelDateDebut);
            Controls.Add(labelDuree);
            Controls.Add(labelTauxAnnuel);
            Controls.Add(labelMontant);
            Controls.Add(labelEmprunteur);
            Name = "FormulairePret";
            Text = "FormulairePret";
            ((System.ComponentModel.ISupportInitialize)numMontant).EndInit();
            ((System.ComponentModel.ISupportInitialize)numTauxAnnuel).EndInit();
            ((System.ComponentModel.ISupportInitialize)numDuree).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelEmprunteur;
        private Label labelMontant;
        private Label labelTauxAnnuel;
        private Label labelDuree;
        private Label labelDateDebut;
        private TextBox txtEmprunteur;
        private NumericUpDown numMontant;
        private NumericUpDown numTauxAnnuel;
        private NumericUpDown numDuree;
        private DateTimePicker dateDeDebut;
        private Label labelMensualite;
        private TextBox valeurMensualite;
        private Button btnValider;
        private Button btnAnnuler;
    }
}
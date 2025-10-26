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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormulairePret));
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
            resources.ApplyResources(labelEmprunteur, "labelEmprunteur");
            labelEmprunteur.Name = "labelEmprunteur";
            // 
            // labelMontant
            // 
            resources.ApplyResources(labelMontant, "labelMontant");
            labelMontant.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            labelMontant.Name = "labelMontant";
            // 
            // labelTauxAnnuel
            // 
            resources.ApplyResources(labelTauxAnnuel, "labelTauxAnnuel");
            labelTauxAnnuel.Name = "labelTauxAnnuel";
            // 
            // labelDuree
            // 
            resources.ApplyResources(labelDuree, "labelDuree");
            labelDuree.Name = "labelDuree";
            // 
            // labelDateDebut
            // 
            resources.ApplyResources(labelDateDebut, "labelDateDebut");
            labelDateDebut.Name = "labelDateDebut";
            // 
            // txtEmprunteur
            // 
            resources.ApplyResources(txtEmprunteur, "txtEmprunteur");
            txtEmprunteur.Name = "txtEmprunteur";
            // 
            // numMontant
            // 
            resources.ApplyResources(numMontant, "numMontant");
            numMontant.DecimalPlaces = 2;
            numMontant.Increment = new decimal(new int[] { 100, 0, 0, 0 });
            numMontant.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            numMontant.Minimum = new decimal(new int[] { 10, 0, 0, 0 });
            numMontant.Name = "numMontant";
            numMontant.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // numTauxAnnuel
            // 
            resources.ApplyResources(numTauxAnnuel, "numTauxAnnuel");
            numTauxAnnuel.DecimalPlaces = 2;
            numTauxAnnuel.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            numTauxAnnuel.Name = "numTauxAnnuel";
            // 
            // numDuree
            // 
            resources.ApplyResources(numDuree, "numDuree");
            numDuree.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numDuree.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numDuree.Name = "numDuree";
            numDuree.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // dateDeDebut
            // 
            resources.ApplyResources(dateDeDebut, "dateDeDebut");
            dateDeDebut.Name = "dateDeDebut";
            // 
            // btnValider
            // 
            resources.ApplyResources(btnValider, "btnValider");
            btnValider.Name = "btnValider";
            btnValider.UseVisualStyleBackColor = true;
            // 
            // btnAnnuler
            // 
            resources.ApplyResources(btnAnnuler, "btnAnnuler");
            btnAnnuler.Name = "btnAnnuler";
            btnAnnuler.UseVisualStyleBackColor = true;
            // 
            // labelMensualite
            // 
            resources.ApplyResources(labelMensualite, "labelMensualite");
            labelMensualite.Name = "labelMensualite";
            // 
            // valeurMensualite
            // 
            resources.ApplyResources(valeurMensualite, "valeurMensualite");
            valeurMensualite.Name = "valeurMensualite";
            // 
            // FormulairePret
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
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
namespace SimulationsPretsBancaires.Forms
{
    partial class FormulaireEcheancier
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
            tableauDEcheancier = new DataGridView();
            btnValiderExportCSV = new Button();
            btnFermerCSV = new Button();
            NumeroEcheance = new DataGridViewTextBoxColumn();
            DateEcheance = new DataGridViewTextBoxColumn();
            Interets = new DataGridViewTextBoxColumn();
            MontantPrincipal = new DataGridViewTextBoxColumn();
            ResteDu = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)tableauDEcheancier).BeginInit();
            SuspendLayout();
            // 
            // tableauDEcheancier
            // 
            tableauDEcheancier.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableauDEcheancier.Columns.AddRange(new DataGridViewColumn[] { NumeroEcheance, DateEcheance, Interets, MontantPrincipal, ResteDu });
            tableauDEcheancier.Location = new Point(27, 12);
            tableauDEcheancier.Name = "tableauDEcheancier";
            tableauDEcheancier.RowHeadersWidth = 51;
            tableauDEcheancier.Size = new Size(678, 393);
            tableauDEcheancier.TabIndex = 0;
            // 
            // btnValiderExportCSV
            // 
            btnValiderExportCSV.Location = new Point(27, 440);
            btnValiderExportCSV.Name = "btnValiderExportCSV";
            btnValiderExportCSV.Size = new Size(134, 29);
            btnValiderExportCSV.TabIndex = 1;
            btnValiderExportCSV.Text = "Exporter CSV";
            btnValiderExportCSV.UseVisualStyleBackColor = true;
            // 
            // btnFermerCSV
            // 
            btnFermerCSV.Location = new Point(192, 440);
            btnFermerCSV.Name = "btnFermerCSV";
            btnFermerCSV.Size = new Size(94, 29);
            btnFermerCSV.TabIndex = 2;
            btnFermerCSV.Text = "Fermer";
            btnFermerCSV.UseVisualStyleBackColor = true;
            // 
            // NumeroEcheance
            // 
            NumeroEcheance.DataPropertyName = "NumeroEcheance";
            NumeroEcheance.HeaderText = "N° Echéance";
            NumeroEcheance.MinimumWidth = 6;
            NumeroEcheance.Name = "NumeroEcheance";
            NumeroEcheance.Width = 125;
            // 
            // DateEcheance
            // 
            DateEcheance.DataPropertyName = "DateEcheance";
            DateEcheance.HeaderText = "Date d'Echeance";
            DateEcheance.MinimumWidth = 6;
            DateEcheance.Name = "DateEcheance";
            DateEcheance.Width = 140;
            // 
            // Interets
            // 
            Interets.DataPropertyName = "Interets";
            Interets.HeaderText = "Intérêts";
            Interets.MinimumWidth = 6;
            Interets.Name = "Interets";
            Interets.Width = 125;
            // 
            // MontantPrincipal
            // 
            MontantPrincipal.DataPropertyName = "MontantPrincipal";
            MontantPrincipal.HeaderText = "Principal";
            MontantPrincipal.MinimumWidth = 6;
            MontantPrincipal.Name = "MontantPrincipal";
            MontantPrincipal.Width = 125;
            // 
            // ResteDu
            // 
            ResteDu.DataPropertyName = "ResteDu";
            ResteDu.HeaderText = "Reste Dû";
            ResteDu.MinimumWidth = 6;
            ResteDu.Name = "ResteDu";
            ResteDu.Width = 125;
            // 
            // FormulaireEcheancier
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1287, 633);
            Controls.Add(btnFermerCSV);
            Controls.Add(btnValiderExportCSV);
            Controls.Add(tableauDEcheancier);
            Name = "FormulaireEcheancier";
            Text = "FormulaireEcheancier";
            ((System.ComponentModel.ISupportInitialize)tableauDEcheancier).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView tableauDEcheancier;
        private Button btnValiderExportCSV;
        private Button btnFermerCSV;
        private DataGridViewTextBoxColumn NumeroEcheance;
        private DataGridViewTextBoxColumn DateEcheance;
        private DataGridViewTextBoxColumn Interets;
        private DataGridViewTextBoxColumn MontantPrincipal;
        private DataGridViewTextBoxColumn ResteDu;
    }
}
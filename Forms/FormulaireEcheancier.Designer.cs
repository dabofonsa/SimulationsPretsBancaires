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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            tableauDEcheancier = new DataGridView();
            NumeroEcheance = new DataGridViewTextBoxColumn();
            DateEcheance = new DataGridViewTextBoxColumn();
            Interets = new DataGridViewTextBoxColumn();
            MontantPrincipal = new DataGridViewTextBoxColumn();
            ResteDu = new DataGridViewTextBoxColumn();
            btnValiderExportCSV = new Button();
            btnFermerCSV = new Button();
            dataGridView1 = new DataGridView();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            labelTitreEcheancier = new Label();
            labelCourbe = new Label();
            ((System.ComponentModel.ISupportInitialize)tableauDEcheancier).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            SuspendLayout();
            // 
            // tableauDEcheancier
            // 
            tableauDEcheancier.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableauDEcheancier.Columns.AddRange(new DataGridViewColumn[] { NumeroEcheance, DateEcheance, Interets, MontantPrincipal, ResteDu });
            tableauDEcheancier.Location = new Point(32, 82);
            tableauDEcheancier.Name = "tableauDEcheancier";
            tableauDEcheancier.RowHeadersWidth = 51;
            tableauDEcheancier.Size = new Size(678, 393);
            tableauDEcheancier.TabIndex = 0;
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
            ResteDu.Width = 120;
            // 
            // btnValiderExportCSV
            // 
            btnValiderExportCSV.Location = new Point(32, 510);
            btnValiderExportCSV.Name = "btnValiderExportCSV";
            btnValiderExportCSV.Size = new Size(182, 40);
            btnValiderExportCSV.TabIndex = 1;
            btnValiderExportCSV.Text = "Exporter CSV";
            btnValiderExportCSV.UseVisualStyleBackColor = true;
            // 
            // btnFermerCSV
            // 
            btnFermerCSV.Location = new Point(358, 510);
            btnFermerCSV.Name = "btnFermerCSV";
            btnFermerCSV.Size = new Size(177, 40);
            btnFermerCSV.TabIndex = 2;
            btnFermerCSV.Text = "Fermer";
            btnFermerCSV.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(734, 82);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(496, 409);
            dataGridView1.TabIndex = 3;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(760, 100);
            chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart1.Series.Add(series1);
            chart1.Size = new Size(375, 375);
            chart1.TabIndex = 4;
            chart1.Text = "chart1";
            // 
            // labelTitreEcheancier
            // 
            labelTitreEcheancier.AutoSize = true;
            labelTitreEcheancier.Location = new Point(32, 39);
            labelTitreEcheancier.Name = "labelTitreEcheancier";
            labelTitreEcheancier.Size = new Size(0, 20);
            labelTitreEcheancier.TabIndex = 5;
            // 
            // labelCourbe
            // 
            labelCourbe.AutoSize = true;
            labelCourbe.Location = new Point(760, 39);
            labelCourbe.Name = "labelCourbe";
            labelCourbe.Size = new Size(0, 20);
            labelCourbe.TabIndex = 6;
            // 
            // FormulaireEcheancier
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1287, 633);
            Controls.Add(labelCourbe);
            Controls.Add(labelTitreEcheancier);
            Controls.Add(chart1);
            Controls.Add(dataGridView1);
            Controls.Add(btnFermerCSV);
            Controls.Add(btnValiderExportCSV);
            Controls.Add(tableauDEcheancier);
            Name = "FormulaireEcheancier";
            Text = "FormulaireEcheancier";
            ((System.ComponentModel.ISupportInitialize)tableauDEcheancier).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView tableauDEcheancier;
        private Button btnValiderExportCSV;
        private Button btnFermerCSV;
        private DataGridView dataGridView1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private DataGridViewTextBoxColumn NumeroEcheance;
        private DataGridViewTextBoxColumn DateEcheance;
        private DataGridViewTextBoxColumn Interets;
        private DataGridViewTextBoxColumn MontantPrincipal;
        private DataGridViewTextBoxColumn ResteDu;
        private Label labelTitreEcheancier;
        private Label labelCourbe;
    }
}
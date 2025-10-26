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
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormulaireEcheancier));
            tableauDEcheancier = new DataGridView();
            NumeroEcheance = new DataGridViewTextBoxColumn();
            DateEcheance = new DataGridViewTextBoxColumn();
            Interets = new DataGridViewTextBoxColumn();
            MontantPrincipal = new DataGridViewTextBoxColumn();
            ResteDu = new DataGridViewTextBoxColumn();
            btnValiderExportCSV = new Button();
            btnFermerCSV = new Button();
            CourbeEvolution = new DataGridView();
            labelTitreEcheancier = new Label();
            labelCourbe = new Label();
            courbeCapitalRestant = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)tableauDEcheancier).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CourbeEvolution).BeginInit();
            ((System.ComponentModel.ISupportInitialize)courbeCapitalRestant).BeginInit();
            SuspendLayout();
            // 
            // tableauDEcheancier
            // 
            tableauDEcheancier.Anchor = AnchorStyles.None;
            tableauDEcheancier.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableauDEcheancier.Columns.AddRange(new DataGridViewColumn[] { NumeroEcheance, DateEcheance, Interets, MontantPrincipal, ResteDu });
            tableauDEcheancier.Location = new Point(32, 82);
            tableauDEcheancier.Name = "tableauDEcheancier";
            tableauDEcheancier.RowHeadersWidth = 51;
            tableauDEcheancier.Size = new Size(670, 600);
            tableauDEcheancier.TabIndex = 0;
            // 
            // NumeroEcheance
            // 
            NumeroEcheance.DataPropertyName = "NumeroEcheance";
            NumeroEcheance.HeaderText = "N° Echéance (mois)";
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
            DateEcheance.Width = 130;
            // 
            // Interets
            // 
            Interets.DataPropertyName = "Interets";
            Interets.HeaderText = "Intérêts";
            Interets.MinimumWidth = 6;
            Interets.Name = "Interets";
            Interets.Width = 110;
            // 
            // MontantPrincipal
            // 
            MontantPrincipal.DataPropertyName = "MontantPrincipal";
            MontantPrincipal.HeaderText = "Principal";
            MontantPrincipal.MinimumWidth = 6;
            MontantPrincipal.Name = "MontantPrincipal";
            MontantPrincipal.Width = 110;
            // 
            // ResteDu
            // 
            ResteDu.DataPropertyName = "ResteDu";
            ResteDu.HeaderText = "Reste Dû";
            ResteDu.MinimumWidth = 6;
            ResteDu.Name = "ResteDu";
            ResteDu.Width = 110;
            // 
            // btnValiderExportCSV
            // 
            btnValiderExportCSV.Anchor = AnchorStyles.None;
            btnValiderExportCSV.Location = new Point(43, 747);
            btnValiderExportCSV.Name = "btnValiderExportCSV";
            btnValiderExportCSV.Size = new Size(182, 40);
            btnValiderExportCSV.TabIndex = 1;
            btnValiderExportCSV.Text = "Exporter CSV";
            btnValiderExportCSV.UseVisualStyleBackColor = true;
            // 
            // btnFermerCSV
            // 
            btnFermerCSV.Anchor = AnchorStyles.None;
            btnFermerCSV.Location = new Point(384, 747);
            btnFermerCSV.Name = "btnFermerCSV";
            btnFermerCSV.Size = new Size(177, 40);
            btnFermerCSV.TabIndex = 2;
            btnFermerCSV.Text = "Fermer";
            btnFermerCSV.UseVisualStyleBackColor = true;
            // 
            // CourbeEvolution
            // 
            CourbeEvolution.Anchor = AnchorStyles.None;
            CourbeEvolution.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CourbeEvolution.Location = new Point(720, 82);
            CourbeEvolution.Name = "CourbeEvolution";
            CourbeEvolution.RowHeadersWidth = 51;
            CourbeEvolution.Size = new Size(1035, 600);
            CourbeEvolution.TabIndex = 3;
            // 
            // labelTitreEcheancier
            // 
            labelTitreEcheancier.AutoSize = true;
            labelTitreEcheancier.BackColor = SystemColors.ButtonHighlight;
            labelTitreEcheancier.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTitreEcheancier.ForeColor = SystemColors.ControlText;
            labelTitreEcheancier.Location = new Point(238, 51);
            labelTitreEcheancier.Name = "labelTitreEcheancier";
            labelTitreEcheancier.Size = new Size(306, 28);
            labelTitreEcheancier.TabIndex = 5;
            labelTitreEcheancier.Text = "Voici l'échéancier de l'emprunteur";
            // 
            // labelCourbe
            // 
            labelCourbe.AutoSize = true;
            labelCourbe.BackColor = SystemColors.ButtonHighlight;
            labelCourbe.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelCourbe.ForeColor = SystemColors.ControlText;
            labelCourbe.Location = new Point(1002, 51);
            labelCourbe.Name = "labelCourbe";
            labelCourbe.Size = new Size(510, 28);
            labelCourbe.TabIndex = 6;
            labelCourbe.Text = "Courbe d'évolution du capital restant dû de l'emprunteur";
            // 
            // courbeCapitalRestant
            // 
            courbeCapitalRestant.Anchor = AnchorStyles.None;
            chartArea1.AxisX.Interval = 1D;
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.LabelStyle.Angle = -25;
            chartArea1.AxisX.MajorGrid.LineColor = Color.LightGray;
            chartArea1.AxisX.Minimum = 1D;
            chartArea1.AxisX.Title = "Numéro d’échéance (mois)";
            chartArea1.AxisY.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea1.AxisY.LabelStyle.Format = "N0";
            chartArea1.AxisY.MajorGrid.LineColor = Color.LightGray;
            chartArea1.AxisY.Minimum = 0D;
            chartArea1.AxisY.Title = "Capital restant dû (€)";
            chartArea1.Name = "zoneGrapgique";
            courbeCapitalRestant.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            courbeCapitalRestant.Legends.Add(legend1);
            courbeCapitalRestant.Location = new Point(734, 99);
            courbeCapitalRestant.Name = "courbeCapitalRestant";
            series1.ChartArea = "zoneGrapgique";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            courbeCapitalRestant.Series.Add(series1);
            courbeCapitalRestant.Size = new Size(1007, 565);
            courbeCapitalRestant.TabIndex = 7;
            courbeCapitalRestant.Text = "chart1";
            title1.Name = "Title1";
            title1.Text = "Evolution du capital restant dû";
            courbeCapitalRestant.Titles.Add(title1);
            // 
            // FormulaireEcheancier
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1767, 829);
            Controls.Add(courbeCapitalRestant);
            Controls.Add(labelCourbe);
            Controls.Add(labelTitreEcheancier);
            Controls.Add(CourbeEvolution);
            Controls.Add(btnFermerCSV);
            Controls.Add(btnValiderExportCSV);
            Controls.Add(tableauDEcheancier);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormulaireEcheancier";
            Text = "FormulaireEcheancier";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)tableauDEcheancier).EndInit();
            ((System.ComponentModel.ISupportInitialize)CourbeEvolution).EndInit();
            ((System.ComponentModel.ISupportInitialize)courbeCapitalRestant).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView tableauDEcheancier;
        private Button btnValiderExportCSV;
        private Button btnFermerCSV;
        private DataGridView CourbeEvolution;
        private Label labelTitreEcheancier;
        private Label labelCourbe;
        private System.Windows.Forms.DataVisualization.Charting.Chart courbeCapitalRestant;
        private DataGridViewTextBoxColumn NumeroEcheance;
        private DataGridViewTextBoxColumn DateEcheance;
        private DataGridViewTextBoxColumn Interets;
        private DataGridViewTextBoxColumn MontantPrincipal;
        private DataGridViewTextBoxColumn ResteDu;
    }
}
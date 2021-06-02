namespace MeteoStation_2.Forms
{
    partial class FormGraph
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.Graph = new System.Windows.Forms.Label();
            this.chartID = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btLauch = new System.Windows.Forms.Button();
            this.labelID = new System.Windows.Forms.Label();
            this.comboBoxIDGraphique = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.chartID)).BeginInit();
            this.SuspendLayout();
            // 
            // Graph
            // 
            this.Graph.AutoSize = true;
            this.Graph.Location = new System.Drawing.Point(15, 16);
            this.Graph.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Graph.Name = "Graph";
            this.Graph.Size = new System.Drawing.Size(56, 13);
            this.Graph.TabIndex = 0;
            this.Graph.Text = "Graphique";
            // 
            // chartID
            // 
            chartArea1.Name = "ChartArea1";
            this.chartID.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartID.Legends.Add(legend1);
            this.chartID.Location = new System.Drawing.Point(50, 41);
            this.chartID.Name = "chartID";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartID.Series.Add(series1);
            this.chartID.Size = new System.Drawing.Size(330, 211);
            this.chartID.TabIndex = 4;
            this.chartID.Text = "chart1";
            // 
            // btLauch
            // 
            this.btLauch.Location = new System.Drawing.Point(502, 83);
            this.btLauch.Name = "btLauch";
            this.btLauch.Size = new System.Drawing.Size(147, 23);
            this.btLauch.TabIndex = 7;
            this.btLauch.Text = "Lauch";
            this.btLauch.UseVisualStyleBackColor = true;
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(499, 40);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(18, 13);
            this.labelID.TabIndex = 6;
            this.labelID.Text = "ID";
            // 
            // comboBoxIDGraphique
            // 
            this.comboBoxIDGraphique.FormattingEnabled = true;
            this.comboBoxIDGraphique.Location = new System.Drawing.Point(502, 56);
            this.comboBoxIDGraphique.Name = "comboBoxIDGraphique";
            this.comboBoxIDGraphique.Size = new System.Drawing.Size(147, 21);
            this.comboBoxIDGraphique.TabIndex = 5;
            // 
            // FormGraph
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btLauch);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.comboBoxIDGraphique);
            this.Controls.Add(this.chartID);
            this.Controls.Add(this.Graph);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormGraph";
            this.Size = new System.Drawing.Size(700, 266);
            ((System.ComponentModel.ISupportInitialize)(this.chartID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Graph;
        private System.Windows.Forms.Label labelID;
        internal System.Windows.Forms.DataVisualization.Charting.Chart chartID;
        internal System.Windows.Forms.Button btLauch;
        internal System.Windows.Forms.ComboBox comboBoxIDGraphique;
    }
}

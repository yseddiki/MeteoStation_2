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
            this.Graph = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Graph
            // 
            this.Graph.AutoSize = true;
            this.Graph.Location = new System.Drawing.Point(23, 25);
            this.Graph.Name = "Graph";
            this.Graph.Size = new System.Drawing.Size(54, 20);
            this.Graph.TabIndex = 0;
            this.Graph.Text = "Graph";
            // 
            // FormGraph
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Graph);
            this.Name = "FormGraph";
            this.Size = new System.Drawing.Size(313, 321);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Graph;
    }
}

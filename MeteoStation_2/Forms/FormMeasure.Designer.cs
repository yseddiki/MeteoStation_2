namespace MeteoStation_2.Forms
{
    partial class FormMeasure
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
            this.lb_measure = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_measure
            // 
            this.lb_measure.AutoSize = true;
            this.lb_measure.Location = new System.Drawing.Point(35, 43);
            this.lb_measure.Name = "lb_measure";
            this.lb_measure.Size = new System.Drawing.Size(71, 20);
            this.lb_measure.TabIndex = 0;
            this.lb_measure.Text = "Measure";
            // 
            // FormMeasure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lb_measure);
            this.Name = "FormMeasure";
            this.Size = new System.Drawing.Size(438, 423);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_measure;
    }
}

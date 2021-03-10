namespace MeteoStation_2
{
    partial class Form1
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

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
 private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.datagridMeteo = new System.Windows.Forms.DataGridView();
            this.Serial = new System.IO.Ports.SerialPort(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lb_MinAlarm = new System.Windows.Forms.Label();
            this.lb_AlarmMax = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.lb_IntervalMin = new System.Windows.Forms.Label();
            this.lb_IntervalMax = new System.Windows.Forms.Label();
            this.nUD_MinInterval = new System.Windows.Forms.NumericUpDown();
            this.nUD_MaxInterval = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.datagridMeteo)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_MinInterval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_MaxInterval)).BeginInit();
            this.SuspendLayout();
            // 
            // datagridMeteo
            // 
            this.datagridMeteo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridMeteo.Location = new System.Drawing.Point(59, 30);
            this.datagridMeteo.Name = "datagridMeteo";
            this.datagridMeteo.RowHeadersWidth = 62;
            this.datagridMeteo.RowTemplate.Height = 28;
            this.datagridMeteo.Size = new System.Drawing.Size(819, 459);
            this.datagridMeteo.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lb_MinAlarm);
            this.groupBox1.Controls.Add(this.lb_AlarmMax);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.numericUpDown2);
            this.groupBox1.Controls.Add(this.lb_IntervalMin);
            this.groupBox1.Controls.Add(this.lb_IntervalMax);
            this.groupBox1.Controls.Add(this.nUD_MinInterval);
            this.groupBox1.Controls.Add(this.nUD_MaxInterval);
            this.groupBox1.Location = new System.Drawing.Point(899, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(416, 335);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parametre";
            // 
            // lb_MinAlarm
            // 
            this.lb_MinAlarm.AutoSize = true;
            this.lb_MinAlarm.Location = new System.Drawing.Point(243, 119);
            this.lb_MinAlarm.Name = "lb_MinAlarm";
            this.lb_MinAlarm.Size = new System.Drawing.Size(79, 20);
            this.lb_MinAlarm.TabIndex = 7;
            this.lb_MinAlarm.Text = "Alarm Min";
            // 
            // lb_AlarmMax
            // 
            this.lb_AlarmMax.AutoSize = true;
            this.lb_AlarmMax.Location = new System.Drawing.Point(243, 35);
            this.lb_AlarmMax.Name = "lb_AlarmMax";
            this.lb_AlarmMax.Size = new System.Drawing.Size(83, 20);
            this.lb_AlarmMax.TabIndex = 6;
            this.lb_AlarmMax.Text = "Alarm Max";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(247, 142);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 26);
            this.numericUpDown1.TabIndex = 5;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(247, 58);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 26);
            this.numericUpDown2.TabIndex = 4;
            // 
            // lb_IntervalMin
            // 
            this.lb_IntervalMin.AutoSize = true;
            this.lb_IntervalMin.Location = new System.Drawing.Point(20, 119);
            this.lb_IntervalMin.Name = "lb_IntervalMin";
            this.lb_IntervalMin.Size = new System.Drawing.Size(90, 20);
            this.lb_IntervalMin.TabIndex = 3;
            this.lb_IntervalMin.Text = "Interval Min";
            // 
            // lb_IntervalMax
            // 
            this.lb_IntervalMax.AutoSize = true;
            this.lb_IntervalMax.Location = new System.Drawing.Point(20, 35);
            this.lb_IntervalMax.Name = "lb_IntervalMax";
            this.lb_IntervalMax.Size = new System.Drawing.Size(94, 20);
            this.lb_IntervalMax.TabIndex = 2;
            this.lb_IntervalMax.Text = "Interval Max";
            // 
            // nUD_MinInterval
            // 
            this.nUD_MinInterval.Location = new System.Drawing.Point(24, 142);
            this.nUD_MinInterval.Name = "nUD_MinInterval";
            this.nUD_MinInterval.Size = new System.Drawing.Size(120, 26);
            this.nUD_MinInterval.TabIndex = 1;
            // 
            // nUD_MaxInterval
            // 
            this.nUD_MaxInterval.Location = new System.Drawing.Point(24, 58);
            this.nUD_MaxInterval.Name = "nUD_MaxInterval";
            this.nUD_MaxInterval.Size = new System.Drawing.Size(120, 26);
            this.nUD_MaxInterval.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1327, 642);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.datagridMeteo);
            this.Name = "Form1";
            this.Text = "Meteo";
            ((System.ComponentModel.ISupportInitialize)(this.datagridMeteo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_MinInterval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_MaxInterval)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView datagridMeteo;
        private System.IO.Ports.SerialPort Serial;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lb_MinAlarm;
        private System.Windows.Forms.Label lb_AlarmMax;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label lb_IntervalMin;
        private System.Windows.Forms.Label lb_IntervalMax;
        private System.Windows.Forms.NumericUpDown nUD_MinInterval;
        private System.Windows.Forms.NumericUpDown nUD_MaxInterval;
    }

      
    
}


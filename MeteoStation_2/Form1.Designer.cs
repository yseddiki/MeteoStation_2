﻿namespace MeteoStation_2
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
            this.bt_Update = new System.Windows.Forms.Button();
            this.lb_MinAlarm = new System.Windows.Forms.Label();
            this.lb_AlarmMax = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.lb_IntervalMin = new System.Windows.Forms.Label();
            this.lb_IntervalMax = new System.Windows.Forms.Label();
            this.nUD_MinInterval = new System.Windows.Forms.NumericUpDown();
            this.nUD_MaxInterval = new System.Windows.Forms.NumericUpDown();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.AlarmPage = new MeteoStation_2.Forms.FormAlarm();
            this.button1 = new System.Windows.Forms.Button();
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
            this.datagridMeteo.AllowUserToAddRows = false;
            this.datagridMeteo.AllowUserToDeleteRows = false;
            this.datagridMeteo.AllowUserToResizeColumns = false;
            this.datagridMeteo.AllowUserToResizeRows = false;
            this.datagridMeteo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridMeteo.Location = new System.Drawing.Point(39, 19);
            this.datagridMeteo.Margin = new System.Windows.Forms.Padding(2);
            this.datagridMeteo.Name = "datagridMeteo";
            this.datagridMeteo.ReadOnly = true;
            this.datagridMeteo.RowHeadersVisible = false;
            this.datagridMeteo.RowHeadersWidth = 62;
            this.datagridMeteo.RowTemplate.Height = 28;
            this.datagridMeteo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.datagridMeteo.ShowCellErrors = false;
            this.datagridMeteo.ShowCellToolTips = false;
            this.datagridMeteo.ShowEditingIcon = false;
            this.datagridMeteo.ShowRowErrors = false;
            this.datagridMeteo.Size = new System.Drawing.Size(497, 218);
            this.datagridMeteo.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bt_Update);
            this.groupBox1.Controls.Add(this.lb_MinAlarm);
            this.groupBox1.Controls.Add(this.lb_AlarmMax);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.numericUpDown2);
            this.groupBox1.Controls.Add(this.lb_IntervalMin);
            this.groupBox1.Controls.Add(this.lb_IntervalMax);
            this.groupBox1.Controls.Add(this.nUD_MinInterval);
            this.groupBox1.Controls.Add(this.nUD_MaxInterval);
            this.groupBox1.Location = new System.Drawing.Point(599, 19);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(277, 218);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parametre";
            // 
            // bt_Update
            // 
            this.bt_Update.Location = new System.Drawing.Point(102, 154);
            this.bt_Update.Margin = new System.Windows.Forms.Padding(2);
            this.bt_Update.Name = "bt_Update";
            this.bt_Update.Size = new System.Drawing.Size(83, 28);
            this.bt_Update.TabIndex = 8;
            this.bt_Update.Text = "Update";
            this.bt_Update.UseVisualStyleBackColor = true;
            // 
            // lb_MinAlarm
            // 
            this.lb_MinAlarm.AutoSize = true;
            this.lb_MinAlarm.Location = new System.Drawing.Point(162, 77);
            this.lb_MinAlarm.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_MinAlarm.Name = "lb_MinAlarm";
            this.lb_MinAlarm.Size = new System.Drawing.Size(53, 13);
            this.lb_MinAlarm.TabIndex = 7;
            this.lb_MinAlarm.Text = "Alarm Min";
            // 
            // lb_AlarmMax
            // 
            this.lb_AlarmMax.AutoSize = true;
            this.lb_AlarmMax.Location = new System.Drawing.Point(162, 23);
            this.lb_AlarmMax.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_AlarmMax.Name = "lb_AlarmMax";
            this.lb_AlarmMax.Size = new System.Drawing.Size(56, 13);
            this.lb_AlarmMax.TabIndex = 6;
            this.lb_AlarmMax.Text = "Alarm Max";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(165, 92);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(80, 20);
            this.numericUpDown1.TabIndex = 5;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(165, 38);
            this.numericUpDown2.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(80, 20);
            this.numericUpDown2.TabIndex = 4;
            // 
            // lb_IntervalMin
            // 
            this.lb_IntervalMin.AutoSize = true;
            this.lb_IntervalMin.Location = new System.Drawing.Point(13, 77);
            this.lb_IntervalMin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_IntervalMin.Name = "lb_IntervalMin";
            this.lb_IntervalMin.Size = new System.Drawing.Size(62, 13);
            this.lb_IntervalMin.TabIndex = 3;
            this.lb_IntervalMin.Text = "Interval Min";
            // 
            // lb_IntervalMax
            // 
            this.lb_IntervalMax.AutoSize = true;
            this.lb_IntervalMax.Location = new System.Drawing.Point(13, 23);
            this.lb_IntervalMax.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_IntervalMax.Name = "lb_IntervalMax";
            this.lb_IntervalMax.Size = new System.Drawing.Size(65, 13);
            this.lb_IntervalMax.TabIndex = 2;
            this.lb_IntervalMax.Text = "Interval Max";
            // 
            // nUD_MinInterval
            // 
            this.nUD_MinInterval.Location = new System.Drawing.Point(17, 93);
            this.nUD_MinInterval.Margin = new System.Windows.Forms.Padding(2);
            this.nUD_MinInterval.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nUD_MinInterval.Name = "nUD_MinInterval";
            this.nUD_MinInterval.Size = new System.Drawing.Size(80, 20);
            this.nUD_MinInterval.TabIndex = 1;
            // 
            // nUD_MaxInterval
            // 
            this.nUD_MaxInterval.Location = new System.Drawing.Point(16, 38);
            this.nUD_MaxInterval.Margin = new System.Windows.Forms.Padding(2);
            this.nUD_MaxInterval.Name = "nUD_MaxInterval";
            this.nUD_MaxInterval.Size = new System.Drawing.Size(80, 20);
            this.nUD_MaxInterval.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // AlarmPage
            // 
            this.AlarmPage.Location = new System.Drawing.Point(39, 241);
            this.AlarmPage.Margin = new System.Windows.Forms.Padding(1);
            this.AlarmPage.Name = "AlarmPage";
            this.AlarmPage.Size = new System.Drawing.Size(497, 168);
            this.AlarmPage.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(616, 359);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(228, 50);
            this.button1.TabIndex = 3;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 417);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AlarmPage);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.datagridMeteo);
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.Button bt_Update;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
    }

      
    
}


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
            this.ID = new System.Windows.Forms.Label();
            this.numericUpDownID = new System.Windows.Forms.NumericUpDown();
            this.bt_Update = new System.Windows.Forms.Button();
            this.lb_MinAlarm = new System.Windows.Forms.Label();
            this.lb_AlarmMax = new System.Windows.Forms.Label();
            this.numericUpDownAlarmMin = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownAlarmMax = new System.Windows.Forms.NumericUpDown();
            this.lb_IntervalMin = new System.Windows.Forms.Label();
            this.lb_IntervalMax = new System.Windows.Forms.Label();
            this.nUD_MinInterval = new System.Windows.Forms.NumericUpDown();
            this.nUD_MaxInterval = new System.Windows.Forms.NumericUpDown();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.connectbutton = new System.Windows.Forms.Button();
            this.UserInput = new System.Windows.Forms.TextBox();
            this.passwordInput = new System.Windows.Forms.TextBox();
            this.labelUser = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.accountlabel = new System.Windows.Forms.Label();
            this.tabcontrol = new System.Windows.Forms.TabControl();
            this.tabPageDefault = new System.Windows.Forms.TabPage();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonUpload = new System.Windows.Forms.Button();
            this.tabPageGraphiique = new System.Windows.Forms.TabPage();
            this.formAlarm1 = new MeteoStation_2.Forms.FormAlarm();
            ((System.ComponentModel.ISupportInitialize)(this.datagridMeteo)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAlarmMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAlarmMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_MinInterval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_MaxInterval)).BeginInit();
            this.tabcontrol.SuspendLayout();
            this.tabPageDefault.SuspendLayout();
            this.SuspendLayout();
            // 
            // datagridMeteo
            // 
            this.datagridMeteo.AllowUserToAddRows = false;
            this.datagridMeteo.AllowUserToDeleteRows = false;
            this.datagridMeteo.AllowUserToResizeColumns = false;
            this.datagridMeteo.AllowUserToResizeRows = false;
            this.datagridMeteo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridMeteo.Location = new System.Drawing.Point(23, 19);
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
            this.groupBox1.Controls.Add(this.ID);
            this.groupBox1.Controls.Add(this.numericUpDownID);
            this.groupBox1.Controls.Add(this.bt_Update);
            this.groupBox1.Controls.Add(this.lb_MinAlarm);
            this.groupBox1.Controls.Add(this.lb_AlarmMax);
            this.groupBox1.Controls.Add(this.numericUpDownAlarmMin);
            this.groupBox1.Controls.Add(this.numericUpDownAlarmMax);
            this.groupBox1.Controls.Add(this.lb_IntervalMin);
            this.groupBox1.Controls.Add(this.lb_IntervalMax);
            this.groupBox1.Controls.Add(this.nUD_MinInterval);
            this.groupBox1.Controls.Add(this.nUD_MaxInterval);
            this.groupBox1.Location = new System.Drawing.Point(555, 19);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(277, 190);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parametre";
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(16, 129);
            this.ID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(18, 13);
            this.ID.TabIndex = 10;
            this.ID.Text = "ID";
            // 
            // numericUpDownID
            // 
            this.numericUpDownID.Location = new System.Drawing.Point(16, 144);
            this.numericUpDownID.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDownID.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDownID.Name = "numericUpDownID";
            this.numericUpDownID.Size = new System.Drawing.Size(80, 20);
            this.numericUpDownID.TabIndex = 9;
            // 
            // bt_Update
            // 
            this.bt_Update.Location = new System.Drawing.Point(162, 138);
            this.bt_Update.Margin = new System.Windows.Forms.Padding(2);
            this.bt_Update.Name = "bt_Update";
            this.bt_Update.Size = new System.Drawing.Size(83, 28);
            this.bt_Update.TabIndex = 8;
            this.bt_Update.Text = "Update";
            this.bt_Update.UseVisualStyleBackColor = true;
            this.bt_Update.Click += new System.EventHandler(this.bt_Update_Click);
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
            // numericUpDownAlarmMin
            // 
            this.numericUpDownAlarmMin.Location = new System.Drawing.Point(165, 92);
            this.numericUpDownAlarmMin.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDownAlarmMin.Name = "numericUpDownAlarmMin";
            this.numericUpDownAlarmMin.Size = new System.Drawing.Size(80, 20);
            this.numericUpDownAlarmMin.TabIndex = 5;
            // 
            // numericUpDownAlarmMax
            // 
            this.numericUpDownAlarmMax.Location = new System.Drawing.Point(165, 38);
            this.numericUpDownAlarmMax.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDownAlarmMax.Name = "numericUpDownAlarmMax";
            this.numericUpDownAlarmMax.Size = new System.Drawing.Size(80, 20);
            this.numericUpDownAlarmMax.TabIndex = 4;
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(555, 215);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(277, 22);
            this.button1.TabIndex = 3;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // connectbutton
            // 
            this.connectbutton.Location = new System.Drawing.Point(369, 6);
            this.connectbutton.Name = "connectbutton";
            this.connectbutton.Size = new System.Drawing.Size(75, 23);
            this.connectbutton.TabIndex = 5;
            this.connectbutton.Text = "Connect";
            this.connectbutton.UseVisualStyleBackColor = true;
            this.connectbutton.Click += new System.EventHandler(this.connectbutton_Click);
            // 
            // UserInput
            // 
            this.UserInput.Location = new System.Drawing.Point(79, 8);
            this.UserInput.Name = "UserInput";
            this.UserInput.Size = new System.Drawing.Size(100, 20);
            this.UserInput.TabIndex = 6;
            // 
            // passwordInput
            // 
            this.passwordInput.Location = new System.Drawing.Point(263, 8);
            this.passwordInput.Name = "passwordInput";
            this.passwordInput.Size = new System.Drawing.Size(100, 20);
            this.passwordInput.TabIndex = 7;
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Location = new System.Drawing.Point(12, 11);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(61, 13);
            this.labelUser.TabIndex = 8;
            this.labelUser.Text = "Username :";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(196, 11);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(59, 13);
            this.labelPassword.TabIndex = 9;
            this.labelPassword.Text = "Password :";
            // 
            // accountlabel
            // 
            this.accountlabel.AutoSize = true;
            this.accountlabel.Location = new System.Drawing.Point(783, 15);
            this.accountlabel.Name = "accountlabel";
            this.accountlabel.Size = new System.Drawing.Size(0, 13);
            this.accountlabel.TabIndex = 10;
            // 
            // tabcontrol
            // 
            this.tabcontrol.Controls.Add(this.tabPageDefault);
            this.tabcontrol.Controls.Add(this.tabPageGraphiique);
            this.tabcontrol.Location = new System.Drawing.Point(15, 51);
            this.tabcontrol.Name = "tabcontrol";
            this.tabcontrol.SelectedIndex = 0;
            this.tabcontrol.Size = new System.Drawing.Size(861, 296);
            this.tabcontrol.TabIndex = 11;
            // 
            // tabPageDefault
            // 
            this.tabPageDefault.Controls.Add(this.buttonSave);
            this.tabPageDefault.Controls.Add(this.buttonUpload);
            this.tabPageDefault.Controls.Add(this.datagridMeteo);
            this.tabPageDefault.Controls.Add(this.groupBox1);
            this.tabPageDefault.Controls.Add(this.button1);
            this.tabPageDefault.Location = new System.Drawing.Point(4, 22);
            this.tabPageDefault.Name = "tabPageDefault";
            this.tabPageDefault.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDefault.Size = new System.Drawing.Size(853, 270);
            this.tabPageDefault.TabIndex = 0;
            this.tabPageDefault.Text = "Data";
            this.tabPageDefault.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(294, 238);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(226, 29);
            this.buttonSave.TabIndex = 12;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // buttonUpload
            // 
            this.buttonUpload.Location = new System.Drawing.Point(23, 238);
            this.buttonUpload.Name = "buttonUpload";
            this.buttonUpload.Size = new System.Drawing.Size(213, 29);
            this.buttonUpload.TabIndex = 13;
            this.buttonUpload.Text = "Upload";
            this.buttonUpload.UseVisualStyleBackColor = true;
            this.buttonUpload.Click += new System.EventHandler(this.btUpload_Click);
            // 
            // tabPageGraphiique
            // 
            this.tabPageGraphiique.Location = new System.Drawing.Point(4, 22);
            this.tabPageGraphiique.Name = "tabPageGraphiique";
            this.tabPageGraphiique.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGraphiique.Size = new System.Drawing.Size(853, 270);
            this.tabPageGraphiique.TabIndex = 1;
            this.tabPageGraphiique.Text = "Graphique";
            this.tabPageGraphiique.UseVisualStyleBackColor = true;
            // 
            // formAlarm1
            // 
            this.formAlarm1.Location = new System.Drawing.Point(393, 308);
            this.formAlarm1.Margin = new System.Windows.Forms.Padding(1);
            this.formAlarm1.Name = "formAlarm1";
            this.formAlarm1.Size = new System.Drawing.Size(5, 5);
            this.formAlarm1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 570);
            this.Controls.Add(this.tabcontrol);
            this.Controls.Add(this.accountlabel);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.passwordInput);
            this.Controls.Add(this.UserInput);
            this.Controls.Add(this.connectbutton);
            this.Controls.Add(this.formAlarm1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Meteo";
            ((System.ComponentModel.ISupportInitialize)(this.datagridMeteo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAlarmMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAlarmMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_MinInterval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_MaxInterval)).EndInit();
            this.tabcontrol.ResumeLayout(false);
            this.tabPageDefault.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView datagridMeteo;
        private System.IO.Ports.SerialPort Serial;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lb_MinAlarm;
        private System.Windows.Forms.Label lb_AlarmMax;
        private System.Windows.Forms.NumericUpDown numericUpDownAlarmMin;
        private System.Windows.Forms.NumericUpDown numericUpDownAlarmMax;
        private System.Windows.Forms.Label lb_IntervalMin;
        private System.Windows.Forms.Label lb_IntervalMax;
        private System.Windows.Forms.NumericUpDown nUD_MinInterval;
        private System.Windows.Forms.NumericUpDown nUD_MaxInterval;
        private System.Windows.Forms.Button bt_Update;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private Forms.FormAlarm formAlarm1;
        private System.Windows.Forms.Button connectbutton;
        private System.Windows.Forms.TextBox UserInput;
        private System.Windows.Forms.TextBox passwordInput;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label accountlabel;
        private System.Windows.Forms.TabControl tabcontrol;
        private System.Windows.Forms.TabPage tabPageDefault;
        private System.Windows.Forms.TabPage tabPageGraphiique;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonUpload;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.NumericUpDown numericUpDownID;
    }

      
    
}


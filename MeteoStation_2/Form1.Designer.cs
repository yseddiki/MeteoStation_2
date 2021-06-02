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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.datagridMeteo = new System.Windows.Forms.DataGridView();
            this.Serial = new System.IO.Ports.SerialPort(this.components);
            this.groupBoxConfiguration = new System.Windows.Forms.GroupBox();
            this.buttonUpload = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.comboBoxID = new System.Windows.Forms.ComboBox();
            this.ID = new System.Windows.Forms.Label();
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
            this.Exit_bt = new System.Windows.Forms.Button();
            this.formAlarm1 = new MeteoStation_2.Forms.FormAlarm();
            ((System.ComponentModel.ISupportInitialize)(this.datagridMeteo)).BeginInit();
            this.groupBoxConfiguration.SuspendLayout();
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
            this.datagridMeteo.Location = new System.Drawing.Point(23, 12);
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
            this.datagridMeteo.Size = new System.Drawing.Size(604, 194);
            this.datagridMeteo.TabIndex = 0;
            // 
            // groupBoxConfiguration
            // 
            this.groupBoxConfiguration.Controls.Add(this.buttonUpload);
            this.groupBoxConfiguration.Controls.Add(this.buttonSave);
            this.groupBoxConfiguration.Controls.Add(this.comboBoxID);
            this.groupBoxConfiguration.Controls.Add(this.ID);
            this.groupBoxConfiguration.Controls.Add(this.bt_Update);
            this.groupBoxConfiguration.Controls.Add(this.lb_MinAlarm);
            this.groupBoxConfiguration.Controls.Add(this.lb_AlarmMax);
            this.groupBoxConfiguration.Controls.Add(this.numericUpDownAlarmMin);
            this.groupBoxConfiguration.Controls.Add(this.numericUpDownAlarmMax);
            this.groupBoxConfiguration.Controls.Add(this.lb_IntervalMin);
            this.groupBoxConfiguration.Controls.Add(this.lb_IntervalMax);
            this.groupBoxConfiguration.Controls.Add(this.nUD_MinInterval);
            this.groupBoxConfiguration.Controls.Add(this.nUD_MaxInterval);
            this.groupBoxConfiguration.Location = new System.Drawing.Point(720, 5);
            this.groupBoxConfiguration.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxConfiguration.Name = "groupBoxConfiguration";
            this.groupBoxConfiguration.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxConfiguration.Size = new System.Drawing.Size(273, 269);
            this.groupBoxConfiguration.TabIndex = 1;
            this.groupBoxConfiguration.TabStop = false;
            this.groupBoxConfiguration.Text = "Parametre";
            // 
            // buttonUpload
            // 
            this.buttonUpload.Location = new System.Drawing.Point(139, 230);
            this.buttonUpload.Name = "buttonUpload";
            this.buttonUpload.Size = new System.Drawing.Size(118, 29);
            this.buttonUpload.TabIndex = 13;
            this.buttonUpload.Text = "Upload";
            this.buttonUpload.UseVisualStyleBackColor = true;
            this.buttonUpload.Click += new System.EventHandler(this.btUpload_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(16, 230);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(117, 29);
            this.buttonSave.TabIndex = 12;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // comboBoxID
            // 
            this.comboBoxID.FormattingEnabled = true;
            this.comboBoxID.Location = new System.Drawing.Point(19, 144);
            this.comboBoxID.Name = "comboBoxID";
            this.comboBoxID.Size = new System.Drawing.Size(238, 21);
            this.comboBoxID.TabIndex = 11;
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(16, 128);
            this.ID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(18, 13);
            this.ID.TabIndex = 10;
            this.ID.Text = "ID";
            // 
            // bt_Update
            // 
            this.bt_Update.Location = new System.Drawing.Point(17, 173);
            this.bt_Update.Margin = new System.Windows.Forms.Padding(2);
            this.bt_Update.Name = "bt_Update";
            this.bt_Update.Size = new System.Drawing.Size(240, 28);
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
            this.numericUpDownAlarmMin.Size = new System.Drawing.Size(92, 20);
            this.numericUpDownAlarmMin.TabIndex = 5;
            // 
            // numericUpDownAlarmMax
            // 
            this.numericUpDownAlarmMax.Location = new System.Drawing.Point(165, 38);
            this.numericUpDownAlarmMax.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDownAlarmMax.Name = "numericUpDownAlarmMax";
            this.numericUpDownAlarmMax.Size = new System.Drawing.Size(92, 20);
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
            this.button1.Location = new System.Drawing.Point(23, 211);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(604, 46);
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
            this.labelUser.BackColor = System.Drawing.Color.Transparent;
            this.labelUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.labelUser.Location = new System.Drawing.Point(12, 11);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(61, 13);
            this.labelUser.TabIndex = 8;
            this.labelUser.Text = "Username :";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.BackColor = System.Drawing.Color.Transparent;
            this.labelPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
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
            this.accountlabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.accountlabel.Size = new System.Drawing.Size(0, 13);
            this.accountlabel.TabIndex = 10;
            // 
            // tabcontrol
            // 
            this.tabcontrol.Controls.Add(this.tabPageDefault);
            this.tabcontrol.Location = new System.Drawing.Point(15, 51);
            this.tabcontrol.Name = "tabcontrol";
            this.tabcontrol.SelectedIndex = 0;
            this.tabcontrol.Size = new System.Drawing.Size(1097, 342);
            this.tabcontrol.TabIndex = 11;
            // 
            // tabPageDefault
            // 
            this.tabPageDefault.BackColor = System.Drawing.Color.SkyBlue;
            this.tabPageDefault.Controls.Add(this.datagridMeteo);
            this.tabPageDefault.Controls.Add(this.groupBoxConfiguration);
            this.tabPageDefault.Controls.Add(this.button1);
            this.tabPageDefault.Location = new System.Drawing.Point(4, 22);
            this.tabPageDefault.Name = "tabPageDefault";
            this.tabPageDefault.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDefault.Size = new System.Drawing.Size(1089, 316);
            this.tabPageDefault.TabIndex = 0;
            this.tabPageDefault.Text = "Data";
            // 
            // Exit_bt
            // 
            this.Exit_bt.Location = new System.Drawing.Point(19, 477);
            this.Exit_bt.Name = "Exit_bt";
            this.Exit_bt.Size = new System.Drawing.Size(344, 65);
            this.Exit_bt.TabIndex = 12;
            this.Exit_bt.Text = "Exit";
            this.Exit_bt.UseVisualStyleBackColor = true;
            this.Exit_bt.Click += new System.EventHandler(this.Exit_bt_Click);
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
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1136, 583);
            this.Controls.Add(this.Exit_bt);
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
            this.Text = "Meteo Simulator";
            ((System.ComponentModel.ISupportInitialize)(this.datagridMeteo)).EndInit();
            this.groupBoxConfiguration.ResumeLayout(false);
            this.groupBoxConfiguration.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBoxConfiguration;
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
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonUpload;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.ComboBox comboBoxID;
        private System.Windows.Forms.Button Exit_bt;
    }

      
    
}


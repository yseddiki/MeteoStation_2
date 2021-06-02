namespace MeteoStation_2.Forms
{
    partial class FormUser
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
            this.dataGridViewUser = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btRead = new System.Windows.Forms.Button();
            this.btInsert = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.Access = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.pwd = new System.Windows.Forms.TextBox();
            this.accesscreatelabel = new System.Windows.Forms.Label();
            this.pwdlabel = new System.Windows.Forms.Label();
            this.accesslabel = new System.Windows.Forms.Label();
            this.textBoxnameDelete = new System.Windows.Forms.TextBox();
            this.labelNameDelete = new System.Windows.Forms.Label();
            this.groupBoxCreate = new System.Windows.Forms.GroupBox();
            this.groupBoxUserDelete = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUser)).BeginInit();
            this.groupBoxCreate.SuspendLayout();
            this.groupBoxUserDelete.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewUser
            // 
            this.dataGridViewUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUser.Location = new System.Drawing.Point(33, 50);
            this.dataGridViewUser.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewUser.Name = "dataGridViewUser";
            this.dataGridViewUser.RowHeadersWidth = 62;
            this.dataGridViewUser.RowTemplate.Height = 28;
            this.dataGridViewUser.Size = new System.Drawing.Size(463, 215);
            this.dataGridViewUser.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Utilisateurs dans la base de données";
            // 
            // btRead
            // 
            this.btRead.Location = new System.Drawing.Point(519, 50);
            this.btRead.Margin = new System.Windows.Forms.Padding(2);
            this.btRead.Name = "btRead";
            this.btRead.Size = new System.Drawing.Size(468, 29);
            this.btRead.TabIndex = 2;
            this.btRead.Text = "Read";
            this.btRead.UseVisualStyleBackColor = true;
            // 
            // btInsert
            // 
            this.btInsert.Location = new System.Drawing.Point(16, 18);
            this.btInsert.Margin = new System.Windows.Forms.Padding(2);
            this.btInsert.Name = "btInsert";
            this.btInsert.Size = new System.Drawing.Size(165, 29);
            this.btInsert.TabIndex = 3;
            this.btInsert.Text = "Insert";
            this.btInsert.UseVisualStyleBackColor = true;
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(16, 18);
            this.btDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(165, 29);
            this.btDelete.TabIndex = 4;
            this.btDelete.Text = "Delete";
            this.btDelete.UseVisualStyleBackColor = true;
            // 
            // Access
            // 
            this.Access.Location = new System.Drawing.Point(16, 54);
            this.Access.Name = "Access";
            this.Access.Size = new System.Drawing.Size(165, 20);
            this.Access.TabIndex = 5;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(16, 84);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(165, 20);
            this.name.TabIndex = 6;
            // 
            // pwd
            // 
            this.pwd.Location = new System.Drawing.Point(16, 110);
            this.pwd.Name = "pwd";
            this.pwd.Size = new System.Drawing.Size(165, 20);
            this.pwd.TabIndex = 7;
            // 
            // accesscreatelabel
            // 
            this.accesscreatelabel.AutoSize = true;
            this.accesscreatelabel.Location = new System.Drawing.Point(187, 57);
            this.accesscreatelabel.Name = "accesscreatelabel";
            this.accesscreatelabel.Size = new System.Drawing.Size(41, 13);
            this.accesscreatelabel.TabIndex = 8;
            this.accesscreatelabel.Text = "access";
            // 
            // pwdlabel
            // 
            this.pwdlabel.AutoSize = true;
            this.pwdlabel.Location = new System.Drawing.Point(187, 113);
            this.pwdlabel.Name = "pwdlabel";
            this.pwdlabel.Size = new System.Drawing.Size(27, 13);
            this.pwdlabel.TabIndex = 9;
            this.pwdlabel.Text = "pwd";
            // 
            // accesslabel
            // 
            this.accesslabel.AutoSize = true;
            this.accesslabel.Location = new System.Drawing.Point(184, 87);
            this.accesslabel.Name = "accesslabel";
            this.accesslabel.Size = new System.Drawing.Size(33, 13);
            this.accesslabel.TabIndex = 10;
            this.accesslabel.Text = "name";
            // 
            // textBoxnameDelete
            // 
            this.textBoxnameDelete.Location = new System.Drawing.Point(16, 74);
            this.textBoxnameDelete.Name = "textBoxnameDelete";
            this.textBoxnameDelete.Size = new System.Drawing.Size(165, 20);
            this.textBoxnameDelete.TabIndex = 11;
            // 
            // labelNameDelete
            // 
            this.labelNameDelete.AutoSize = true;
            this.labelNameDelete.Location = new System.Drawing.Point(13, 54);
            this.labelNameDelete.Name = "labelNameDelete";
            this.labelNameDelete.Size = new System.Drawing.Size(33, 13);
            this.labelNameDelete.TabIndex = 12;
            this.labelNameDelete.Text = "name";
            // 
            // groupBoxCreate
            // 
            this.groupBoxCreate.Controls.Add(this.btInsert);
            this.groupBoxCreate.Controls.Add(this.Access);
            this.groupBoxCreate.Controls.Add(this.name);
            this.groupBoxCreate.Controls.Add(this.pwdlabel);
            this.groupBoxCreate.Controls.Add(this.accesslabel);
            this.groupBoxCreate.Controls.Add(this.pwd);
            this.groupBoxCreate.Controls.Add(this.accesscreatelabel);
            this.groupBoxCreate.Location = new System.Drawing.Point(519, 97);
            this.groupBoxCreate.Name = "groupBoxCreate";
            this.groupBoxCreate.Size = new System.Drawing.Size(245, 142);
            this.groupBoxCreate.TabIndex = 13;
            this.groupBoxCreate.TabStop = false;
            this.groupBoxCreate.Text = "User Create";
            // 
            // groupBoxUserDelete
            // 
            this.groupBoxUserDelete.Controls.Add(this.btDelete);
            this.groupBoxUserDelete.Controls.Add(this.labelNameDelete);
            this.groupBoxUserDelete.Controls.Add(this.textBoxnameDelete);
            this.groupBoxUserDelete.Location = new System.Drawing.Point(787, 97);
            this.groupBoxUserDelete.Name = "groupBoxUserDelete";
            this.groupBoxUserDelete.Size = new System.Drawing.Size(200, 142);
            this.groupBoxUserDelete.TabIndex = 14;
            this.groupBoxUserDelete.TabStop = false;
            this.groupBoxUserDelete.Text = "User Delete";
            // 
            // FormUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBoxUserDelete);
            this.Controls.Add(this.groupBoxCreate);
            this.Controls.Add(this.btRead);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewUser);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormUser";
            this.Size = new System.Drawing.Size(1024, 276);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUser)).EndInit();
            this.groupBoxCreate.ResumeLayout(false);
            this.groupBoxCreate.PerformLayout();
            this.groupBoxUserDelete.ResumeLayout(false);
            this.groupBoxUserDelete.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView dataGridViewUser;
        internal System.Windows.Forms.Button btRead;
        internal System.Windows.Forms.Button btInsert;
        internal System.Windows.Forms.Button btDelete;
        internal System.Windows.Forms.TextBox Access;
        internal System.Windows.Forms.TextBox name;
        internal System.Windows.Forms.TextBox pwd;
        private System.Windows.Forms.Label accesscreatelabel;
        private System.Windows.Forms.Label pwdlabel;
        private System.Windows.Forms.Label accesslabel;
        internal System.Windows.Forms.TextBox textBoxnameDelete;
        private System.Windows.Forms.Label labelNameDelete;
        internal System.Windows.Forms.GroupBox groupBoxUserDelete;
        internal System.Windows.Forms.GroupBox groupBoxCreate;
    }
}

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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUser)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewUser
            // 
            this.dataGridViewUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUser.Location = new System.Drawing.Point(50, 77);
            this.dataGridViewUser.Name = "dataGridViewUser";
            this.dataGridViewUser.RowHeadersWidth = 62;
            this.dataGridViewUser.RowTemplate.Height = 28;
            this.dataGridViewUser.Size = new System.Drawing.Size(695, 249);
            this.dataGridViewUser.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Utilisateurs dans la base de données";
            // 
            // btRead
            // 
            this.btRead.Location = new System.Drawing.Point(853, 77);
            this.btRead.Name = "btRead";
            this.btRead.Size = new System.Drawing.Size(248, 44);
            this.btRead.TabIndex = 2;
            this.btRead.Text = "Read";
            this.btRead.UseVisualStyleBackColor = true;
            // 
            // btInsert
            // 
            this.btInsert.Location = new System.Drawing.Point(853, 176);
            this.btInsert.Name = "btInsert";
            this.btInsert.Size = new System.Drawing.Size(248, 44);
            this.btInsert.TabIndex = 3;
            this.btInsert.Text = "Insert";
            this.btInsert.UseVisualStyleBackColor = true;
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(853, 282);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(248, 44);
            this.btDelete.TabIndex = 4;
            this.btDelete.Text = "Delete";
            this.btDelete.UseVisualStyleBackColor = true;
            // 
            // FormUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btInsert);
            this.Controls.Add(this.btRead);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewUser);
            this.Name = "FormUser";
            this.Size = new System.Drawing.Size(1222, 424);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView dataGridViewUser;
        internal System.Windows.Forms.Button btRead;
        internal System.Windows.Forms.Button btInsert;
        internal System.Windows.Forms.Button btDelete;
    }
}

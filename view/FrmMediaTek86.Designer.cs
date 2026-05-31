namespace MediaTek86
{
    partial class FrmMediaTek86
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
            this.grbPersonnel = new System.Windows.Forms.GroupBox();
            this.btnAnnulPersonnel = new System.Windows.Forms.Button();
            this.btnEnregPersonnel = new System.Windows.Forms.Button();
            this.cboService = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.grbLesPersonnels = new System.Windows.Forms.GroupBox();
            this.btnGererAbsence = new System.Windows.Forms.Button();
            this.btnSupprimerPersonnel = new System.Windows.Forms.Button();
            this.btnModifierPersonnel = new System.Windows.Forms.Button();
            this.dgvPersonnels = new System.Windows.Forms.DataGridView();
            this.grbPersonnel.SuspendLayout();
            this.grbLesPersonnels.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonnels)).BeginInit();
            this.SuspendLayout();
            // 
            // grbPersonnel
            // 
            this.grbPersonnel.Controls.Add(this.btnAnnulPersonnel);
            this.grbPersonnel.Controls.Add(this.btnEnregPersonnel);
            this.grbPersonnel.Controls.Add(this.cboService);
            this.grbPersonnel.Controls.Add(this.label5);
            this.grbPersonnel.Controls.Add(this.label4);
            this.grbPersonnel.Controls.Add(this.label3);
            this.grbPersonnel.Controls.Add(this.label2);
            this.grbPersonnel.Controls.Add(this.txtMail);
            this.grbPersonnel.Controls.Add(this.txtTel);
            this.grbPersonnel.Controls.Add(this.txtPrenom);
            this.grbPersonnel.Controls.Add(this.label1);
            this.grbPersonnel.Controls.Add(this.txtNom);
            this.grbPersonnel.Location = new System.Drawing.Point(12, 282);
            this.grbPersonnel.Name = "grbPersonnel";
            this.grbPersonnel.Size = new System.Drawing.Size(605, 129);
            this.grbPersonnel.TabIndex = 8;
            this.grbPersonnel.TabStop = false;
            this.grbPersonnel.Text = "ajouter un personnel";
            // 
            // btnAnnulPersonnel
            // 
            this.btnAnnulPersonnel.Location = new System.Drawing.Point(87, 98);
            this.btnAnnulPersonnel.Name = "btnAnnulPersonnel";
            this.btnAnnulPersonnel.Size = new System.Drawing.Size(75, 23);
            this.btnAnnulPersonnel.TabIndex = 10;
            this.btnAnnulPersonnel.Text = "annuler";
            this.btnAnnulPersonnel.UseVisualStyleBackColor = true;
            // 
            // btnEnregPersonnel
            // 
            this.btnEnregPersonnel.Location = new System.Drawing.Point(6, 98);
            this.btnEnregPersonnel.Name = "btnEnregPersonnel";
            this.btnEnregPersonnel.Size = new System.Drawing.Size(75, 23);
            this.btnEnregPersonnel.TabIndex = 9;
            this.btnEnregPersonnel.Text = "enregistrer";
            this.btnEnregPersonnel.UseVisualStyleBackColor = true;
            // 
            // cboService
            // 
            this.cboService.FormattingEnabled = true;
            this.cboService.Location = new System.Drawing.Point(354, 71);
            this.cboService.Name = "cboService";
            this.cboService.Size = new System.Drawing.Size(161, 21);
            this.cboService.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(308, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "service";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(308, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "mail";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(308, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "tel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "prenom";
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(354, 19);
            this.txtMail.MaxLength = 50;
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(245, 20);
            this.txtMail.TabIndex = 6;
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(354, 45);
            this.txtTel.MaxLength = 15;
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(161, 20);
            this.txtTel.TabIndex = 7;
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(54, 45);
            this.txtPrenom.MaxLength = 20;
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(245, 20);
            this.txtPrenom.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "nom";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(54, 19);
            this.txtNom.MaxLength = 20;
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(245, 20);
            this.txtNom.TabIndex = 3;
            // 
            // grbLesPersonnels
            // 
            this.grbLesPersonnels.Controls.Add(this.btnGererAbsence);
            this.grbLesPersonnels.Controls.Add(this.btnSupprimerPersonnel);
            this.grbLesPersonnels.Controls.Add(this.btnModifierPersonnel);
            this.grbLesPersonnels.Controls.Add(this.dgvPersonnels);
            this.grbLesPersonnels.Location = new System.Drawing.Point(12, 12);
            this.grbLesPersonnels.Name = "grbLesPersonnels";
            this.grbLesPersonnels.Size = new System.Drawing.Size(605, 264);
            this.grbLesPersonnels.TabIndex = 7;
            this.grbLesPersonnels.TabStop = false;
            this.grbLesPersonnels.Text = "les personnels";
            // 
            // btnGererAbsence
            // 
            this.btnGererAbsence.Location = new System.Drawing.Point(168, 231);
            this.btnGererAbsence.Name = "btnGererAbsence";
            this.btnGererAbsence.Size = new System.Drawing.Size(106, 23);
            this.btnGererAbsence.TabIndex = 3;
            this.btnGererAbsence.Text = "gérer les absences";
            this.btnGererAbsence.UseVisualStyleBackColor = true;
            // 
            // btnSupprimerPersonnel
            // 
            this.btnSupprimerPersonnel.Location = new System.Drawing.Point(87, 231);
            this.btnSupprimerPersonnel.Name = "btnSupprimerPersonnel";
            this.btnSupprimerPersonnel.Size = new System.Drawing.Size(75, 23);
            this.btnSupprimerPersonnel.TabIndex = 2;
            this.btnSupprimerPersonnel.Text = "supprimer";
            this.btnSupprimerPersonnel.UseVisualStyleBackColor = true;
            // 
            // btnModifierPersonnel
            // 
            this.btnModifierPersonnel.Location = new System.Drawing.Point(6, 231);
            this.btnModifierPersonnel.Name = "btnModifierPersonnel";
            this.btnModifierPersonnel.Size = new System.Drawing.Size(75, 23);
            this.btnModifierPersonnel.TabIndex = 1;
            this.btnModifierPersonnel.Text = "modifier";
            this.btnModifierPersonnel.UseVisualStyleBackColor = true;
            // 
            // dgvPersonnels
            // 
            this.dgvPersonnels.AllowUserToAddRows = false;
            this.dgvPersonnels.AllowUserToDeleteRows = false;
            this.dgvPersonnels.AllowUserToResizeRows = false;
            this.dgvPersonnels.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonnels.Location = new System.Drawing.Point(6, 19);
            this.dgvPersonnels.MultiSelect = false;
            this.dgvPersonnels.Name = "dgvPersonnels";
            this.dgvPersonnels.ReadOnly = true;
            this.dgvPersonnels.RowHeadersVisible = false;
            this.dgvPersonnels.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvPersonnels.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPersonnels.Size = new System.Drawing.Size(581, 206);
            this.dgvPersonnels.TabIndex = 0;
            // 
            // FrmMediaTek86
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 423);
            this.Controls.Add(this.grbPersonnel);
            this.Controls.Add(this.grbLesPersonnels);
            this.Name = "FrmMediaTek86";
            this.Text = "Form1";
            this.grbPersonnel.ResumeLayout(false);
            this.grbPersonnel.PerformLayout();
            this.grbLesPersonnels.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonnels)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grbPersonnel;
        private System.Windows.Forms.Button btnAnnulPersonnel;
        private System.Windows.Forms.Button btnEnregPersonnel;
        private System.Windows.Forms.ComboBox cboService;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.GroupBox grbLesPersonnels;
        private System.Windows.Forms.Button btnGererAbsence;
        private System.Windows.Forms.Button btnSupprimerPersonnel;
        private System.Windows.Forms.Button btnModifierPersonnel;
        private System.Windows.Forms.DataGridView dgvPersonnels;
    }
}


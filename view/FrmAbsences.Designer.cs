namespace MediaTek86.view
{
    partial class FrmAbsences
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvAbsences = new System.Windows.Forms.DataGridView();
            this.btnModifierAbsence = new System.Windows.Forms.Button();
            this.btnSupprimerAbsence = new System.Windows.Forms.Button();
            this.grbAffichageAbsence = new System.Windows.Forms.GroupBox();
            this.grbAjoutAbsence = new System.Windows.Forms.GroupBox();
            this.dtpFin = new System.Windows.Forms.DateTimePicker();
            this.dtpDebut = new System.Windows.Forms.DateTimePicker();
            this.btnAnnulAbsence = new System.Windows.Forms.Button();
            this.btnEnregAbsence = new System.Windows.Forms.Button();
            this.cboMotif = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbsences)).BeginInit();
            this.grbAffichageAbsence.SuspendLayout();
            this.grbAjoutAbsence.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAbsences
            // 
            this.dgvAbsences.AllowUserToAddRows = false;
            this.dgvAbsences.AllowUserToDeleteRows = false;
            this.dgvAbsences.AllowUserToResizeRows = false;
            this.dgvAbsences.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAbsences.Location = new System.Drawing.Point(6, 19);
            this.dgvAbsences.MultiSelect = false;
            this.dgvAbsences.Name = "dgvAbsences";
            this.dgvAbsences.ReadOnly = true;
            this.dgvAbsences.RowHeadersVisible = false;
            this.dgvAbsences.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvAbsences.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAbsences.Size = new System.Drawing.Size(357, 206);
            this.dgvAbsences.TabIndex = 1;
            // 
            // btnModifierAbsence
            // 
            this.btnModifierAbsence.Location = new System.Drawing.Point(10, 231);
            this.btnModifierAbsence.Name = "btnModifierAbsence";
            this.btnModifierAbsence.Size = new System.Drawing.Size(75, 23);
            this.btnModifierAbsence.TabIndex = 3;
            this.btnModifierAbsence.Text = "modfier";
            this.btnModifierAbsence.UseVisualStyleBackColor = true;
            this.btnModifierAbsence.Click += new System.EventHandler(this.btnModifierAbsence_Click);
            // 
            // btnSupprimerAbsence
            // 
            this.btnSupprimerAbsence.Location = new System.Drawing.Point(91, 231);
            this.btnSupprimerAbsence.Name = "btnSupprimerAbsence";
            this.btnSupprimerAbsence.Size = new System.Drawing.Size(75, 23);
            this.btnSupprimerAbsence.TabIndex = 4;
            this.btnSupprimerAbsence.Text = "supprimer";
            this.btnSupprimerAbsence.UseVisualStyleBackColor = true;
            this.btnSupprimerAbsence.Click += new System.EventHandler(this.btnSupprimerAbsence_Click);
            // 
            // grbAffichageAbsence
            // 
            this.grbAffichageAbsence.Controls.Add(this.dgvAbsences);
            this.grbAffichageAbsence.Controls.Add(this.btnSupprimerAbsence);
            this.grbAffichageAbsence.Controls.Add(this.btnModifierAbsence);
            this.grbAffichageAbsence.Location = new System.Drawing.Point(12, 12);
            this.grbAffichageAbsence.Name = "grbAffichageAbsence";
            this.grbAffichageAbsence.Size = new System.Drawing.Size(388, 260);
            this.grbAffichageAbsence.TabIndex = 5;
            this.grbAffichageAbsence.TabStop = false;
            this.grbAffichageAbsence.Text = "Les absences";
            // 
            // grbAjoutAbsence
            // 
            this.grbAjoutAbsence.Controls.Add(this.dtpFin);
            this.grbAjoutAbsence.Controls.Add(this.dtpDebut);
            this.grbAjoutAbsence.Controls.Add(this.btnAnnulAbsence);
            this.grbAjoutAbsence.Controls.Add(this.btnEnregAbsence);
            this.grbAjoutAbsence.Controls.Add(this.cboMotif);
            this.grbAjoutAbsence.Controls.Add(this.label5);
            this.grbAjoutAbsence.Controls.Add(this.label2);
            this.grbAjoutAbsence.Controls.Add(this.label1);
            this.grbAjoutAbsence.Location = new System.Drawing.Point(13, 279);
            this.grbAjoutAbsence.Name = "grbAjoutAbsence";
            this.grbAjoutAbsence.Size = new System.Drawing.Size(387, 139);
            this.grbAjoutAbsence.TabIndex = 9;
            this.grbAjoutAbsence.TabStop = false;
            this.grbAjoutAbsence.Text = "ajouter une absence";
            // 
            // dtpFin
            // 
            this.dtpFin.Location = new System.Drawing.Point(87, 45);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.Size = new System.Drawing.Size(245, 20);
            this.dtpFin.TabIndex = 12;
            // 
            // dtpDebut
            // 
            this.dtpDebut.Location = new System.Drawing.Point(87, 19);
            this.dtpDebut.Name = "dtpDebut";
            this.dtpDebut.Size = new System.Drawing.Size(245, 20);
            this.dtpDebut.TabIndex = 11;
            // 
            // btnAnnulAbsence
            // 
            this.btnAnnulAbsence.Location = new System.Drawing.Point(87, 103);
            this.btnAnnulAbsence.Name = "btnAnnulAbsence";
            this.btnAnnulAbsence.Size = new System.Drawing.Size(75, 23);
            this.btnAnnulAbsence.TabIndex = 10;
            this.btnAnnulAbsence.Text = "annuler";
            this.btnAnnulAbsence.UseVisualStyleBackColor = true;
            this.btnAnnulAbsence.Click += new System.EventHandler(this.btnAnnulAbsence_Click);
            // 
            // btnEnregAbsence
            // 
            this.btnEnregAbsence.Location = new System.Drawing.Point(9, 103);
            this.btnEnregAbsence.Name = "btnEnregAbsence";
            this.btnEnregAbsence.Size = new System.Drawing.Size(75, 23);
            this.btnEnregAbsence.TabIndex = 9;
            this.btnEnregAbsence.Text = "enregistrer";
            this.btnEnregAbsence.UseVisualStyleBackColor = true;
            this.btnEnregAbsence.Click += new System.EventHandler(this.btnEnregAbsence_Click);
            // 
            // cboMotif
            // 
            this.cboMotif.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMotif.FormattingEnabled = true;
            this.cboMotif.Location = new System.Drawing.Point(87, 71);
            this.cboMotif.Name = "cboMotif";
            this.cboMotif.Size = new System.Drawing.Size(245, 21);
            this.cboMotif.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "motif";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "date de fin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "date de début";
            // 
            // FrmAbsences
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 435);
            this.Controls.Add(this.grbAjoutAbsence);
            this.Controls.Add(this.grbAffichageAbsence);
            this.Name = "FrmAbsences";
            this.Text = "FrmAbsences";
            this.Load += new System.EventHandler(this.FrmAbsences_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbsences)).EndInit();
            this.grbAffichageAbsence.ResumeLayout(false);
            this.grbAjoutAbsence.ResumeLayout(false);
            this.grbAjoutAbsence.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAbsences;
        private System.Windows.Forms.Button btnModifierAbsence;
        private System.Windows.Forms.Button btnSupprimerAbsence;
        private System.Windows.Forms.GroupBox grbAffichageAbsence;
        private System.Windows.Forms.GroupBox grbAjoutAbsence;
        private System.Windows.Forms.Button btnAnnulAbsence;
        private System.Windows.Forms.Button btnEnregAbsence;
        private System.Windows.Forms.ComboBox cboMotif;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFin;
        private System.Windows.Forms.DateTimePicker dtpDebut;
    }
}
namespace Gestion_Employé
{
    partial class Fcongé
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Liste = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BEtat = new System.Windows.Forms.Button();
            this.BAjouter = new System.Windows.Forms.Button();
            this.BSupprimer = new System.Windows.Forms.Button();
            this.BModifier = new System.Windows.Forms.Button();
            this.BFermer = new System.Windows.Forms.Button();
            this.CBMatricule = new System.Windows.Forms.ComboBox();
            this.TDate = new System.Windows.Forms.MaskedTextBox();
            this.Ttype = new System.Windows.Forms.TextBox();
            this.TDurée = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(247, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "-  Gestion des Congés  -";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(132, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Matricule :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(112, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Date Congé :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(165, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Type :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(156, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Durée :";
            // 
            // Liste
            // 
            this.Liste.AllowUserToAddRows = false;
            this.Liste.AllowUserToDeleteRows = false;
            this.Liste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Liste.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.Liste.Location = new System.Drawing.Point(134, 312);
            this.Liste.Name = "Liste";
            this.Liste.ReadOnly = true;
            this.Liste.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Liste.Size = new System.Drawing.Size(443, 150);
            this.Liste.TabIndex = 5;
            this.Liste.Click += new System.EventHandler(this.Liste_Click);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Matricule";
            this.Column1.HeaderText = "Matricule";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Date_congé";
            this.Column2.HeaderText = "Date Congé";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Type_congé";
            this.Column3.HeaderText = "Type";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Durée";
            this.Column4.HeaderText = "Durée";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // BEtat
            // 
            this.BEtat.Location = new System.Drawing.Point(545, 100);
            this.BEtat.Name = "BEtat";
            this.BEtat.Size = new System.Drawing.Size(75, 23);
            this.BEtat.TabIndex = 6;
            this.BEtat.Text = "Etat";
            this.BEtat.UseVisualStyleBackColor = true;
            // 
            // BAjouter
            // 
            this.BAjouter.Location = new System.Drawing.Point(545, 129);
            this.BAjouter.Name = "BAjouter";
            this.BAjouter.Size = new System.Drawing.Size(75, 23);
            this.BAjouter.TabIndex = 7;
            this.BAjouter.Text = "Ajouter";
            this.BAjouter.UseVisualStyleBackColor = true;
            this.BAjouter.Click += new System.EventHandler(this.BAjouter_Click);
            // 
            // BSupprimer
            // 
            this.BSupprimer.Location = new System.Drawing.Point(545, 158);
            this.BSupprimer.Name = "BSupprimer";
            this.BSupprimer.Size = new System.Drawing.Size(75, 23);
            this.BSupprimer.TabIndex = 8;
            this.BSupprimer.Text = "Supprimer";
            this.BSupprimer.UseVisualStyleBackColor = true;
            this.BSupprimer.Click += new System.EventHandler(this.BSupprimer_Click);
            // 
            // BModifier
            // 
            this.BModifier.Location = new System.Drawing.Point(545, 187);
            this.BModifier.Name = "BModifier";
            this.BModifier.Size = new System.Drawing.Size(75, 23);
            this.BModifier.TabIndex = 9;
            this.BModifier.Text = "Modifier";
            this.BModifier.UseVisualStyleBackColor = true;
            this.BModifier.Click += new System.EventHandler(this.BModifier_Click);
            // 
            // BFermer
            // 
            this.BFermer.Location = new System.Drawing.Point(545, 216);
            this.BFermer.Name = "BFermer";
            this.BFermer.Size = new System.Drawing.Size(75, 23);
            this.BFermer.TabIndex = 10;
            this.BFermer.Text = "Fermer";
            this.BFermer.UseVisualStyleBackColor = true;
            // 
            // CBMatricule
            // 
            this.CBMatricule.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBMatricule.FormattingEnabled = true;
            this.CBMatricule.Location = new System.Drawing.Point(260, 102);
            this.CBMatricule.Name = "CBMatricule";
            this.CBMatricule.Size = new System.Drawing.Size(114, 21);
            this.CBMatricule.TabIndex = 11;
            this.CBMatricule.SelectedIndexChanged += new System.EventHandler(this.CBMatricule_SelectedIndexChanged);
            // 
            // TDate
            // 
            this.TDate.Location = new System.Drawing.Point(261, 140);
            this.TDate.Mask = "00/00/0000";
            this.TDate.Name = "TDate";
            this.TDate.Size = new System.Drawing.Size(69, 20);
            this.TDate.TabIndex = 12;
            this.TDate.ValidatingType = typeof(System.DateTime);
            this.TDate.Leave += new System.EventHandler(this.TDate_Leave);
            // 
            // Ttype
            // 
            this.Ttype.Location = new System.Drawing.Point(260, 176);
            this.Ttype.Name = "Ttype";
            this.Ttype.Size = new System.Drawing.Size(114, 20);
            this.Ttype.TabIndex = 13;
            this.Ttype.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // TDurée
            // 
            this.TDurée.Location = new System.Drawing.Point(260, 214);
            this.TDurée.Name = "TDurée";
            this.TDurée.Size = new System.Drawing.Size(70, 20);
            this.TDurée.TabIndex = 14;
            this.TDurée.Leave += new System.EventHandler(this.TDurée_Leave);
            // 
            // Fcongé
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 483);
            this.Controls.Add(this.TDurée);
            this.Controls.Add(this.Ttype);
            this.Controls.Add(this.TDate);
            this.Controls.Add(this.CBMatricule);
            this.Controls.Add(this.BFermer);
            this.Controls.Add(this.BModifier);
            this.Controls.Add(this.BSupprimer);
            this.Controls.Add(this.BAjouter);
            this.Controls.Add(this.BEtat);
            this.Controls.Add(this.Liste);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Fcongé";
            this.Text = "Fcongé";
            this.Load += new System.EventHandler(this.Fcongé_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView Liste;
        private System.Windows.Forms.Button BEtat;
        private System.Windows.Forms.Button BAjouter;
        private System.Windows.Forms.Button BSupprimer;
        private System.Windows.Forms.Button BModifier;
        private System.Windows.Forms.Button BFermer;
        private System.Windows.Forms.ComboBox CBMatricule;
        private System.Windows.Forms.MaskedTextBox TDate;
        private System.Windows.Forms.TextBox Ttype;
        private System.Windows.Forms.TextBox TDurée;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}
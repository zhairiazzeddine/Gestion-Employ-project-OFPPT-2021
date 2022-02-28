namespace Gestion_Employé
{
    partial class Fcongé_employé
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
            this.Tsum = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Liste_C = new System.Windows.Forms.DataGridView();
            this.BFermer = new System.Windows.Forms.Button();
            this.BEtat = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.CBMatricule = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Liste_C)).BeginInit();
            this.SuspendLayout();
            // 
            // Tsum
            // 
            this.Tsum.Location = new System.Drawing.Point(654, 425);
            this.Tsum.Name = "Tsum";
            this.Tsum.Size = new System.Drawing.Size(84, 20);
            this.Tsum.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(545, 425);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 18);
            this.label3.TabIndex = 14;
            this.label3.Text = "Dureé Total :";
            // 
            // Liste_C
            // 
            this.Liste_C.AllowUserToAddRows = false;
            this.Liste_C.AllowUserToDeleteRows = false;
            this.Liste_C.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Liste_C.Location = new System.Drawing.Point(62, 260);
            this.Liste_C.Name = "Liste_C";
            this.Liste_C.ReadOnly = true;
            this.Liste_C.Size = new System.Drawing.Size(676, 150);
            this.Liste_C.TabIndex = 13;
            // 
            // BFermer
            // 
            this.BFermer.Location = new System.Drawing.Point(580, 138);
            this.BFermer.Name = "BFermer";
            this.BFermer.Size = new System.Drawing.Size(75, 23);
            this.BFermer.TabIndex = 12;
            this.BFermer.Text = "Fermer";
            this.BFermer.UseVisualStyleBackColor = true;
            // 
            // BEtat
            // 
            this.BEtat.Location = new System.Drawing.Point(580, 98);
            this.BEtat.Name = "BEtat";
            this.BEtat.Size = new System.Drawing.Size(75, 23);
            this.BEtat.TabIndex = 11;
            this.BEtat.Text = "Etat";
            this.BEtat.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(88, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "Matricule Employé :";
            // 
            // CBMatricule
            // 
            this.CBMatricule.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBMatricule.FormattingEnabled = true;
            this.CBMatricule.Location = new System.Drawing.Point(258, 120);
            this.CBMatricule.Name = "CBMatricule";
            this.CBMatricule.Size = new System.Drawing.Size(121, 21);
            this.CBMatricule.TabIndex = 9;
            this.CBMatricule.SelectedIndexChanged += new System.EventHandler(this.CBMatricule_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(221, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "-  Liste des Congés par Employé  -";
            // 
            // Fcongé_employé
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 469);
            this.Controls.Add(this.Tsum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Liste_C);
            this.Controls.Add(this.BFermer);
            this.Controls.Add(this.BEtat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CBMatricule);
            this.Controls.Add(this.label1);
            this.Name = "Fcongé_employé";
            this.Text = "Fcongé_employé";
            this.Load += new System.EventHandler(this.Fcongé_employé_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Liste_C)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Tsum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView Liste_C;
        private System.Windows.Forms.Button BFermer;
        private System.Windows.Forms.Button BEtat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CBMatricule;
        private System.Windows.Forms.Label label1;
    }
}
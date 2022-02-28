namespace Gestion_Employé
{
    partial class Fcongé_année_mois
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
            this.Liste = new System.Windows.Forms.DataGridView();
            this.BFermer = new System.Windows.Forms.Button();
            this.BEtat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).BeginInit();
            this.SuspendLayout();
            // 
            // Liste
            // 
            this.Liste.AllowUserToAddRows = false;
            this.Liste.AllowUserToDeleteRows = false;
            this.Liste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Liste.Location = new System.Drawing.Point(163, 257);
            this.Liste.Name = "Liste";
            this.Liste.ReadOnly = true;
            this.Liste.Size = new System.Drawing.Size(444, 173);
            this.Liste.TabIndex = 25;
            // 
            // BFermer
            // 
            this.BFermer.Location = new System.Drawing.Point(596, 142);
            this.BFermer.Name = "BFermer";
            this.BFermer.Size = new System.Drawing.Size(75, 23);
            this.BFermer.TabIndex = 24;
            this.BFermer.Text = "Fermer";
            this.BFermer.UseVisualStyleBackColor = true;
            // 
            // BEtat
            // 
            this.BEtat.Location = new System.Drawing.Point(596, 102);
            this.BEtat.Name = "BEtat";
            this.BEtat.Size = new System.Drawing.Size(75, 23);
            this.BEtat.TabIndex = 23;
            this.BEtat.Text = "Etat";
            this.BEtat.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(203, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(386, 24);
            this.label1.TabIndex = 22;
            this.label1.Text = "-  Dureé Congé par Mois et par Anneé  -";
            // 
            // Fcongé_année_mois
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Liste);
            this.Controls.Add(this.BFermer);
            this.Controls.Add(this.BEtat);
            this.Controls.Add(this.label1);
            this.Name = "Fcongé_année_mois";
            this.Text = "Fcongé_année_mois";
            this.Load += new System.EventHandler(this.Fcongé_année_mois_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Liste;
        private System.Windows.Forms.Button BFermer;
        private System.Windows.Forms.Button BEtat;
        private System.Windows.Forms.Label label1;
    }
}
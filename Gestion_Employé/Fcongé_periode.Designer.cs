namespace Gestion_Employé
{
    partial class Fcongé_periode
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Tdate1 = new System.Windows.Forms.MaskedTextBox();
            this.Tdate2 = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).BeginInit();
            this.SuspendLayout();
            // 
            // Liste
            // 
            this.Liste.AllowUserToAddRows = false;
            this.Liste.AllowUserToDeleteRows = false;
            this.Liste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Liste.Location = new System.Drawing.Point(62, 251);
            this.Liste.Name = "Liste";
            this.Liste.ReadOnly = true;
            this.Liste.Size = new System.Drawing.Size(676, 173);
            this.Liste.TabIndex = 13;
            // 
            // BFermer
            // 
            this.BFermer.Location = new System.Drawing.Point(596, 136);
            this.BFermer.Name = "BFermer";
            this.BFermer.Size = new System.Drawing.Size(75, 23);
            this.BFermer.TabIndex = 12;
            this.BFermer.Text = "Fermer";
            this.BFermer.UseVisualStyleBackColor = true;
            // 
            // BEtat
            // 
            this.BEtat.Location = new System.Drawing.Point(596, 96);
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
            this.label2.Location = new System.Drawing.Point(195, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "du :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(221, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(314, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "-  Liste des Congé par Période  -";
            // 
            // Tdate1
            // 
            this.Tdate1.Location = new System.Drawing.Point(238, 187);
            this.Tdate1.Mask = "00/00/0000";
            this.Tdate1.Name = "Tdate1";
            this.Tdate1.Size = new System.Drawing.Size(100, 20);
            this.Tdate1.TabIndex = 14;
            this.Tdate1.ValidatingType = typeof(System.DateTime);
            this.Tdate1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tdate1_KeyPress);
            // 
            // Tdate2
            // 
            this.Tdate2.Location = new System.Drawing.Point(449, 188);
            this.Tdate2.Mask = "00/00/0000";
            this.Tdate2.Name = "Tdate2";
            this.Tdate2.Size = new System.Drawing.Size(100, 20);
            this.Tdate2.TabIndex = 16;
            this.Tdate2.ValidatingType = typeof(System.DateTime);
            this.Tdate2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tdate2_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(409, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 18);
            this.label3.TabIndex = 15;
            this.label3.Text = "au :";
            // 
            // Fcongé_periode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Tdate2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Tdate1);
            this.Controls.Add(this.Liste);
            this.Controls.Add(this.BFermer);
            this.Controls.Add(this.BEtat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Fcongé_periode";
            this.Text = "Fcongé_periode";
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView Liste;
        private System.Windows.Forms.Button BFermer;
        private System.Windows.Forms.Button BEtat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox Tdate1;
        private System.Windows.Forms.MaskedTextBox Tdate2;
        private System.Windows.Forms.Label label3;
    }
}
namespace Gestion_Employé
{
    partial class FService
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
            this.BEtat = new System.Windows.Forms.Button();
            this.BAjouter = new System.Windows.Forms.Button();
            this.BSupprimer = new System.Windows.Forms.Button();
            this.BModifier = new System.Windows.Forms.Button();
            this.BFermer = new System.Windows.Forms.Button();
            this.Tcode = new System.Windows.Forms.TextBox();
            this.Tlibellé = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Liste = new System.Windows.Forms.DataGridView();
            this.CoCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CoLibellé = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(254, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "- Gestion des Services -";
            // 
            // BEtat
            // 
            this.BEtat.Location = new System.Drawing.Point(651, 77);
            this.BEtat.Name = "BEtat";
            this.BEtat.Size = new System.Drawing.Size(82, 28);
            this.BEtat.TabIndex = 1;
            this.BEtat.Text = "Etat";
            this.BEtat.UseVisualStyleBackColor = true;
            // 
            // BAjouter
            // 
            this.BAjouter.Location = new System.Drawing.Point(651, 114);
            this.BAjouter.Name = "BAjouter";
            this.BAjouter.Size = new System.Drawing.Size(82, 28);
            this.BAjouter.TabIndex = 2;
            this.BAjouter.Text = "Ajouter";
            this.BAjouter.UseVisualStyleBackColor = true;
            this.BAjouter.Click += new System.EventHandler(this.BAjouter_Click);
            // 
            // BSupprimer
            // 
            this.BSupprimer.Location = new System.Drawing.Point(651, 154);
            this.BSupprimer.Name = "BSupprimer";
            this.BSupprimer.Size = new System.Drawing.Size(82, 28);
            this.BSupprimer.TabIndex = 3;
            this.BSupprimer.Text = "Supprimer";
            this.BSupprimer.UseVisualStyleBackColor = true;
            this.BSupprimer.Click += new System.EventHandler(this.BSupprimer_Click);
            // 
            // BModifier
            // 
            this.BModifier.Location = new System.Drawing.Point(651, 196);
            this.BModifier.Name = "BModifier";
            this.BModifier.Size = new System.Drawing.Size(82, 28);
            this.BModifier.TabIndex = 4;
            this.BModifier.Text = "Modifier";
            this.BModifier.UseVisualStyleBackColor = true;
            this.BModifier.Click += new System.EventHandler(this.BModifier_Click);
            // 
            // BFermer
            // 
            this.BFermer.Location = new System.Drawing.Point(651, 239);
            this.BFermer.Name = "BFermer";
            this.BFermer.Size = new System.Drawing.Size(82, 28);
            this.BFermer.TabIndex = 5;
            this.BFermer.Text = "Fermer";
            this.BFermer.UseVisualStyleBackColor = true;
            this.BFermer.Click += new System.EventHandler(this.BFermer_Click);
            // 
            // Tcode
            // 
            this.Tcode.Location = new System.Drawing.Point(280, 142);
            this.Tcode.Name = "Tcode";
            this.Tcode.Size = new System.Drawing.Size(226, 20);
            this.Tcode.TabIndex = 6;
            this.Tcode.Leave += new System.EventHandler(this.Tcode_Leave);
            // 
            // Tlibellé
            // 
            this.Tlibellé.Location = new System.Drawing.Point(280, 188);
            this.Tlibellé.Name = "Tlibellé";
            this.Tlibellé.Size = new System.Drawing.Size(226, 20);
            this.Tlibellé.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(195, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "Code :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(185, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 19);
            this.label3.TabIndex = 9;
            this.label3.Text = "Libellé :";
            // 
            // Liste
            // 
            this.Liste.AllowUserToAddRows = false;
            this.Liste.AllowUserToDeleteRows = false;
            this.Liste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Liste.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CoCode,
            this.CoLibellé});
            this.Liste.Location = new System.Drawing.Point(97, 301);
            this.Liste.Name = "Liste";
            this.Liste.ReadOnly = true;
            this.Liste.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Liste.Size = new System.Drawing.Size(594, 164);
            this.Liste.TabIndex = 10;
            this.Liste.Click += new System.EventHandler(this.Liste_Click);
            // 
            // CoCode
            // 
            this.CoCode.DataPropertyName = "Code";
            this.CoCode.HeaderText = "Code";
            this.CoCode.Name = "CoCode";
            this.CoCode.ReadOnly = true;
            this.CoCode.Width = 200;
            // 
            // CoLibellé
            // 
            this.CoLibellé.DataPropertyName = "Libellé";
            this.CoLibellé.HeaderText = "Libellé";
            this.CoLibellé.Name = "CoLibellé";
            this.CoLibellé.ReadOnly = true;
            this.CoLibellé.Width = 350;
            // 
            // FService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 494);
            this.Controls.Add(this.Liste);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Tlibellé);
            this.Controls.Add(this.Tcode);
            this.Controls.Add(this.BFermer);
            this.Controls.Add(this.BModifier);
            this.Controls.Add(this.BSupprimer);
            this.Controls.Add(this.BAjouter);
            this.Controls.Add(this.BEtat);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FService";
            this.Text = "Gestion_des_Services";
            this.Load += new System.EventHandler(this.FService_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BEtat;
        private System.Windows.Forms.Button BAjouter;
        private System.Windows.Forms.Button BSupprimer;
        private System.Windows.Forms.Button BModifier;
        private System.Windows.Forms.Button BFermer;
        private System.Windows.Forms.TextBox Tcode;
        private System.Windows.Forms.TextBox Tlibellé;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView Liste;
        private System.Windows.Forms.DataGridViewTextBoxColumn CoCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn CoLibellé;
    }
}
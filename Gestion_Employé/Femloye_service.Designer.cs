namespace Gestion_Employé
{
    partial class Femloye_service
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
            this.CBService = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BEtat = new System.Windows.Forms.Button();
            this.BFermer = new System.Windows.Forms.Button();
            this.Liste = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.Tnbr = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(181, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(341, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "-  Liste des Employés par Service  -";
            // 
            // CBService
            // 
            this.CBService.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBService.FormattingEnabled = true;
            this.CBService.Location = new System.Drawing.Point(218, 129);
            this.CBService.Name = "CBService";
            this.CBService.Size = new System.Drawing.Size(121, 21);
            this.CBService.TabIndex = 1;
            this.CBService.SelectedIndexChanged += new System.EventHandler(this.CBService_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(78, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Code Service :";
            // 
            // BEtat
            // 
            this.BEtat.Location = new System.Drawing.Point(540, 107);
            this.BEtat.Name = "BEtat";
            this.BEtat.Size = new System.Drawing.Size(75, 23);
            this.BEtat.TabIndex = 3;
            this.BEtat.Text = "Etat";
            this.BEtat.UseVisualStyleBackColor = true;
            // 
            // BFermer
            // 
            this.BFermer.Location = new System.Drawing.Point(540, 147);
            this.BFermer.Name = "BFermer";
            this.BFermer.Size = new System.Drawing.Size(75, 23);
            this.BFermer.TabIndex = 4;
            this.BFermer.Text = "Fermer";
            this.BFermer.UseVisualStyleBackColor = true;
            // 
            // Liste
            // 
            this.Liste.AllowUserToAddRows = false;
            this.Liste.AllowUserToDeleteRows = false;
            this.Liste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Liste.Location = new System.Drawing.Point(22, 269);
            this.Liste.Name = "Liste";
            this.Liste.ReadOnly = true;
            this.Liste.Size = new System.Drawing.Size(676, 150);
            this.Liste.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(529, 434);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nombre :";
            // 
            // Tnbr
            // 
            this.Tnbr.Location = new System.Drawing.Point(614, 434);
            this.Tnbr.Name = "Tnbr";
            this.Tnbr.Size = new System.Drawing.Size(84, 20);
            this.Tnbr.TabIndex = 7;
            // 
            // Femloye_service
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 466);
            this.Controls.Add(this.Tnbr);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Liste);
            this.Controls.Add(this.BFermer);
            this.Controls.Add(this.BEtat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CBService);
            this.Controls.Add(this.label1);
            this.Name = "Femloye_service";
            this.Text = "Femloye_service";
            this.Load += new System.EventHandler(this.Femloye_service_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CBService;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BEtat;
        private System.Windows.Forms.Button BFermer;
        private System.Windows.Forms.DataGridView Liste;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Tnbr;
    }
}
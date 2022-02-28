namespace Gestion_Employé
{
    partial class Fconnexion
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Bok = new System.Windows.Forms.Button();
            this.Bannuler = new System.Windows.Forms.Button();
            this.Tnom = new System.Windows.Forms.TextBox();
            this.Tpasse = new System.Windows.Forms.TextBox();
            this.Time = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.T = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(222, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(222, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mot de passe :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(328, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "-   CONNEXION   -";
            // 
            // Bok
            // 
            this.Bok.Location = new System.Drawing.Point(283, 189);
            this.Bok.Name = "Bok";
            this.Bok.Size = new System.Drawing.Size(75, 23);
            this.Bok.TabIndex = 3;
            this.Bok.Text = "OK";
            this.Bok.UseVisualStyleBackColor = true;
            this.Bok.Click += new System.EventHandler(this.Bok_Click);
            this.Bok.MouseEnter += new System.EventHandler(this.Bok_MouseEnter);
            this.Bok.MouseLeave += new System.EventHandler(this.Bok_MouseLeave);
            this.Bok.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Bok_MouseMove);
            this.Bok.Move += new System.EventHandler(this.Bok_Move);
            // 
            // Bannuler
            // 
            this.Bannuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Bannuler.Location = new System.Drawing.Point(390, 189);
            this.Bannuler.Name = "Bannuler";
            this.Bannuler.Size = new System.Drawing.Size(75, 23);
            this.Bannuler.TabIndex = 4;
            this.Bannuler.Text = "Annuler";
            this.Bannuler.UseVisualStyleBackColor = true;
            this.Bannuler.Click += new System.EventHandler(this.Bannuler_Click);
            this.Bannuler.MouseEnter += new System.EventHandler(this.Bannuler_MouseEnter);
            this.Bannuler.MouseLeave += new System.EventHandler(this.Bannuler_MouseLeave);
            // 
            // Tnom
            // 
            this.Tnom.Location = new System.Drawing.Point(367, 88);
            this.Tnom.Name = "Tnom";
            this.Tnom.Size = new System.Drawing.Size(176, 20);
            this.Tnom.TabIndex = 5;
            this.Tnom.TextChanged += new System.EventHandler(this.Tnom_TextChanged);
            // 
            // Tpasse
            // 
            this.Tpasse.Location = new System.Drawing.Point(367, 122);
            this.Tpasse.Name = "Tpasse";
            this.Tpasse.Size = new System.Drawing.Size(176, 20);
            this.Tpasse.TabIndex = 6;
            this.Tpasse.TextChanged += new System.EventHandler(this.Tpasse_TextChanged);
            this.Tpasse.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tpasse_KeyPress);
            // 
            // Time
            // 
            this.Time.AutoSize = true;
            this.Time.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Time.Location = new System.Drawing.Point(627, 210);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(0, 15);
            this.Time.TabIndex = 7;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // T
            // 
            this.T.AutoSize = true;
            this.T.Location = new System.Drawing.Point(618, 209);
            this.T.Name = "T";
            this.T.Size = new System.Drawing.Size(0, 13);
            this.T.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Gestion_Employé.Properties.Resources.icn;
            this.pictureBox1.Location = new System.Drawing.Point(62, 97);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 45);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // Fconnexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Bannuler;
            this.ClientSize = new System.Drawing.Size(808, 236);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.T);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.Tpasse);
            this.Controls.Add(this.Tnom);
            this.Controls.Add(this.Bannuler);
            this.Controls.Add(this.Bok);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Fconnexion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connexion";
            this.Load += new System.EventHandler(this.Fconnexion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Bok;
        private System.Windows.Forms.Button Bannuler;
        private System.Windows.Forms.TextBox Tnom;
        private System.Windows.Forms.TextBox Tpasse;
        private System.Windows.Forms.Label Time;
        private System.Windows.Forms.Label T;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}


namespace Gestion_Employé
{
    partial class Femployé
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
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Liste = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tmatricule = new System.Windows.Forms.TextBox();
            this.Tnom = new System.Windows.Forms.TextBox();
            this.Tprénom = new System.Windows.Forms.TextBox();
            this.Tgrade = new System.Windows.Forms.TextBox();
            this.Techelle = new System.Windows.Forms.TextBox();
            this.TDate = new System.Windows.Forms.MaskedTextBox();
            this.CBService = new System.Windows.Forms.ComboBox();
            this.Rnom = new System.Windows.Forms.TextBox();
            this.Betat = new System.Windows.Forms.Button();
            this.Bajouter = new System.Windows.Forms.Button();
            this.BSupprimer = new System.Windows.Forms.Button();
            this.BModifier = new System.Windows.Forms.Button();
            this.BFermer = new System.Windows.Forms.Button();
            this.BexportXML = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(285, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "-  Gestion des Employés  -";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(154, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Matricule :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(185, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nom :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(165, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Prénom :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(113, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Date Naissance :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(177, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "Grade :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(172, 263);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 19);
            this.label7.TabIndex = 6;
            this.label7.Text = "Echelle :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(132, 294);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 19);
            this.label8.TabIndex = 7;
            this.label8.Text = "Code Service :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(36, 387);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(155, 19);
            this.label9.TabIndex = 8;
            this.label9.Text = "Recherche par Nom :";
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
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.Liste.Location = new System.Drawing.Point(29, 413);
            this.Liste.Name = "Liste";
            this.Liste.ReadOnly = true;
            this.Liste.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Liste.Size = new System.Drawing.Size(744, 175);
            this.Liste.TabIndex = 9;
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
            this.Column2.DataPropertyName = "Nom";
            this.Column2.HeaderText = "Nom";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Prénom";
            this.Column3.HeaderText = "Prénom";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Date_naissance";
            this.Column4.HeaderText = "Date Naissance";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Grade";
            this.Column5.HeaderText = "Grade";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Echelle";
            this.Column6.HeaderText = "Echelle";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "Code_service";
            this.Column7.HeaderText = "Code Service";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Tmatricule
            // 
            this.Tmatricule.Location = new System.Drawing.Point(243, 111);
            this.Tmatricule.Name = "Tmatricule";
            this.Tmatricule.Size = new System.Drawing.Size(149, 20);
            this.Tmatricule.TabIndex = 10;
            this.Tmatricule.TextChanged += new System.EventHandler(this.Tmatricule_TextChanged);
            this.Tmatricule.Leave += new System.EventHandler(this.Tmatricule_Leave);
            // 
            // Tnom
            // 
            this.Tnom.Location = new System.Drawing.Point(243, 141);
            this.Tnom.Name = "Tnom";
            this.Tnom.Size = new System.Drawing.Size(131, 20);
            this.Tnom.TabIndex = 11;
            // 
            // Tprénom
            // 
            this.Tprénom.Location = new System.Drawing.Point(243, 170);
            this.Tprénom.Name = "Tprénom";
            this.Tprénom.Size = new System.Drawing.Size(120, 20);
            this.Tprénom.TabIndex = 12;
            // 
            // Tgrade
            // 
            this.Tgrade.Location = new System.Drawing.Point(242, 229);
            this.Tgrade.Name = "Tgrade";
            this.Tgrade.Size = new System.Drawing.Size(57, 20);
            this.Tgrade.TabIndex = 13;
            // 
            // Techelle
            // 
            this.Techelle.Location = new System.Drawing.Point(243, 263);
            this.Techelle.Name = "Techelle";
            this.Techelle.Size = new System.Drawing.Size(45, 20);
            this.Techelle.TabIndex = 14;
            this.Techelle.Leave += new System.EventHandler(this.Techelle_Leave);
            // 
            // TDate
            // 
            this.TDate.Location = new System.Drawing.Point(244, 197);
            this.TDate.Mask = "00/00/0000";
            this.TDate.Name = "TDate";
            this.TDate.Size = new System.Drawing.Size(67, 20);
            this.TDate.TabIndex = 15;
            this.TDate.ValidatingType = typeof(System.DateTime);
            this.TDate.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            this.TDate.Leave += new System.EventHandler(this.TDate_Leave);
            // 
            // CBService
            // 
            this.CBService.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBService.FormattingEnabled = true;
            this.CBService.Location = new System.Drawing.Point(242, 294);
            this.CBService.Name = "CBService";
            this.CBService.Size = new System.Drawing.Size(121, 21);
            this.CBService.TabIndex = 16;
            // 
            // Rnom
            // 
            this.Rnom.Location = new System.Drawing.Point(197, 387);
            this.Rnom.Name = "Rnom";
            this.Rnom.Size = new System.Drawing.Size(124, 20);
            this.Rnom.TabIndex = 17;
            this.Rnom.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // Betat
            // 
            this.Betat.Location = new System.Drawing.Point(541, 130);
            this.Betat.Name = "Betat";
            this.Betat.Size = new System.Drawing.Size(81, 26);
            this.Betat.TabIndex = 18;
            this.Betat.Text = "Etat";
            this.Betat.UseVisualStyleBackColor = true;
            this.Betat.Click += new System.EventHandler(this.button1_Click);
            // 
            // Bajouter
            // 
            this.Bajouter.BackColor = System.Drawing.Color.Lime;
            this.Bajouter.ForeColor = System.Drawing.Color.Black;
            this.Bajouter.Location = new System.Drawing.Point(541, 163);
            this.Bajouter.Name = "Bajouter";
            this.Bajouter.Size = new System.Drawing.Size(81, 26);
            this.Bajouter.TabIndex = 19;
            this.Bajouter.Text = "Ajouter";
            this.Bajouter.UseVisualStyleBackColor = false;
            this.Bajouter.Click += new System.EventHandler(this.Bajouter_Click);
            // 
            // BSupprimer
            // 
            this.BSupprimer.BackColor = System.Drawing.Color.LightCoral;
            this.BSupprimer.Location = new System.Drawing.Point(541, 195);
            this.BSupprimer.Name = "BSupprimer";
            this.BSupprimer.Size = new System.Drawing.Size(81, 26);
            this.BSupprimer.TabIndex = 20;
            this.BSupprimer.Text = "Supprimer";
            this.BSupprimer.UseVisualStyleBackColor = false;
            this.BSupprimer.Click += new System.EventHandler(this.BSupprimer_Click);
            // 
            // BModifier
            // 
            this.BModifier.BackColor = System.Drawing.Color.Turquoise;
            this.BModifier.Location = new System.Drawing.Point(541, 227);
            this.BModifier.Name = "BModifier";
            this.BModifier.Size = new System.Drawing.Size(81, 26);
            this.BModifier.TabIndex = 21;
            this.BModifier.Text = "Modifier";
            this.BModifier.UseVisualStyleBackColor = false;
            this.BModifier.Click += new System.EventHandler(this.button4_Click);
            // 
            // BFermer
            // 
            this.BFermer.BackColor = System.Drawing.Color.Red;
            this.BFermer.Location = new System.Drawing.Point(541, 259);
            this.BFermer.Name = "BFermer";
            this.BFermer.Size = new System.Drawing.Size(81, 26);
            this.BFermer.TabIndex = 22;
            this.BFermer.Text = "Fermer";
            this.BFermer.UseVisualStyleBackColor = false;
            this.BFermer.Click += new System.EventHandler(this.BFermer_Click);
            // 
            // BexportXML
            // 
            this.BexportXML.Location = new System.Drawing.Point(541, 294);
            this.BexportXML.Name = "BexportXML";
            this.BexportXML.Size = new System.Drawing.Size(81, 23);
            this.BexportXML.TabIndex = 23;
            this.BexportXML.Text = "Export XML";
            this.BexportXML.UseVisualStyleBackColor = true;
            this.BexportXML.Click += new System.EventHandler(this.BexportXML_Click);
            // 
            // Femployé
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.BexportXML);
            this.Controls.Add(this.BFermer);
            this.Controls.Add(this.BModifier);
            this.Controls.Add(this.BSupprimer);
            this.Controls.Add(this.Bajouter);
            this.Controls.Add(this.Betat);
            this.Controls.Add(this.Rnom);
            this.Controls.Add(this.CBService);
            this.Controls.Add(this.TDate);
            this.Controls.Add(this.Techelle);
            this.Controls.Add(this.Tgrade);
            this.Controls.Add(this.Tprénom);
            this.Controls.Add(this.Tnom);
            this.Controls.Add(this.Tmatricule);
            this.Controls.Add(this.Liste);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Femployé";
            this.Text = "Femployé";
            this.Load += new System.EventHandler(this.Femployé_Load);
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
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView Liste;
        private System.Windows.Forms.TextBox Tmatricule;
        private System.Windows.Forms.TextBox Tnom;
        private System.Windows.Forms.TextBox Tprénom;
        private System.Windows.Forms.TextBox Tgrade;
        private System.Windows.Forms.TextBox Techelle;
        private System.Windows.Forms.MaskedTextBox TDate;
        private System.Windows.Forms.ComboBox CBService;
        private System.Windows.Forms.TextBox Rnom;
        private System.Windows.Forms.Button Betat;
        private System.Windows.Forms.Button Bajouter;
        private System.Windows.Forms.Button BSupprimer;
        private System.Windows.Forms.Button BModifier;
        private System.Windows.Forms.Button BFermer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.Button BexportXML;
        //private BunifuCheckbox bunifuCheckbox1;
    }
}
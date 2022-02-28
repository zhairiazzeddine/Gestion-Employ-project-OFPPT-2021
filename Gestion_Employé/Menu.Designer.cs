namespace Gestion_Employé
{
    partial class MDIMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MDIMenu));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.editMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.employéToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.congéToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serviceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connexionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eDITIONSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employéParServiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.congéParEmployéToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.congéParPériodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statistiqueParTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.congéParAnnéeEtParMoisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fermerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.contentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.indexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editMenu,
            this.eDITIONSToolStripMenuItem,
            this.fermerToolStripMenuItem,
            this.helpMenu});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(811, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            this.menuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip_ItemClicked);
            // 
            // editMenu
            // 
            this.editMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator6,
            this.toolStripSeparator7,
            this.employéToolStripMenuItem,
            this.congéToolStripMenuItem,
            this.serviceToolStripMenuItem,
            this.connexionToolStripMenuItem});
            this.editMenu.Name = "editMenu";
            this.editMenu.Size = new System.Drawing.Size(59, 20);
            this.editMenu.Text = "Gestion";
            this.editMenu.Click += new System.EventHandler(this.editMenu_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(129, 6);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(129, 6);
            // 
            // employéToolStripMenuItem
            // 
            this.employéToolStripMenuItem.Name = "employéToolStripMenuItem";
            this.employéToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.employéToolStripMenuItem.Text = "Employé";
            this.employéToolStripMenuItem.Click += new System.EventHandler(this.employéToolStripMenuItem_Click);
            // 
            // congéToolStripMenuItem
            // 
            this.congéToolStripMenuItem.Name = "congéToolStripMenuItem";
            this.congéToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.congéToolStripMenuItem.Text = "Congé";
            this.congéToolStripMenuItem.Click += new System.EventHandler(this.congéToolStripMenuItem_Click);
            // 
            // serviceToolStripMenuItem
            // 
            this.serviceToolStripMenuItem.Name = "serviceToolStripMenuItem";
            this.serviceToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.serviceToolStripMenuItem.Text = "Service";
            this.serviceToolStripMenuItem.Click += new System.EventHandler(this.serviceToolStripMenuItem_Click);
            // 
            // connexionToolStripMenuItem
            // 
            this.connexionToolStripMenuItem.Name = "connexionToolStripMenuItem";
            this.connexionToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.connexionToolStripMenuItem.Text = "Utilisateurs";
            // 
            // eDITIONSToolStripMenuItem
            // 
            this.eDITIONSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.employéParServiceToolStripMenuItem,
            this.congéParEmployéToolStripMenuItem,
            this.congéParPériodeToolStripMenuItem,
            this.statistiqueParTypeToolStripMenuItem,
            this.congéParAnnéeEtParMoisToolStripMenuItem});
            this.eDITIONSToolStripMenuItem.Name = "eDITIONSToolStripMenuItem";
            this.eDITIONSToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.eDITIONSToolStripMenuItem.Text = "EDITIONS";
            // 
            // employéParServiceToolStripMenuItem
            // 
            this.employéParServiceToolStripMenuItem.Name = "employéParServiceToolStripMenuItem";
            this.employéParServiceToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.employéParServiceToolStripMenuItem.Text = "Employé par Service";
            this.employéParServiceToolStripMenuItem.Click += new System.EventHandler(this.employéParServiceToolStripMenuItem_Click);
            // 
            // congéParEmployéToolStripMenuItem
            // 
            this.congéParEmployéToolStripMenuItem.Name = "congéParEmployéToolStripMenuItem";
            this.congéParEmployéToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.congéParEmployéToolStripMenuItem.Text = "Congé par Employé";
            this.congéParEmployéToolStripMenuItem.Click += new System.EventHandler(this.congéParEmployéToolStripMenuItem_Click);
            // 
            // congéParPériodeToolStripMenuItem
            // 
            this.congéParPériodeToolStripMenuItem.Name = "congéParPériodeToolStripMenuItem";
            this.congéParPériodeToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.congéParPériodeToolStripMenuItem.Text = "Congé par Période";
            this.congéParPériodeToolStripMenuItem.Click += new System.EventHandler(this.congéParPériodeToolStripMenuItem_Click);
            // 
            // statistiqueParTypeToolStripMenuItem
            // 
            this.statistiqueParTypeToolStripMenuItem.Name = "statistiqueParTypeToolStripMenuItem";
            this.statistiqueParTypeToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.statistiqueParTypeToolStripMenuItem.Text = "Statistique par Type";
            this.statistiqueParTypeToolStripMenuItem.Click += new System.EventHandler(this.statistiqueParTypeToolStripMenuItem_Click);
            // 
            // congéParAnnéeEtParMoisToolStripMenuItem
            // 
            this.congéParAnnéeEtParMoisToolStripMenuItem.Name = "congéParAnnéeEtParMoisToolStripMenuItem";
            this.congéParAnnéeEtParMoisToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.congéParAnnéeEtParMoisToolStripMenuItem.Text = "Congé par année et par mois ";
            this.congéParAnnéeEtParMoisToolStripMenuItem.Click += new System.EventHandler(this.congéParAnnéeEtParMoisToolStripMenuItem_Click);
            // 
            // fermerToolStripMenuItem
            // 
            this.fermerToolStripMenuItem.Name = "fermerToolStripMenuItem";
            this.fermerToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.fermerToolStripMenuItem.Text = "Quitter";
            this.fermerToolStripMenuItem.Click += new System.EventHandler(this.fermerToolStripMenuItem_Click);
            // 
            // helpMenu
            // 
            this.helpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contentsToolStripMenuItem,
            this.indexToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.toolStripSeparator8,
            this.aboutToolStripMenuItem});
            this.helpMenu.Name = "helpMenu";
            this.helpMenu.Size = new System.Drawing.Size(43, 20);
            this.helpMenu.Text = "&Aide";
            // 
            // contentsToolStripMenuItem
            // 
            this.contentsToolStripMenuItem.Name = "contentsToolStripMenuItem";
            this.contentsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F1)));
            this.contentsToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.contentsToolStripMenuItem.Text = "&Contenu";
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(163, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.aboutToolStripMenuItem.Text = "&À propos de ... ...";
            // 
            // indexToolStripMenuItem
            // 
            this.indexToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("indexToolStripMenuItem.Image")));
            this.indexToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.indexToolStripMenuItem.Name = "indexToolStripMenuItem";
            this.indexToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.indexToolStripMenuItem.Text = "&Index";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("searchToolStripMenuItem.Image")));
            this.searchToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.searchToolStripMenuItem.Text = "&Rechercher";
            // 
            // MDIMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 619);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MDIMenu";
            this.Text = "Menu";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editMenu;
        private System.Windows.Forms.ToolStripMenuItem helpMenu;
        private System.Windows.Forms.ToolStripMenuItem contentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem indexToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem employéToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem congéToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serviceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fermerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connexionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eDITIONSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employéParServiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem congéParEmployéToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem congéParPériodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statistiqueParTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem congéParAnnéeEtParMoisToolStripMenuItem;
    }
}




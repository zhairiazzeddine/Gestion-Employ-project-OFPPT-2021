using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Employé
{
    public partial class MDIMenu : Form
    {
        private int childFormNumber = 0;

        public MDIMenu()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Fenêtre " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Fichiers texte (*.txt)|*.txt|Tous les fichiers (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Fichiers texte (*.txt)|*.txt|Tous les fichiers (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void editMenu_Click(object sender, EventArgs e)
        {

        }

        private void viewMenu_Click(object sender, EventArgs e)
        {

        }

        private void employéToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Femployé f = new Femployé();
            f.MdiParent = this;
            f.Show();
        }

        private void congéToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Fcongé().Show();
        }

        private void serviceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FService().Show();
        }

        private void fermerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void employéParServiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Femloye_service F = new Femloye_service();
            F.MdiParent = this;
            F.Show();
        }

        private void menuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void congéParEmployéToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fcongé_employé f = new Fcongé_employé();
            f.MdiParent = this;
            f.Show();
        }

        private void congéParPériodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fcongé_periode FC = new Fcongé_periode();
            FC.MdiParent = this;
            FC.Show();

        }

        private void statistiqueParTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fstatistique_type FT = new Fstatistique_type();
            FT.MdiParent = this;
            FT.Show();
        }

        private void congéParAnnéeEtParMoisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fcongé_année_mois FCAM = new Fcongé_année_mois();
            FCAM.MdiParent = this;
            FCAM.Show();
        }
    }
}

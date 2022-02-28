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
    public partial class FService : Form
    {
        Service S;
        public void actualiser()
        {
            S = new Service(Fconnexion.C);
            S.lister();
            Liste.DataSource = S.GetConnexion().dt;
            Tcode.Clear();
            Tlibellé.Clear();
            Tcode.Select();
        }
        public FService()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Gestion_des_Service_Load(object sender, EventArgs e)
        {
            
        }

        private void FService_Load(object sender, EventArgs e)
        {
            actualiser();
        }

        private void BFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Tcode_Leave(object sender, EventArgs e)

        {
            if (Tcode.Text!="")
            {
                S = new Service(Tcode.Text, Fconnexion.C);
                if (S.existance_code()==false)
                {
                    Tlibellé.Text = "";
                    BAjouter.Enabled = true;
                    BSupprimer.Enabled = false;
                    BModifier.Enabled=false;
                }
                else
                {
                   
                    S.rechercher_code();
                    Tlibellé.Text = S.GetConnexion().dt.Rows[0][1].ToString();
                    BAjouter.Enabled = false;
                    BSupprimer.Enabled = true;
                    BModifier.Enabled = true; 
                }
                Tlibellé.Select();
            }
        }

        private void BAjouter_Click(object sender, EventArgs e)
        {
            if (Tcode.Text==""|| Tlibellé.Text=="")
            {
                MessageBox.Show("données non valide");
                return;
            }

            S = new Service(Tcode.Text, Tlibellé.Text, Fconnexion.C);
            S.ajout();
            actualiser();
            MessageBox.Show("ajout effectué");
        }

        private void BModifier_Click(object sender, EventArgs e)
        {
            if (Tcode.Text == "" || Tlibellé.Text == "")
            {
                MessageBox.Show("données non valide");
                return;
            }
            S = new Service(Tcode.Text, Tlibellé.Text, Fconnexion.C);
            S.modifier();
            actualiser();
            MessageBox.Show("modification effectuée");
        }

        private void BSupprimer_Click(object sender, EventArgs e)
        {
            if(Tcode.Text=="")
            {
                MessageBox.Show("Code Non Valide");
                return;
            }
            if (MessageBox.Show("Etes vous sûr de vouloir supprimer le service "+Tcode.Text,"Confirmer",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Question)==DialogResult.No)
            {
                MessageBox.Show("Suppression annulée");
                return;
            }
            S = new Service(Tcode.Text,Fconnexion.C);
            if(S.existance_employé()==true)
            {
                MessageBox.Show("ce service ne peut être supprimé car il contient des employés");
                return;
            }
            S.supprimer();
            actualiser();
            MessageBox.Show("Suppression Effectueé");
        }

        private void Liste_MouseEnter(object sender, EventArgs e)
        {
            Tcode.Text = Liste.Rows[0].Cells[1].Value.ToString();
        }

        private void Liste_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Tcode.Text = Liste.Rows[0].Cells[1].Value.ToString();
        }

        private void Liste_RowDividerDoubleClick(object sender, DataGridViewRowDividerDoubleClickEventArgs e)
        {

        }

        private void Liste_Click(object sender, EventArgs e)
        {
            Tcode.Text = Liste.CurrentRow.Cells[0].Value.ToString();
            Tlibellé.Text = Liste.CurrentRow.Cells[1].Value.ToString();
        }
    }
}

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
    public partial class Fcongé_periode : Form
    {
        public Fcongé_periode()
        {
            InitializeComponent();
        }

        private void Tdate1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                Tdate2.Select();
        }

        private void Tdate2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==13)
            {
                try
                {
                    Congé C = new Congé(Fconnexion.C);
                    C.congé_periode(Convert.ToDateTime(Tdate1.Text), Convert.ToDateTime(Tdate2.Text));
                    Liste.DataSource = C.Getconnexion().dt;
                }
                catch(FormatException FE)
                {
                    MessageBox.Show(FE.Message);
                        
                }
            }
        }
    }
}

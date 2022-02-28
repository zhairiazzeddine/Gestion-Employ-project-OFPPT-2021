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
    public partial class Fconnexion : Form
    {
        public static Connexion C;
       
            
        public Fconnexion()
        {
            InitializeComponent();
        }

        private void Bok_Move(object sender, EventArgs e)
        {
            
        }

        private void Bannuler_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Bok_Click(object sender, EventArgs e)
        {
            C = new Connexion(Tnom.Text, Tpasse.Text);
            if (C.Connecter() == true)
            {
                new MDIMenu().Show();
                this.Hide();
            }
            else
                MessageBox.Show("La Connexion a échouée\nVerifié les Entrée", " Login Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void Fconnexion_Load(object sender, EventArgs e)
        {
            Bok.Enabled = false;
            
        }

        private void Tnom_TextChanged(object sender, EventArgs e)
        {
            Bok.Enabled = true;
            if (Tnom.Text.Length == 0 || Tnom.Text=="")
                Bok.Enabled = false;
        }

        private void Tpasse_TextChanged(object sender, EventArgs e)
        {
            
            for (int k=0;k<Tpasse.Text.Length;k++)
            {

                Tpasse.PasswordChar = '*';
            }
        }

        private void Bok_MouseMove(object sender, MouseEventArgs e)
        {
            
            
        }

        private void Bok_MouseEnter(object sender, EventArgs e)
        {
            Bok.BackColor = Color.LightGreen;
        }

        private void Bok_MouseLeave(object sender, EventArgs e)
        {
            Bok.BackColor = Color.Transparent;
        }

        private void Bannuler_MouseEnter(object sender, EventArgs e)
        {
            Bannuler.BackColor = Color.Tomato;
            
        }

        private void Bannuler_MouseLeave(object sender, EventArgs e)
        {
            Bannuler.BackColor = Color.Transparent;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            T.Text = DateTime.Today.ToLongDateString();
        }

        private void Tpasse_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar==13)
            {
                C = new Connexion(Tnom.Text, Tpasse.Text);
                if (C.Connecter() == true)
                {
                    new MDIMenu().Show();
                    this.Hide();
                }
                else
                    MessageBox.Show("La Connexion a échouée\nVerifié les Entrée", " Login Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

       
    }
}

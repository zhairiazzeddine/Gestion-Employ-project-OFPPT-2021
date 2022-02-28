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
    public partial class Fmenu : Form
    {
        public Fmenu()
        {
            InitializeComponent();
        }

        //private void checkBox1_CheckedChanged(object sender, EventArgs e)
        //{
        //    new FService().Show();
        //}

        

        //private void checkBox2_CheckedChanged(object sender, EventArgs e)
        //{
        //    new Femployé().Show();
        //}

        //private void checkBox5_CheckedChanged(object sender, EventArgs e)
        //{
        //    Application.Exit();
        //}

        private void Fmenu_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_Click(object sender, EventArgs e)
        {
            new FService().Show();
        }

        private void checkBox2_Click(object sender, EventArgs e)
        {
            new Femployé().Show();
        }

        private void checkBox3_Click(object sender, EventArgs e)
        {
            new Fcongé().Show();
        }

        private void checkBox5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        //{

        //}
    }
}

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
    public partial class Fstatistique_type : Form
    {
        public Fstatistique_type()
        {
            InitializeComponent();
        }

        private void Fstatistique_type_Load(object sender, EventArgs e)
        {
            Congé C = new Congé(Fconnexion.C);
            C.statistique_type();
            Liste.DataSource = C.Getconnexion().dt;
        }
    }
}

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
    public partial class Fcongé_année_mois : Form
    {
        public Fcongé_année_mois()
        {
            InitializeComponent();
        }

        private void Fcongé_année_mois_Load(object sender, EventArgs e)
        {
            Congé C = new Congé(Fconnexion.C);
            C.durée_année_mois();
            Liste.DataSource = C.Getconnexion().dt;
            
        }
    }
}

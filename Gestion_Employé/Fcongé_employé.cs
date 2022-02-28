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
    public partial class Fcongé_employé : Form
    {
        public Fcongé_employé()
        {
            InitializeComponent();
        }

        private void Fcongé_employé_Load(object sender, EventArgs e)
        {
            
            Employé E = new Employé(CBMatricule.Text, Fconnexion.C);
            E.lister();
            for (int k=0;k<E.GetConnexion().dt.Rows.Count;k++)
            {
                CBMatricule.Items.Add(E.GetConnexion().dt.Rows[k][0].ToString());
            }
        }

        private void CBMatricule_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBMatricule.Text != "")
            {
                Employé E = new Employé(CBMatricule.Text, Fconnexion.C);
                Congé C = new Congé(E, Fconnexion.C);
                C.congé_par_employé();
                Liste_C.DataSource = C.Getconnexion().dt;
                Tsum.Text = C.Durée_total_employé();
            }
        }
    }
}

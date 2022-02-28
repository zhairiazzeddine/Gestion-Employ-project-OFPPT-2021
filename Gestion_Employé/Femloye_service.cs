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
    public partial class Femloye_service : Form
    {
        public Femloye_service()
        {
            InitializeComponent();
        }

        private void Femloye_service_Load(object sender, EventArgs e)
        {
            Service S = new Service(Fconnexion.C);
            S.lister();
            for(int k=0;k<S.GetConnexion().dt.Rows.Count;k++)
            {
                CBService.Items.Add(S.GetConnexion().dt.Rows[k][0].ToString());
            }
        }

        private void CBService_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(CBService.Text!="")
            {
                Service s = new Service(CBService.Text,Fconnexion.C);
                Employé E = new Employé(s, Fconnexion.C);
                E.Employé_pr_Service();
                Liste.DataSource = E.GetConnexion().dt;
                Tnbr.Text = E.nbre_employé_service();
            }
        }
    }
}

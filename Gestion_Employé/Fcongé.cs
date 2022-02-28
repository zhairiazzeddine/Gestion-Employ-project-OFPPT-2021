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
    public partial class Fcongé : Form
    {
        Employé employé;
        Congé congé;

        public void actualiser()
        {
            congé = new Congé(Fconnexion.C);    //Appel du 1er constructeur  
            congé.lister();       //Appel de la méthode Lister()  
            Liste.DataSource = congé.Getconnexion().dt;  //Remplir DataGridView à partir de DataTable  
            CBMatricule.Text = "";      // vider les zones  

            //la date d'aujourd’hui par défaut  
            TDate.Text = DateTime.Today.ToShortDateString();
            TDurée.Text = "";
            Ttype.Text = "";
            CBMatricule.Select(); //sélectionner Tmatricule  
        }
        public Fcongé()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Fcongé_Load(object sender, EventArgs e)
        {
            actualiser();
            employé = new Employé(Fconnexion.C);
            employé.lister();
            for (int k = 0; k < employé.GetConnexion().dt.Rows.Count; k++)
                CBMatricule.Items.Add(employé.GetConnexion().dt.Rows[k][0].ToString());
        }

        private void CBMatricule_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBMatricule.Text != "" && TDate.Text != "__/__/")
            {
                employé = new Employé(CBMatricule.Text, Fconnexion.C);       //créer un objet employé par le 2eme     
                                                                             //constructeur  
                congé = new Congé(employé, Convert.ToDateTime(TDate.Text), Fconnexion.C); //créer un objet  
                                                                                          //congé par le 2eme constructeur  

                if (congé.existence_matricule_date() == false)    //appel de la méthode existence  
                {
                    Ttype.Text = "";     //vider les zones de texte dans le cas où le code n'existe pas  
                    TDurée.Text = "";
                    BAjouter.Enabled = true;    //activer l'ajout  
                    BSupprimer.Enabled = false;    //désactiver la suppression  
                    BModifier.Enabled = false;    //désactiver la modification  
                }
                else
                {
                    congé.rechercher_matricule_date();   //appel de la méthode recherche par matricule et date  
                    Ttype.Text = congé.Getconnexion().dt.Rows[0][2].ToString(); // le type de la3eme colonne de DataTable  
                    TDate.Text = congé.Getconnexion().dt.Rows[0][3].ToString(); // la durée de la 4eme colonne de DataTable                     BAjouter.Enabled = false;            //désactiver l'ajout  
                    BSupprimer.Enabled = true;           //activer la suppression  
                    BModifier.Enabled = true;      // activer la modification
                }
                Ttype.Select();
            }
        }

        private void TDate_Leave(object sender, EventArgs e)
        {
            if (TDate.Text != "__/__/")
            {
                try
                {
                    DateTime date = Convert.ToDateTime(TDate.Text);   //convertir en type date  
                    if (CBMatricule.Text != "")
                    {
                        employé = new Employé(CBMatricule.Text, Fconnexion.C);     //créer un objet employé constructeur 2  
                        congé = new Congé(employé, date, Fconnexion.C);   //créer un objet congé par le 2eme constructeur  
                        if (congé.existence_matricule_date() == false)   //appel de la méthode existence  
                        {
                            Ttype.Text = "";    //vider les zones de texte dans le cas où le code n'existe pas  
                            TDurée.Text = "";
                            BAjouter.Enabled = true;   //activer l'ajout  
                            BSupprimer.Enabled = false;   //désactiver la suppression  
                            BModifier.Enabled = false;   //désactiver la modification  
                        }
                        else
                        {
                            congé.rechercher_matricule_date();  //appel de la méthode recherche par matricule et date  
                            Ttype.Text = congé.Getconnexion().dt.Rows[0][2].ToString();  // le type de la colonne 3 de DataTable  
                            TDurée.Text = congé.Getconnexion().dt.Rows[0][3].ToString();    // la durée de la colonne 4 de DataTable  
                            BAjouter.Enabled = false;       //désactiver l'ajout  
                            BSupprimer.Enabled = true;       //activer la suppression
                            BModifier.Enabled = true;       // activer la modification  
                        }
                        Ttype.Select();
                    }
                }
                catch (FormatException f)
                {
                    MessageBox.Show("date non valide");
                    TDate.Select();
                }
            }
        }

        private void TDurée_Leave(object sender, EventArgs e)
        {
            if (TDurée.Text != "")
            {
                try
                {
                    int echelle = Convert.ToInt16(TDurée.Text);
                }
                catch (FormatException f)
                {
                    MessageBox.Show("durée non valide");
                    TDurée.Select();
                }
            }
        }

        private void BAjouter_Click(object sender, EventArgs e)
        {
            if (CBMatricule.Text == "" || Ttype.Text == "" || TDate.Text == "__/__/" || TDurée.Text == "")
            {
                MessageBox.Show("données non valide");
                return;
            }
            employé = new Employé(CBMatricule.Text, Fconnexion.C);
            congé = new Congé(employé, Convert.ToDateTime(TDate.Text), Ttype.Text,
            Convert.ToInt16(TDurée.Text), Fconnexion.C);   //créer un congé à l'aide du constructeur 3 
            congé.ajout();       //appel de la méthode ajout  
            actualiser();        //appel de actualiser  
            MessageBox.Show("ajout effectué");

        }

        private void BModifier_Click(object sender, EventArgs e)
        {
            if (CBMatricule.Text == "" || Ttype.Text == "" || TDate.Text == "__/__/" || TDurée.Text == "")
            {
                MessageBox.Show("données non valide");
                return;
            }
            employé = new Employé(CBMatricule.Text, Fconnexion.C);
            congé = new Congé(employé, Convert.ToDateTime(TDate.Text), Ttype.Text, Convert.ToInt16(TDurée.Text), Fconnexion.C);//créer un congé à l'aide du constructeur 3  
            actualiser(); //appel de actualiser  
            MessageBox.Show("modification effectuée");
        }

        private void BSupprimer_Click(object sender, EventArgs e)
        {
            if (CBMatricule.Text == "" || TDate.Text == "__/__/")
            {
                MessageBox.Show("matricule et date non valides");
                return;
            }
            if (MessageBox.Show("Etes vous sùr de vouloir supprimer le congé de l'employé " + CBMatricule.Text + " à la date "+TDate .Text , "Confirmer", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                MessageBox.Show("suppression annulée");
                return;
            }
            employé = new Employé(CBMatricule.Text, Fconnexion.C);    //créer un employé à l'aide du constructeur 2 
            congé = new Congé(employé, Convert.ToDateTime(TDate.Text), Fconnexion.C); //créer un congé 
            congé.supprimer();     //appel de la méthode supprimer  
            actualiser();      //appel de actualiser  
            MessageBox.Show("suppression effectuée");
        }

        private void Liste_Click(object sender, EventArgs e)
        {
            CBMatricule.Text = Liste.CurrentRow.Cells[0].Value.ToString();
            TDate.Text = Liste.CurrentRow.Cells[1].Value.ToString();
            Ttype.Text = Liste.CurrentRow.Cells[2].Value.ToString();
            TDurée.Text = Liste.CurrentRow.Cells[3].Value.ToString();
            BAjouter.Enabled = false;    //désactiver l'ajout  
            BSupprimer.Enabled = true;    //activer la suppression  
            BModifier.Enabled = true;    // activer la modification 
        }
    }
}
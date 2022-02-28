using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Employé
{
    public partial class Femployé : Form
    {
        Employé E;
        Service S;
        public void actualiser()
        {
            E = new Employé(Fconnexion.C);    //Appel du 1er constructeur  
            
            E.lister(); //Appel de la méthode Lister()  
            Liste.DataSource = E.GetConnexion().dt;   //Remplir DataGridView à partir de DataTable  
            Tmatricule.Text = "";      // vider les zones  
            Tnom.Text = "";
            Tprénom.Text = "";
            TDate.Text = "__/__/";
            Techelle.Text = "";
            Tgrade.Text = "";
            CBService.Items.Clear();
            S = new Service(Fconnexion.C);
            S.lister();
            for (int k = 0; k < Fconnexion.C.dt.Rows.Count; k++)
                CBService.Items.Add(E.GetConnexion().dt.Rows[k][0].ToString());
            //S = new Service(Fconnexion.C);
            //foreach (DataRow item in S.GetConnexion().dt.Rows)
            //{
            //    String row = item.ItemArray[0] + " " + item.ItemArray[1];
            //    CBService.Items.Add(row);
            //}
            //CBService.Text = E.GetConnexion().dt.Rows[0][6].ToString();
            Tmatricule.Select();      //sélectionner Tmatricule  
        }
        public Femployé()
        {
            InitializeComponent();
        }

        private void Femployé_Load(object sender, EventArgs e)
        {
            actualiser();
            


        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            E = new Employé(Fconnexion.C);
            E.rechercher_nom(Rnom.Text);
            Liste.DataSource = E.GetConnexion().dt;
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Tmatricule.Text == "" || Tnom.Text == "" || Tprénom.Text == "" || Tgrade.Text == "" ||TDate.Text =="__/__/" || Techelle.Text == "" || CBService.Text == "")
            {
                MessageBox.Show("données non valide");
                return;
            }
            Service S = new Service(CBService.Text, Fconnexion.C);  //créer un service  
            E = new Employé(Tmatricule.Text, Tnom.Text, Tprénom.Text,Convert.ToDateTime(TDate.Text), Tgrade.Text, Convert.ToInt16(Techelle.Text), S,Fconnexion.C);     //créer un employé à l'aide du 3eme constructeur  
            E.modifier();      //appel de la méthode modifier 
            actualiser();      //appel de actualiser  
            MessageBox.Show("modification effectuée");
        }

        private void Tmatricule_TextChanged(object sender, EventArgs e)
        {

        }

        private void Tmatricule_Leave(object sender, EventArgs e)
        {
            if (Tmatricule.Text != "") //si le matricule n'est pas vide  
            {
                E = new Employé(Tmatricule.Text, Fconnexion.C); //créer un objet employé par le 2eme constructeur  
                if (E.existence_matricule() == false) //appel de la méthode existence  
                {
                    Tnom.Text = "";     //vider les zones de texte dans le cas où le code n'existe pas  
                    Tprénom.Text = "";
                    TDate.Text = "__/__/";
                    Techelle.Text = "";
                    Tgrade.Text = "";
                    Bajouter.Enabled = true;    //activer l'ajout  
                    BSupprimer.Enabled = false;    //désactiver la suppression  
                    BModifier.Enabled = false;
                }
                else
                {
                    E.rechercher_matricule();
                    Tnom.Text = E.GetConnexion().dt.Rows[0][1].ToString();  // 2eme colonne  
                    Tprénom.Text = E.GetConnexion().dt.Rows[0][2].ToString();    // 3eme colonne  
                    TDate.Text = E.GetConnexion().dt.Rows[0][3].ToString();   // 4eme colonne  
                    Tgrade.Text = E.GetConnexion().dt.Rows[0][4].ToString();    // 5eme colonne  
                    Techelle.Text = E.GetConnexion().dt.Rows[0][5].ToString();    // 6eme colonne 
                    CBService.Text = E.GetConnexion().dt.Rows[0][6].ToString();   // 7eme colonne  
                    Bajouter.Enabled = false;     //désactiver l'ajout  
                    BSupprimer.Enabled = true;     //activer la suppression  
                    BModifier.Enabled = true;
                }
                Tnom.Select();
            }
        }

        private void Bajouter_Click(object sender, EventArgs e)
        {
            if (Tmatricule.Text == "" || Tnom.Text == "" || Tprénom.Text == "" || Tgrade.Text == "" || TDate.Text == "__/__/" || Techelle.Text == "" || CBService.Text == "")
            {
                MessageBox.Show("données non valide");
                return;
            }
            Service S = new Service(CBService.Text, Fconnexion.C);
            E = new Employé(Tmatricule.Text, Tnom.Text, Tprénom.Text, Convert.ToDateTime(TDate.Text), Tgrade.Text, Convert.ToInt16(Techelle.Text), S, Fconnexion.C); //créer un employé à l'aide du 3eme constructeur  
            E.ajout(); //appel de la méthode ajout  
            actualiser(); //appel de actualiser  
            MessageBox.Show("ajout effectué");
        }

        private void BFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BSupprimer_Click(object sender, EventArgs e)
        {
            if (Tmatricule.Text == "")
            {
                MessageBox.Show("matricule non valide");
                return;
            }
            if (MessageBox.Show("Etes vous sùr de vouloir supprimer l'employé " + Tmatricule.Text, "Confirmer",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                MessageBox.Show("suppression annulée");
                return;
            }
            E = new Employé(Tmatricule.Text, Fconnexion.C);//créer un employé à l'aide du 2eme constructeur  
            if (E.existance_Congé()==true)
            {
                MessageBox.Show("Vous pouez pas supprimer ce employer car il'a des congés !");
                return;
            }
            E.supprimer();      //appel de la méthode supprimer  
            actualiser();       //appel de actualiser  
            MessageBox.Show("suppression effectuée");
        }

        private void TDate_Leave(object sender, EventArgs e)
        {
            if (TDate.Text != "__/__/")
            {
                try
                {
                    DateTime date = Convert.ToDateTime(TDate.Text);
                }
                catch (FormatException f)
                {
                    MessageBox.Show("date non valide");
                    TDate.Select();
                }
            }
        }

        private void Techelle_Leave(object sender, EventArgs e)
        {
            if (Techelle.Text != "__/__/")
            {
                try
                {
                    int echelle = Convert.ToInt16(Techelle.Text);
                }
                catch (FormatException f)
                {
                    MessageBox.Show("echelle non valide");
                    Techelle.Select();
                }
            }
        }

        private void BexportXML_Click(object sender, EventArgs e)
        {
            try
            {
                string filename = null;
                SaveFileDialog saveXML = new SaveFileDialog();
                saveXML.Filter = "XML files|*.xml";
                saveXML.FileName = "XmlData.xml";
                if(saveXML.ShowDialog()==DialogResult.OK)
                {
                    filename = saveXML.FileName;
                }
                using (StreamWriter sw = new StreamWriter(filename))
                {
                    FileInfo fileInfo = new FileInfo(filename);
                    StringBuilder sb = new StringBuilder();
                    sb.Append("<?xml version='1.0' encoding='utf-8'?>");
                    sb.AppendFormat("<xmlData>"); //racine
                    E.RemplissageDatatable();
                    foreach(DataRow row in E.DT.Rows)
                    {
                        sb.AppendFormat("<DataRow>");
                        for (int i=0;i<E.DT.Columns.Count;i++)
                        {
                            sb.AppendFormat("<{0}>{1}<{0}>", E.DT.Columns[i].ColumnName.ToUpper(), row[i].ToString());

                        }
                        sb.AppendFormat("</DataRow>");
                        
                       
                    }
                    sb.AppendFormat("</xmlData>");
                    sw.Write(sb.ToString());

                }
            }catch(Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Gestion_Employé
{
    public class Connexion
    {
        private String nom;
        private String mot_passe;
        public SqlConnection con; // con : variable de connexion 
        private SqlCommand cmd;
        private SqlDataAdapter dad;
        private DataSet dst;
        public DataTable dt;

        //constructeur par initialisation 
        public Connexion (String nom, String mot_pass)
        {
            this.nom = nom;
            this.mot_passe = mot_pass;
        }

        //Création d’une méthode de la classe Connexion permettant de se connecter à SQl Server
        public Boolean Connecter()
        {
            String chaine;
            try
            {
                chaine= "data source=LAPTOP-S2NMGFIQ\\SQLEXPRESS ; initial catalog = Gestion_employé ; uid="+nom+";pwd="+mot_passe +";integrated security=false;";
                con = new SqlConnection(chaine);
                con.Open();
                return true;

            }
            catch(Exception s)
            {
                return false;
            }
           
        }
        public int executer(String chaine_sql)
        {
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = chaine_sql;

            return cmd.ExecuteNonQuery();
        }

        public String executer_valeur(String chaine_sql)
        {
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = chaine_sql;
            return cmd.ExecuteScalar().ToString();
        }

        public void executer_liste_deconnecté(String chaine_sql)
        {
                cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = chaine_sql;
                dad = new SqlDataAdapter(cmd);
                dst = new DataSet();
                dt = new DataTable();
                dad.Fill(dst, cmd.CommandText);
                dt = dst.Tables[chaine_sql];
        }

    }
}

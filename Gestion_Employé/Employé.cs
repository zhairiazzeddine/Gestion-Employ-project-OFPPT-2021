using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data;
using System.Data.SqlClient;

namespace Gestion_Employé
{
    public class Employé
    {
        private String matricule;
        private String nom;
        private String prénom;
        private DateTime date_naissance;
        private String grade;
        private int echelle;
        private Service service;
        private Connexion con;
        public DataTable DT;
        public SqlCommand cmd = new SqlCommand();
        public SqlDataAdapter dad;
       public  DataSet dst = new DataSet();
        public DataTable dt = new DataTable();

        public Employé(Connexion CON)
        {
            this.con = CON;
        }
        public Employé(String MATRICULE, Connexion CON)
        {
            this.matricule = MATRICULE;
            this.con = CON;
        }

        public Employé(String matricule, String nom, String prénom, DateTime date_naissance, String grade, int echelle, Service service, Connexion con)
        {
            this.matricule = matricule;
            this.nom = nom;
            this.prénom = prénom;
            this.date_naissance = date_naissance;
            this.grade = grade;
            this.echelle = echelle;
            this.service = service;
            this.con = con;
        }
        public Connexion GetConnexion()
        {
            return con;
        }

        public String Getmatricule()
        {
            return matricule;
        }
        public Employé(Service service, Connexion con)
        {
            this.service = service;
            this.con = con;
        }

        public Boolean existence_matricule()
        {
            if (con.executer_valeur("select count(*) from Employé where matricule='" + matricule + "'") == "0")
                return false;
            else
                return true;
        }
        public Boolean existance_Congé()
        {
            if (con.executer_valeur("select count(*) from Congé where Matricule='" + matricule + "'") == "0")
                return false;
            else
                return true;
        }
        public void Employé_pr_Service()
        {
            con.executer_liste_deconnecté("select Matricule,Nom,Prénom,Date_naissance,Grade,Echelle from Employé where Code_service = '" + service.GetCode() + "'");
        }
        public String nbre_employé_service()
        {
            return con.executer_valeur("select count(*) from Employé where Code_service='" + service.GetCode() +"'");
        }

        public int ajout()
        {
            return con.executer("insert into employé values('" + matricule + "','" + nom + "','" + prénom + "','" + date_naissance + "','" + grade + "'," + echelle + ",'" + service.GetCode() + "')");
        }

        public int supprimer()
        {
            return con.executer("delete from employé where matricule='" + matricule + "'");
        }

        public int modifier()
        {
            return con.executer("update employé set nom='" + nom + "', prénom='" + prénom + "', date_naissance = '"+date_naissance +"', grade = '"+grade +"', echelle = "+echelle +",code_service = '"+service.GetCode() +"' where matricule = '" + matricule + "'");  
        }


        public void lister() //lister  
        {
            con.executer_liste_deconnecté("select * from employé");
        }

        public void rechercher_matricule()
        {
            con.executer_liste_deconnecté("select * from employé where matricule='" + matricule + "'");
        }

        public void rechercher_nom(String nom_recherché)
        {
            con.executer_liste_deconnecté("select * from employé where nom like '" + nom_recherché + "%'");
        }
        public void RemplissageDatatable()
        {
           
            cmd.Connection = con.con;
            con.Connecter();
            cmd.CommandText = "select * from employé";
            dad = new SqlDataAdapter(cmd);
            dad.Fill(dst, cmd.CommandText);
            DT = dst.Tables["select * from employé"];
        }
    }
}

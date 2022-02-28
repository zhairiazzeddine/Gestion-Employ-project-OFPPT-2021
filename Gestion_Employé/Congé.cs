using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Employé
{
    public class Congé
    {
        private Employé employé;    //objet de la classe Employé (pour récupérer le matricule) 
        private DateTime date_congé;
        private String type;
        private int durée;
        private Connexion con;    //objet de la classe connexion  

        public Congé(Connexion con)
        {
            this.con = con;
        }


        public Congé(Employé employé, DateTime date_congé, Connexion con)
        {
          this.employé = employé;
          this.date_congé = date_congé;
          this.con = con;
        }


        public Congé(Employé employé, DateTime date_congé, String type, int durée, Connexion con)
        {
          this.employé = employé;
          this.date_congé = date_congé;
          this.type = type; this.durée = durée;
          this.con = con;
        }

        public Connexion Getconnexion()
        {
            return con;
        }
        public Congé(Employé employé, Connexion con)
        {
            this.employé = employé;
            this.con = con;
        }

        public Boolean existence_matricule_date()
        {
            if (con.executer_valeur("select count(*) from Congé where matricule='" + employé.Getmatricule() + "' and  date_congé='" + date_congé + "'") == "0")
                return false;
            else
                return true;
        }
        public void statistique_type()
        {
            con.executer_liste_deconnecté("select * from vue_statique_type");
        }
        public void durée_année_mois()
        {
            con.executer_liste_deconnecté("select * from  vue_durée_total_par_année_par_mois ");
        }
        public void congé_par_employé()
        {
            con.executer_liste_deconnecté("select Date_congé,Type_congé,Durée from Congé where Matricule = '" + employé.Getmatricule()+ "'");
        }
        public void congé_periode(DateTime date1, DateTime date2)
        {
            con.executer_liste_deconnecté("select * from congé where date_congé between '" + date1 + "' and '"+date2+"'");  
        }

        public String Durée_total_employé()
        {
            return con.executer_valeur("select isnull(sum(Durée),0) from Congé where matricule='" +
            employé.Getmatricule() + "'");
        }

        public int ajout()
        {
            return con.executer("insert into Congé values('" + employé.Getmatricule() + "','" + date_congé + "','" + type + "'," + durée + ")");
        }


        public int supprimer()
        {
            return con.executer("delete from Congé where matricule='" + employé.Getmatricule() + "' and date_congé='" + date_congé + "'");
        }


        public int modifier()
        {
            return con.executer("update Congé set type='" + type + "', durée=" + durée + " where matricule='" + employé.Getmatricule() + "' and date_congé='" + date_congé + "'");
        }


        public void lister()
        {
            con.executer_liste_deconnecté("select * from Congé");
        }


        public void rechercher_matricule_date()
        {
            con.executer_liste_deconnecté("select * from Congé where matricule='" + employé.Getmatricule() + "' and  date_congé='" + date_congé + "'");
        }
    }
}

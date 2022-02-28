using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Gestion_Employé
{
    public class Service
    {
        private String code;
        private String libellé;
        private Connexion con;

        public Service(Connexion con)
        {
            this.con = con;
        }

        public Service(String code, Connexion con)
        {
            this.code = code;
            this.con = con;
        }

        public Service(String code, String libbellé, Connexion con)
        {
            this.code = code;
            this.libellé = libbellé;
            this.con = con;
        }

        //Les accesseurs et les modificateurs
        public Connexion GetConnexion() //get de connexion 
        {
            return con;
        }
        public String GetCode() //get de code
        {
            return code;
        }

        public Boolean existance_code()
        {
            if (con.executer_valeur("select count(*) from ServiceE where code='" + code + "'") == "0")
                return false;
            else
                return true;
        }

        public Boolean existance_employé()
        {
            if (con.executer_valeur("select count(*) from Employé where Code_service='" + code + "'") == "0")
                return false;
            else
                return true;
        }

        public int ajout()
        {
            return con.executer("insert into ServiceE values('"+code+"','"+libellé+"')");
        }

        public int supprimer()
        {
            return con.executer("delete from ServiceE where Code='" + code + "'");
        }
        public int modifier()
        {
            return con.executer("update ServiceE set Libellé='" + libellé + "' where Code='" + code + "'");
        }
        public void lister()
        {
            con.executer_liste_deconnecté("select * from ServiceE");
        }
        public void rechercher_code()
        {
            con.executer_liste_deconnecté("select * from ServiceE where Code='" + code + "'");
        }
    }
}

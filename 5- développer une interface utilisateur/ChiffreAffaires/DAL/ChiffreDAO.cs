using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAL
{
    public class ChiffreDAO
    {
        SqlConnection con;
        public ChiffreDAO()
        {
            con = new SqlConnection("data source =.;initial catalog = fil_rouge; integrated security= true");              
        }


        public List<Chiffre> list()
        {
            List<Chiffre> liste = new List<Chiffre>();
            con.Open();

            SqlCommand requete = new SqlCommand("exec Chiffre",con);
            SqlDataReader resultat = requete.ExecuteReader();
            while (resultat.Read())
            {
                Chiffre chi = new Chiffre();
                chi.reffou = Convert.ToString(resultat["reffou"]);
                chi.ca = Convert.ToDouble(resultat["chiffreAffaireFournis"]);

                liste.Add(chi);
            }
            con.Close();
            return liste;

        }
    }
}

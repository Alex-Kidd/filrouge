using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace DAL
{
    public class ClientDAO
    {
        SqlConnection con;
        public ClientDAO()
        {
            con =  new SqlConnection ("data source = .;initial catalog = fil_rouge; integrated security = true");
        }
        public void insert (Client cli)
        {
            con.Open();

            SqlCommand requete = new SqlCommand();
            requete.CommandText = "insert into client(clinom,clipre,clistat) values (@p1,@p2,@p3)";
            requete.Connection = con;
            requete.Parameters.AddWithValue("@p1", cli.clinom);
            requete.Parameters.AddWithValue("@p2", cli.clipre);
            requete.Parameters.AddWithValue("@p3", cli.clistat);


            requete.ExecuteNonQuery();
            con.Close();

        }
        public void update (Client cli)
        {
            con.Open();

            SqlCommand requete = new SqlCommand();
            requete.CommandText = "update client set clinom=@p1,clipre=@p2,clistat=@p3 where cliref=@p4";
            requete.Connection = con;

            requete.Parameters.AddWithValue("@p1", cli.clinom);
            requete.Parameters.AddWithValue("@p2", cli.clipre);
            requete.Parameters.AddWithValue("@p3", cli.clistat);
            requete.Parameters.AddWithValue("@p4", cli.cliref);

            requete.ExecuteNonQuery();
            con.Close();

        }
        public void delete (Client cli)
        {
            con.Open();

            SqlCommand requete = new SqlCommand();
            requete.CommandText = "delete from client where cliref=@p1";
            requete.Connection = con;
            requete.Parameters.AddWithValue("@p1", cli.cliref);


            requete.ExecuteNonQuery();
            con.Close();

        }
        public Client find (int id)
        {
            Client cli = new Client();

            SqlCommand requete = new SqlCommand();
            requete.Connection = con;
            requete.CommandText = "select cliref, clinom,clipre,clistat from client where cliref = @id";
            requete.Parameters.AddWithValue("@id", id);

            SqlDataReader resultat = requete.ExecuteReader();
            if (resultat.Read())
            {
                cli.cliref = Convert.ToInt32(resultat["cliref"]);
                cli.clinom = Convert.ToString(resultat["clinom"]);
                cli.clipre = Convert.ToString(resultat["clipre"]);
                cli.clistat = Convert.ToBoolean(resultat["clistat"]);

            }
            con.Close();

            return cli;
        }
        public List<Client> list()
        {
            List<Client> liste = new List<Client>();


            con.Open();

            SqlCommand requete = new SqlCommand();
            requete.CommandText = "select cliref,clinom,clipre,clistat from client";
            requete.Connection = con;

            SqlDataReader resultat = requete.ExecuteReader();

            while (resultat.Read())
            {
                Client cli = new Client();
                cli.cliref = Convert.ToInt32(resultat["cliref"]);
                cli.clinom = Convert.ToString(resultat["clinom"]);
                cli.clipre = Convert.ToString(resultat["clipre"]);
                cli.clistat = Convert.ToBoolean(resultat["clistat"]);

                liste.Add(cli);
            }

            return liste;
        }
    }
}

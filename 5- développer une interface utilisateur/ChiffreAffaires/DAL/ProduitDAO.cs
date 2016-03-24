using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAL
{
    class ProduitDAO
    {
        SqlConnection con;
        public ProduitDAO()
        {
            con = new SqlConnection("data source=.;initial catalog = fil_rouge; trusted connection=true");
        }
        public void insert(Produit pro)
        {
            con.Open();

            SqlCommand requete  = new SqlCommand();
            requete.CommandText = "insert into produit(proid,propri,reffou,founum) values (@p1,@p2,@p3,@p4)";
            requete.Connection = con;
            requete.Parameters.AddWithValue("@p1", pro.proid);
            requete.Parameters.AddWithValue("@p2", pro.propri);
            requete.Parameters.AddWithValue("@p3", pro.reffou);
            requete.Parameters.AddWithValue("@p4", pro.founum);

            requete.ExecuteNonQuery();
            con.Close();
        }
        public void update(Produit pro)
        {
            con.Open();

            SqlCommand requete = new SqlCommand();
            requete.CommandText = "update produit set propri=@p1,reffou=@p2,founum=@p3 where proid=@p4";
            requete.Connection = con;
           
            requete.Parameters.AddWithValue("@p1", pro.propri);
            requete.Parameters.AddWithValue("@p2", pro.reffou);
            requete.Parameters.AddWithValue("@p3", pro.founum);
            requete.Parameters.AddWithValue("@p4", pro.proid);

            requete.ExecuteNonQuery();
            con.Close();
        }
        public void delete(Produit pro)
        {
            con.Open();

            SqlCommand requete = new SqlCommand();
            requete.CommandText = "delete from produit where proid=@p1";
            requete.Connection = con;
            requete.Parameters.AddWithValue("@p1", pro.proid);


            requete.ExecuteNonQuery();
            con.Close();
        }
        public Produit Find(int id)
        {
            Produit pro = new Produit();

            con.Open();

            SqlCommand requete = new SqlCommand();
            requete.Connection = con;
            requete.CommandText = "select proid, propri,reffou,founum from produit where proid = @id";
            requete.Parameters.AddWithValue("@id", id);

            SqlDataReader resultat = requete.ExecuteReader();
            if (resultat.Read())
            {
                pro.proid = Convert.ToInt32(resultat["proid"]);
                pro.propri = Convert.ToDouble(resultat["propri"]);
                pro.reffou = Convert.ToString(resultat["reffou"]);
                pro.founum = Convert.ToInt32(resultat["founum"]);

            }
            con.Close();
            return pro;
        }
        public List<Produit> List()
        {
            List<Produit> liste = new List<Produit>();

            con.Open();

            SqlCommand requete = new SqlCommand();
            requete.CommandText= "select proid,propri,reffou,founum from produit";
            requete.Connection = con;

            SqlDataReader resultat = requete.ExecuteReader();

            while (resultat.Read())
            {
                Produit pro = new Produit();
                pro.proid = Convert.ToInt32(resultat["proid"]);
                pro.propri = Convert.ToDouble(resultat["propri"]);
                pro.reffou = Convert.ToString(resultat["reffou"]);
                pro.founum = Convert.ToInt32(resultat["founum"]);

                liste.Add(pro);
            }
            return liste;

        }

    }
}

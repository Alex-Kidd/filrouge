using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAL
{
    class ComposeDAO
    {
        SqlConnection con;
        public ComposeDAO()
        {
            con = new SqlConnection("data source=.;initial catalog = fil_rouge; trusted connection=true");
        }
        public void insert(Compose cmp)
        {
            con.Open();

            SqlCommand requete = new SqlCommand();
            requete.CommandText = "insert into compose(qtecom,discount,proid) values (@p1,@p2,@p3)";
            requete.Connection = con;
            requete.Parameters.AddWithValue("@p1", cmp.qtecom);
            requete.Parameters.AddWithValue("@p2", cmp.discount);
            requete.Parameters.AddWithValue("@p3", cmp.proid);

            requete.ExecuteNonQuery();
            con.Close();
        }
        public void update(Compose cmp)
        {
            con.Open();

            SqlCommand requete = new SqlCommand();
            requete.CommandText = "update compose set qtecom=@p1,discount=@p2,proid=@p3 where comnum = @p4";
            requete.Connection = con;
            requete.Parameters.AddWithValue("@p1", cmp.qtecom);
            requete.Parameters.AddWithValue("@p2", cmp.discount);
            requete.Parameters.AddWithValue("@p3", cmp.proid);
            requete.Parameters.AddWithValue("@p4", cmp.comnum);

            requete.ExecuteNonQuery();
            con.Close();
        }
        public void delete(Compose cmp)
        {
            con.Open();

            SqlCommand requete = new SqlCommand();
            requete.CommandText = "delete from compose where comnum=@p1";
            requete.Connection = con;
            requete.Parameters.AddWithValue("@p1", cmp.comnum);


            requete.ExecuteNonQuery();
            con.Close();
        }
        public Compose Find(int comnum)
        {
            Compose cmp = new Compose();

            con.Open();

            SqlCommand requete = new SqlCommand();
            requete.Connection = con;
            requete.CommandText = "select qtecom, discount, proid, comnum from compose where comnum = @id";
            requete.Parameters.AddWithValue("@id", comnum);

            SqlDataReader resultat = requete.ExecuteReader();
            if (resultat.Read())
            {
                cmp.qtecom = Convert.ToInt32(resultat["qtecom"]);
                cmp.discount = Convert.ToDouble(resultat["discount"]);
                cmp.proid = Convert.ToInt32(resultat["proid"]);
                cmp.comnum = Convert.ToInt32(resultat["comnum"]);

            }
            con.Close();
            return cmp;
        }
        public List<Compose> List()
        {
            List<Compose> liste = new List<Compose>();

            con.Open();

            SqlCommand requete = new SqlCommand();
            requete.CommandText = "select qtecom,discount,proid from produit";
            requete.Connection = con;

            SqlDataReader resultat = requete.ExecuteReader();

            while (resultat.Read())
            {
                Compose cmp = new Compose();
                cmp.qtecom = Convert.ToInt32(resultat["proid"]);
                cmp.discount = Convert.ToDouble(resultat["propri"]);
                cmp.proid = Convert.ToInt32(resultat["reffou"]);
       

                liste.Add(cmp);
            }
            return liste;

        }

    }
}

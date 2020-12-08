using DTOs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALs
{
    public class CountriesDAL
    {
        SqlConnection con;
        public CountriesDAL()
        {
            string sqlConnect = @"Data Source=DESKTOP-4H2CDN2\LENAM1999;Initial Catalog=Session3;Integrated Security=True";
            con = new SqlConnection(sqlConnect);
        }

        public DataTable getListCountries()
        {
            con.Open();
            string sqlQuery = "select * from Countries";
            SqlCommand cmd = new SqlCommand(sqlQuery, con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            con.Close();
            return dt;
        }

        public string getNameCountryFromID(int idCountry)
        {
            string name = "";
            con.Open();
            List<CountriesDTO> list = new List<CountriesDTO>();

            string sql = "select * from Countries where ID = @id";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("id", idCountry);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                name = dr["Name"].ToString();
                break;
            }
            con.Close();
            return name;
        }
        public int getIDCountryFromName(string name)
        {
            int IDcountry = 0;
            con.Open();
            string sql = "select ID from Countries where Name = @name";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("name", name);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                IDcountry = Convert.ToInt32(dr["ID"]);
                break;
            }
            con.Close();
            return IDcountry;
        }
    }
}

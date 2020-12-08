using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DTOs;
using System.Data;

namespace DALs
{
    public class AirportsDAL
    {
        SqlConnection con;
        public AirportsDAL()
        {
            string sqlConnect = @"Data Source=DESKTOP-4H2CDN2\LENAM1999;Initial Catalog=Session3;Integrated Security=True";
            con = new SqlConnection(sqlConnect);
        }

        public DataTable getListAirport()
        {
            con.Open();
            string sqlQuery = "select * from Airports";
            SqlCommand cmd = new SqlCommand(sqlQuery, con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            con.Close();
            return dt;
        }

        public string getNameFromCode(int code)
        {
            string name = "";
            con.Open();


            string sql = "select * from Airports where ID = @code";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("code", code);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                name = dr["IATACode"].ToString();
            }
            con.Close();
            return name;
        }
    }
}

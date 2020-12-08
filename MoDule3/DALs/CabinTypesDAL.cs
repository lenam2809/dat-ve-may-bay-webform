using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALs
{
    public class CabinTypesDAL
    {
        SqlConnection con;
        public CabinTypesDAL()
        {
            string sqlConnect = @"Data Source=DESKTOP-4H2CDN2\LENAM1999;Initial Catalog=Session3;Integrated Security=True";
            con = new SqlConnection(sqlConnect);
        }

        public DataTable getListCabinTypes()
        {
            con.Open();
            string sqlQuery = "select * from CabinTypes";
            SqlCommand cmd = new SqlCommand(sqlQuery, con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            con.Close();
            return dt;
        }

        public string getNameCabinTypeFromID(int id)
        {
            string name = "";
            con.Open();


            string sql = "select * from CabinTypes where ID = @id";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("id", id);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                name = dr["Name"].ToString();
                break;

            }
            con.Close();
            return name;
        }
    }
}

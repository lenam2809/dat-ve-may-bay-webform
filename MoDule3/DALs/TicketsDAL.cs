using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTOs;

namespace DALs
{
    public class TicketsDAL
    {
        SqlConnection con;
        public TicketsDAL()
        {
            string sqlConnect = @"Data Source=DESKTOP-4H2CDN2\LENAM1999;Initial Catalog=Session3;Integrated Security=True";
            con = new SqlConnection(sqlConnect);
        }

        public void addTicket(TicketsDTO ticket)
        {
            con.Open();
            string sql = "INSERT INTO Tickets(UserID,ScheduleID,CabinTypeID,Firstname,Lastname,Phone,PassportNumber,PassportCountryID,BookingReference,Confirmed) VALUES (1, @scheduleID, @CabinID, @fname, @lname, @phone, @passnumber, @IDcountry, @book, 1)";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("scheduleID", ticket.ScheduleID);
            cmd.Parameters.AddWithValue("CabinID", ticket.CabinTypeID);
            cmd.Parameters.AddWithValue("fname", ticket.Firstname);
            cmd.Parameters.AddWithValue("lname", ticket.Lastname);
            cmd.Parameters.AddWithValue("phone", ticket.Phone);
            cmd.Parameters.AddWithValue("passnumber", ticket.PassportNumber);
            cmd.Parameters.AddWithValue("IDcountry", ticket.PassportCountryID);
            cmd.Parameters.AddWithValue("book", ticket.BookingReference);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public bool checkBookingExist(string booking)
        {
            string bookingReference = null;
            con.Open();
            string sql = "select BookingReference from Tickets where BookingReference = @book";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("book", booking);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                bookingReference = dr["BookingReference"].ToString();
                break;
            }
            con.Close();
            if (bookingReference == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}

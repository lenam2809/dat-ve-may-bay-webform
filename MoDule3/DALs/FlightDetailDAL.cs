using DTOs;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALs
{
    public class FlightDetailDAL
    {
        SqlConnection con;
        AirportsDAL airportsDAL = new AirportsDAL();

        public FlightDetailDAL()
        {
            string sqlConnect = @"Data Source=DESKTOP-4H2CDN2\LENAM1999;Initial Catalog=Session3;Integrated Security=True";
            con = new SqlConnection(sqlConnect);
        }

        public List<FlightDetailsDTO> getFlight(string from, string to, string date)
        {
            con.Open();
            List<FlightDetailsDTO> list = new List<FlightDetailsDTO>();
            string sql = "select * from Schedules inner join Routes on Schedules.RouteID = Routes.ID where Routes.DepartureAirportID = (select Routes.DepartureAirportID from Airports inner join Routes on Airports.ID = Routes.DepartureAirportID where IATACode = @from GROUP BY Routes.DepartureAirportID) and Routes.ArrivalAirportID = (select Routes.ArrivalAirportID from Airports inner join Routes on Airports.ID = Routes.ArrivalAirportID where IATACode = @to GROUP BY Routes.ArrivalAirportID) and Schedules.Date = @date";
            SqlCommand cmd = new SqlCommand(sql, con);

            cmd.Parameters.AddWithValue("from", from);
            cmd.Parameters.AddWithValue("to", to);


            cmd.Parameters.AddWithValue("date", date);

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string from1 = airportsDAL.getNameFromCode(Convert.ToInt32(dr["DepartureAirportID"]));
                string to1 = airportsDAL.getNameFromCode(Convert.ToInt32(dr["ArrivalAirportID"]));
                FlightDetailsDTO flightDetail = new FlightDetailsDTO(from1, to1, dr["Date"].ToString().Split(null)[0], dr["Time"].ToString(), dr["FlightNumber"].ToString(), dr["EconomyPrice"].ToString(), 0);
                flightDetail.ID = Convert.ToInt32(dr["ID"]);
                list.Add(flightDetail);

            }

            con.Close();
            return list;
        }

        // Flight Return
        public List<FlightDetailsDTO> getFlightReturn(string from, string to, string dateOutbound, string dateReturn)
        {
            con.Open();
            List<FlightDetailsDTO> list = new List<FlightDetailsDTO>();
            string sql = "select * from Schedules inner join Routes on Schedules.RouteID = Routes.ID where Routes.DepartureAirportID = (select Routes.DepartureAirportID from Airports inner join Routes on Airports.ID = Routes.DepartureAirportID where IATACode = @from GROUP BY Routes.DepartureAirportID) and Routes.ArrivalAirportID = (select Routes.ArrivalAirportID from Airports inner join Routes on Airports.ID = Routes.ArrivalAirportID where IATACode = @to GROUP BY Routes.ArrivalAirportID) and Schedules.Date >= @date and Schedules.Date <= @dateReturn ";
            SqlCommand cmd = new SqlCommand(sql, con);

            cmd.Parameters.AddWithValue("from", to);
            cmd.Parameters.AddWithValue("to", from);

            cmd.Parameters.AddWithValue("date", dateOutbound);
            cmd.Parameters.AddWithValue("dateReturn", dateReturn);

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string from2 = airportsDAL.getNameFromCode(Convert.ToInt32(dr["DepartureAirportID"]));
                string to2 = airportsDAL.getNameFromCode(Convert.ToInt32(dr["ArrivalAirportID"]));
                FlightDetailsDTO flightDetail = new FlightDetailsDTO(from2, to2, dr["Date"].ToString().Split(null)[0], dr["Time"].ToString(), dr["FlightNumber"].ToString(), dr["EconomyPrice"].ToString(), 0);
                flightDetail.ID = Convert.ToInt32(dr["ID"]);
                list.Add(flightDetail);
            }

            con.Close();
            return list;
        }

        // Flight Three days Outbound
        public List<FlightDetailsDTO> getFlightThreeDaysOutbound(string from, string to, string date)
        {
            con.Open();
            List<FlightDetailsDTO> list = new List<FlightDetailsDTO>();
            string sql = "select * from Schedules inner join Routes on Schedules.RouteID = Routes.ID where Routes.DepartureAirportID = (select Routes.DepartureAirportID from Airports inner join Routes on Airports.ID = Routes.DepartureAirportID where IATACode = @from GROUP BY Routes.DepartureAirportID) and Routes.ArrivalAirportID = (select Routes.ArrivalAirportID from Airports inner join Routes on Airports.ID = Routes.ArrivalAirportID where IATACode = @to GROUP BY Routes.ArrivalAirportID)  and Date <= DATEADD(day, 3, @date) AND   Date >= DATEADD(day, -3, @date)";
            SqlCommand cmd = new SqlCommand(sql, con);


            cmd.Parameters.AddWithValue("from", from);
            cmd.Parameters.AddWithValue("to", to);

            cmd.Parameters.AddWithValue("date", date);

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string from3 = airportsDAL.getNameFromCode(Convert.ToInt32(dr["DepartureAirportID"]));
                string to3 = airportsDAL.getNameFromCode(Convert.ToInt32(dr["ArrivalAirportID"]));
                FlightDetailsDTO flightDetail = new FlightDetailsDTO(from3, to3, dr["Date"].ToString().Split(null)[0], dr["Time"].ToString(), dr["FlightNumber"].ToString(), dr["EconomyPrice"].ToString(), 0);
                flightDetail.ID = Convert.ToInt32(dr["ID"]);
                list.Add(flightDetail);
            }

            con.Close();
            return list;
        }

        // Flight three days Return
        public List<FlightDetailsDTO> getFlightThreeDaysReturn(string from, string to, string dateOutbound,string dateReturn)
        {
            con.Open();
            List<FlightDetailsDTO> list = new List<FlightDetailsDTO>();
            string sql = "select * from Schedules inner join Routes on Schedules.RouteID = Routes.ID where Routes.DepartureAirportID = (select Routes.DepartureAirportID from Airports inner join Routes on Airports.ID = Routes.DepartureAirportID where IATACode = @from GROUP BY Routes.DepartureAirportID) and Routes.ArrivalAirportID = (select Routes.ArrivalAirportID from Airports inner join Routes on Airports.ID = Routes.ArrivalAirportID where IATACode = @to GROUP BY Routes.ArrivalAirportID)  and Date <= DATEADD(day, 3, @dateReturn) and Schedules.Date >= @dateOutbound";
            
            SqlCommand cmd = new SqlCommand(sql, con);


            cmd.Parameters.AddWithValue("from", to);
            cmd.Parameters.AddWithValue("to", from);

            cmd.Parameters.AddWithValue("dateOutbound", dateOutbound);
            cmd.Parameters.AddWithValue("dateReturn", dateReturn);


            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string from4 = airportsDAL.getNameFromCode(Convert.ToInt32(dr["DepartureAirportID"]));
                string to4 = airportsDAL.getNameFromCode(Convert.ToInt32(dr["ArrivalAirportID"]));
                FlightDetailsDTO flightDetail = new FlightDetailsDTO(from4, to4, dr["Date"].ToString().Split(null)[0], dr["Time"].ToString(), dr["FlightNumber"].ToString(), dr["EconomyPrice"].ToString(), 0);
                flightDetail.ID = Convert.ToInt32(dr["ID"]);
                list.Add(flightDetail);
            }

            con.Close();
            return list;
        }

        // so hanh khach da mua ve
        public int getPassengers(int idSchedule)
        {
            int numberPassengers = 0;
            con.Open();
            string sql = "select count(*) as 'people' from Tickets where ScheduleID = @id";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("id", idSchedule);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                numberPassengers = Convert.ToInt32(dr["people"]);
                break;
            }
            con.Close();
            return numberPassengers;
        }
        //so ghe ngoi TotalSeats
        public int getTotalSeatsDefault(int idSchedule)
        {
            int totalSeats = 0;
            con.Open();
            string sql = "select TotalSeats from Aircrafts inner join Schedules on Aircrafts.ID = Schedules.AircraftID  where Schedules.ID = @id";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("id", idSchedule);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                totalSeats = Convert.ToInt32(dr["TotalSeats"]);
                break;
            }
            con.Close();
            return totalSeats;
        }

        // EconomySeats
        public int getEconomySeatsDefault(int idSchedule)
        {
            int EconomySeats = 0;
            con.Open();
            string sql = "select EconomySeats from Aircrafts inner join Schedules on Aircrafts.ID = Schedules.AircraftID  where Schedules.ID = @id";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("id", idSchedule);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                EconomySeats = Convert.ToInt32(dr["EconomySeats"]);
                break;
            }
            con.Close();
            return EconomySeats;
        }

        //BusinessSeats
        public int getBusinessSeatsDefault(int idSchedule)
        {
            int BusinessSeats = 0;
            con.Open();
            string sql = "select BusinessSeats from Aircrafts inner join Schedules on Aircrafts.ID = Schedules.AircraftID  where Schedules.ID = @id";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("id", idSchedule);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                BusinessSeats = Convert.ToInt32(dr["BusinessSeats"]);
                break;
            }
            con.Close();
            return BusinessSeats;
        }

        // so hanh khach da dat ve
        public int getTotalSeats(int idSchedule)
        {
            int totalSeats=0;
            con.Open();
            string sql = "select COUNT(*) as numberTotalSeats from Aircrafts inner join Schedules on Aircrafts.ID = Schedules.AircraftID inner join Tickets on Tickets.ScheduleID = Schedules.ID inner join CabinTypes on Tickets.CabinTypeID = CabinTypes.ID where Schedules.ID = @id and CabinTypes.Name = 'TotalSeats'";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("id", idSchedule);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                totalSeats = Convert.ToInt32(dr["numberTotalSeats"]);
                break;
            }
            con.Close();
            return totalSeats;
        }

        public int getEconomySeats(int idSchedule)
        {

            int economySeats=0;

            con.Open();
            string sql = "select COUNT(*) as numberEconomySeats from Aircrafts inner join Schedules on Aircrafts.ID = Schedules.AircraftID inner join Tickets on Tickets.ScheduleID = Schedules.ID inner join CabinTypes on Tickets.CabinTypeID = CabinTypes.ID where Schedules.ID = @id and CabinTypes.Name = 'Economy'";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("id", idSchedule);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                economySeats = Convert.ToInt32(dr["numberEconomySeats"]);
                break;
            }
            con.Close();
            return economySeats;
        }

        public int getBusinessSeats(int idSchedule)
        {
            int businessSeats=0;
            con.Open();
            string sql = "select COUNT(*) as numberBusinessSeats from Aircrafts inner join Schedules on Aircrafts.ID = Schedules.AircraftID inner join Tickets on Tickets.ScheduleID = Schedules.ID inner join CabinTypes on Tickets.CabinTypeID = CabinTypes.ID where Schedules.ID = @id and CabinTypes.Name = 'BusinessSeats'";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("id", idSchedule);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                businessSeats = Convert.ToInt32(dr["numberBusinessSeats"]);
                break;
            }
            con.Close();
            return businessSeats;
        }
        //add passenger
        //public List<FlightDetailsDTO> getPassenger()
        //{
        //    con.Open();
        //    List<FlightDetailsDTO> list = new List<FlightDetailsDTO>();
        //    string sql = "select * from Schedules inner join Routes on Schedules.RouteID = Routes.ID where Routes.DepartureAirportID = (select Routes.DepartureAirportID from Airports inner join Routes on Airports.ID = Routes.DepartureAirportID where IATACode = @from GROUP BY Routes.DepartureAirportID) and Routes.ArrivalAirportID = (select Routes.ArrivalAirportID from Airports inner join Routes on Airports.ID = Routes.ArrivalAirportID where IATACode = @to GROUP BY Routes.ArrivalAirportID)  and Date <= DATEADD(day, 3, @date) AND   Date >= DATEADD(day, -3, @date)";
        //    SqlCommand cmd = new SqlCommand(sql, con);

        //    cmd.Parameters.AddWithValue("from", from);
        //    cmd.Parameters.AddWithValue("to", to);

        //    cmd.Parameters.AddWithValue("from", to);
        //    cmd.Parameters.AddWithValue("to", from);

        //    cmd.Parameters.AddWithValue("date", date);

        //    SqlDataReader dr = cmd.ExecuteReader();
        //    while (dr.Read())
        //    {
        //        string from4 = airportsDAL.getNameFromCode(Convert.ToInt32(dr["DepartureAirportID"]));
        //        string to4 = airportsDAL.getNameFromCode(Convert.ToInt32(dr["ArrivalAirportID"]));
        //        FlightDetailsDTO flightDetail = new FlightDetailsDTO(from4, to4, dr["Date"].ToString().Split(null)[0], dr["Time"].ToString(), dr["FlightNumber"].ToString(), dr["EconomyPrice"].ToString(), 1);
        //        flightDetail.ID = Convert.ToInt32(dr["ID"]);
        //        list.Add(flightDetail);
        //    }

        //    con.Close();
        //    return list;
        //}

        // get flight from A
        public List<FlightDetailsDTO> getFlightFrom(int idAirportFrom, string date)
        {
            con.Open();
            List<FlightDetailsDTO> list = new List<FlightDetailsDTO>();
            string sql = "select * from Schedules inner join Routes on Schedules.RouteID = Routes.ID where Routes.DepartureAirportID = @from  and Schedules.Date = @date";
            SqlCommand cmd = new SqlCommand(sql, con);

            cmd.Parameters.AddWithValue("from", idAirportFrom);

            cmd.Parameters.AddWithValue("date", date);

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string from = airportsDAL.getNameFromCode(Convert.ToInt32(dr["DepartureAirportID"]));
                string to = airportsDAL.getNameFromCode(Convert.ToInt32(dr["ArrivalAirportID"]));
                FlightDetailsDTO flightDetail = new FlightDetailsDTO(from, to, dr["Date"].ToString().Split(null)[0], dr["Time"].ToString(), dr["FlightNumber"].ToString(), dr["EconomyPrice"].ToString(), 0);
                flightDetail.ID = Convert.ToInt32(dr["ID"]);
                list.Add(flightDetail);

            }

            con.Close();
            return list;
        }

        // get flight to B
        public List<FlightDetailsDTO> getFlightTo(int idAirportTo, string date)
        {
            con.Open();
            List<FlightDetailsDTO> list = new List<FlightDetailsDTO>();
            string sql = "select * from Schedules inner join Routes on Schedules.RouteID = Routes.ID where  Routes.ArrivalAirportID = @to and Schedules.Date = @date";
            SqlCommand cmd = new SqlCommand(sql, con);



            cmd.Parameters.AddWithValue("to", idAirportTo);



            cmd.Parameters.AddWithValue("date", date);

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string from = airportsDAL.getNameFromCode(Convert.ToInt32(dr["DepartureAirportID"]));
                string to = airportsDAL.getNameFromCode(Convert.ToInt32(dr["ArrivalAirportID"]));
                FlightDetailsDTO flightDetail = new FlightDetailsDTO(from, to, dr["Date"].ToString().Split(null)[0], dr["Time"].ToString(), dr["FlightNumber"].ToString(), dr["EconomyPrice"].ToString(), 0);
                flightDetail.ID = Convert.ToInt32(dr["ID"]);
                list.Add(flightDetail);

            }

            con.Close();
            return list;
        }

        // get flight from A (three days)
        public List<FlightDetailsDTO> getFlightFromThreeday(int idAirportFrom, string date)
        {
            con.Open();
            List<FlightDetailsDTO> list = new List<FlightDetailsDTO>();
            string sql = "select * from Schedules inner join Routes on Schedules.RouteID = Routes.ID where Routes.DepartureAirportID = @from  and Schedules.Date <= DATEADD(day, 3, @date) AND   Schedules.Date >= DATEADD(day, -3, @date)";
            SqlCommand cmd = new SqlCommand(sql, con);

            cmd.Parameters.AddWithValue("from", idAirportFrom);

            cmd.Parameters.AddWithValue("date", date);

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string from = airportsDAL.getNameFromCode(Convert.ToInt32(dr["DepartureAirportID"]));
                string to = airportsDAL.getNameFromCode(Convert.ToInt32(dr["ArrivalAirportID"]));
                FlightDetailsDTO flightDetail = new FlightDetailsDTO(from, to, dr["Date"].ToString().Split(null)[0], dr["Time"].ToString(), dr["FlightNumber"].ToString(), dr["EconomyPrice"].ToString(), 0);
                flightDetail.ID =Convert.ToInt32(dr["ID"]);
                list.Add(flightDetail);

            }

            con.Close();
            return list;
        }

        // get flight to B (three days)
        public List<FlightDetailsDTO> getFlightToThreeday(int idAirportTo, string date)
        {
            con.Open();
            List<FlightDetailsDTO> list = new List<FlightDetailsDTO>();
            string sql = "select * from Schedules inner join Routes on Schedules.RouteID = Routes.ID where  Routes.ArrivalAirportID = @to and Schedules.Date <= DATEADD(day, 3, @date) AND   Schedules.Date >= DATEADD(day, -3, @date)";
            SqlCommand cmd = new SqlCommand(sql, con);

            cmd.Parameters.AddWithValue("to", idAirportTo);

            cmd.Parameters.AddWithValue("date", date);

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string from = airportsDAL.getNameFromCode(Convert.ToInt32(dr["DepartureAirportID"]));
                string to = airportsDAL.getNameFromCode(Convert.ToInt32(dr["ArrivalAirportID"]));
                FlightDetailsDTO flightDetail = new FlightDetailsDTO(from, to, dr["Date"].ToString().Split(null)[0], dr["Time"].ToString(), dr["FlightNumber"].ToString(), dr["EconomyPrice"].ToString(), 0);
                flightDetail.ID = Convert.ToInt32(dr["ID"].ToString());
                list.Add(flightDetail);

            }

            con.Close();
            return list;
        }
    }
}

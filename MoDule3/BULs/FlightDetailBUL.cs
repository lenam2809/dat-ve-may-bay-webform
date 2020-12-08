using DALs;
using DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BULs
{
    public class FlightDetailBUL
    {
        FlightDetailDAL flightDetailsDAL = new FlightDetailDAL();
        public List<FlightDetailsDTO> getFlight(string from, string to, string date)
        {
            return flightDetailsDAL.getFlight(from, to, date);
        }

        public List<FlightDetailsDTO> getFlightReturn(string from, string to, string dateOutbound, string dateReturn)
        {
            return flightDetailsDAL.getFlightReturn(from, to, dateOutbound, dateReturn);
        }

        public List<FlightDetailsDTO> getFlightThreeDayOutbound(string from, string to, string date)
        {
            return flightDetailsDAL.getFlightThreeDaysOutbound(from, to, date);
        }

        public List<FlightDetailsDTO> getFlightThreeDayReturn(string from, string to, string dateOutbound, string dateReturn)
        {
            return flightDetailsDAL.getFlightThreeDaysReturn(from, to, dateOutbound, dateReturn);
        }

        public int getPassengers(int idSchedules)
        {
            return flightDetailsDAL.getPassengers(idSchedules);
        }

        //so hanh khach da dat ve
        public int getTotal(int idSchedules)
        {
            return flightDetailsDAL.getTotalSeats(idSchedules);
        }

        public int getEconomy(int idSchedules)
        {
            return flightDetailsDAL.getEconomySeats(idSchedules);
        }

        public int getBusiness(int idSchedules)
        {
            return flightDetailsDAL.getBusinessSeats(idSchedules);
        }

        //so ghe ngoi mac dinh
        public int getTotalDefault(int idSchedules)
        {
            return flightDetailsDAL.getTotalSeatsDefault(idSchedules);
        }

        public int getEconomyDefault(int idSchedules)
        {
            return flightDetailsDAL.getEconomySeatsDefault(idSchedules);
        }

        public int getBusinessDefault(int idSchedules)
        {
            return flightDetailsDAL.getBusinessSeatsDefault(idSchedules);
        }



        // get tuyen noi
        public List<FlightDetailsDTO> getTuyenNoi(int idFrom, int idTo, string date)
        {
            List<FlightDetailsDTO> listTong = new List<FlightDetailsDTO>();

            // list from A
            List<FlightDetailsDTO> listFrom = flightDetailsDAL.getFlightFrom(idFrom, date);

            // list to B
            List<FlightDetailsDTO> listTo = flightDetailsDAL.getFlightTo(idTo, date);

            foreach (FlightDetailsDTO i in listFrom)
            {
                foreach (FlightDetailsDTO j in listTo)
                {
                    if (i.To.Equals(j.From) && string.Compare(i.Date, j.Date) < 0)
                    {
                        string price = (double.Parse(i.cabinPrice) + double.Parse(j.cabinPrice)).ToString();
                        FlightDetailsDTO newFligt = new FlightDetailsDTO(i.From, j.To, i.Date, i.Time, i.flightNumber + "-" + j.flightNumber, price, 1);
                        newFligt.ID = i.ID + j.ID;
                        listTong.Add(newFligt);
                    }
                }
            }
            return listTong;
        }
        public List<FlightDetailsDTO> getTuyenNoiTHreeDay(int idFrom, int idTo, string date)
        {
            List<FlightDetailsDTO> listTong = new List<FlightDetailsDTO>();

            // list from A
            List<FlightDetailsDTO> listFrom = flightDetailsDAL.getFlightFromThreeday(idFrom, date);

            // list to B
            List<FlightDetailsDTO> listTo = flightDetailsDAL.getFlightToThreeday(idTo, date);

            foreach (FlightDetailsDTO i in listFrom)
            {
                foreach (FlightDetailsDTO j in listTo)
                {
                    if (i.To.Equals(j.From) && string.Compare(i.Date, j.Date) < 0)
                    {
                        string price = (double.Parse(i.cabinPrice) + double.Parse(j.cabinPrice)).ToString();
                        FlightDetailsDTO newFligt = new FlightDetailsDTO(i.From, j.To, i.Date, i.Time, i.flightNumber + "-" + j.flightNumber, price, 1);
                        newFligt.ID = i.ID + j.ID;
                        listTong.Add(newFligt);
                    }
                }
            }
            return listTong;
        }
    }
}

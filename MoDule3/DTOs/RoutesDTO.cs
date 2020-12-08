using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs
{
    public class RoutesDTO
    {
        public int ID { get; set; }
        public int DepartureAirportID { get; set; }
        public int ArrivalAirportID { get; set; }
        public int Distance { get; set; }
        public int FlightTime { get; set; }
        public RoutesDTO()
        {

        }
        public RoutesDTO(int id, int depart, int arri, int distance, int flight)
        {
            this.ID = id;
            this.DepartureAirportID = depart;
            this.ArrivalAirportID = arri;
            this.Distance = distance;
            this.FlightTime = flight;
        }
    }
}

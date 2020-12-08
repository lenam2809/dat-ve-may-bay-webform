using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs
{
    public class SchedulesDTO
    {
        public int ID { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public int AircraftID { get; set; }
        public int RouteID { get; set; }
        public string EconomyPrice { get; set; }
        public bool Confirmed { get; set; }
        public string FlightNumber { get; set; }
        public SchedulesDTO()
        {

        }
        public SchedulesDTO(int id, string date, string time, int air, int rou, string econo, bool confirm, string flight)
        {
            this.ID = id;
            this.Date = date;
            this.Time = time;
            this.AircraftID = air;
            this.RouteID = rou;
            this.EconomyPrice = econo;
            this.Confirmed = confirm;
            this.FlightNumber = flight;
        }
    }
}

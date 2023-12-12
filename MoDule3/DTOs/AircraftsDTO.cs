using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs
{
    public class AircraftsDTO
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string MakeModel { get; set; }
        public int TotalSeats { get; set; }
        public int EconomySeats { get; set; }
        public int BusinessSeats { get; set; }
        public AircraftsDTO()
        {

        }
        public AircraftsDTO(int id, string name, string makeModel, int totalSeats, int economySeats, int businessSeats)
        {
            this.ID = id;
            this.Name = name;
            this.MakeModel = makeModel;
            this.TotalSeats = totalSeats;
            this.EconomySeats = economySeats;
            this.BusinessSeats = businessSeats;
        }
    }
}

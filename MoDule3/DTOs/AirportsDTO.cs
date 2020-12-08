using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs
{
    public class AirportsDTO
    {
        public int ID { get; set; }
        public int CountryID { get; set; }
        public string IataCode { get; set; }
        public string Name { get; set; }
        public AirportsDTO()
        {

        }
        public AirportsDTO(int id, int countryid, string iatacode, string name)
        {
            this.ID = id;
            this.CountryID = countryid;
            this.IataCode = iatacode;
            this.Name = name;
        }
    }
}

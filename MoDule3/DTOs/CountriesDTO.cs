using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs
{
    public class CountriesDTO
    {
        public int  ID { get; set; }
        public string Name { get; set; }
        public CountriesDTO()
        {

        }

        public CountriesDTO(int id, string name)
        {
            this.ID = id;
            this.Name = name;
        }
    }
}

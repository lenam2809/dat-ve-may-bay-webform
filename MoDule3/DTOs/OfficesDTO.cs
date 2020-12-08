using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs
{
   public class OfficesDTO
    {
        public int ID { get; set; }
        public int CountryID { get; set; }
        public string Title { get; set; }
        public string Phone { get; set; }
        public string Contact { get; set; }
        public OfficesDTO()
        {

        }

        public OfficesDTO(int id, int countryid, string title, string phone, string contact)
        {
            this.ID = id;
            this.CountryID = countryid;
            this.Title = title;
            this.Phone = phone;
            this.Contact = contact;
        }
    }
}

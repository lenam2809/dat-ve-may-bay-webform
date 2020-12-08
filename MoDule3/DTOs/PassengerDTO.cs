using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs
{
    public class PassengerDTO
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Birthday { get; set; }
        public string PassportNumber { get; set; }
        public string PassporCountry { get; set; }
        public string Phone { get; set; }
        public int IDCountry { get; set; }
        public PassengerDTO()
        {

        }
        public PassengerDTO(string firstname, string lastname, string birthday, string passportnumber, string passportcountry, string phone, int id)
        {
            this.FirstName = firstname;
            this.LastName = lastname;
            this.Birthday = birthday;
            this.PassportNumber = passportnumber;
            this.PassporCountry = passportcountry;
            this.Phone = phone;
            this.IDCountry = id;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs
{
    public class TicketsDTO
    {
        public int ScheduleID { get; set; }
        public int CabinTypeID { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Phone { get; set; }
        public string PassportNumber { get; set; }
        public int PassportCountryID { get; set; }
        public string BookingReference { get; set; }

        public TicketsDTO()
        {

        }
        public TicketsDTO( int scheduleid, int cabintypeid, string fname, string lname, string phone, string passportnumber, int passportcountry, string booking)
        {
            this.ScheduleID = scheduleid;
            this.CabinTypeID = cabintypeid;
            this.Firstname = fname;
            this.Lastname = lname;
            this.Phone = phone;
            this.PassportNumber = passportnumber;
            this.PassportCountryID = passportcountry;
            this.BookingReference = booking;
        }
    }
}

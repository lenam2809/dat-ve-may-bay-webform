using DALs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BULs
{
    public class AirportsBUL
    {
        AirportsDAL dalAirports = new AirportsDAL();

        public AirportsBUL()
        {

        }
        public DataTable getAirports()
        {
            return dalAirports.getListAirport();
        }
    }
}

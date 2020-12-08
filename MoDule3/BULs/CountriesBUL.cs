using DALs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BULs
{
    public class CountriesBUL
    {
        CountriesDAL dalCountries = new CountriesDAL();

        public CountriesBUL()
        {

        }
        public DataTable getCountries()
        {
            return dalCountries.getListCountries();
        }

        public string getNameCountryFromID(int idCountry)
        {

            return dalCountries.getNameCountryFromID(idCountry);
        }
        public int getIDCountryFromName(string name)
        {

            return dalCountries.getIDCountryFromName(name);
        }
    }
}

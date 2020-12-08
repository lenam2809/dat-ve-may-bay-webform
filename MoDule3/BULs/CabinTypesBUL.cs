using DALs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BULs
{
    public class CabinTypesBUL
    {
        CabinTypesDAL dalCabinTypes = new CabinTypesDAL();
        public DataTable getCabinTypes()
        {

            return dalCabinTypes.getListCabinTypes();
        }
        public string getNameCabinTypeFromID(int id)
        {

            return dalCabinTypes.getNameCabinTypeFromID(id);
        }
    }
}

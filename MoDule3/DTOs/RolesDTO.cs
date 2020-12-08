using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DTOs
{
    public class RolesDTO
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public RolesDTO()
        {

        }

        public RolesDTO(int id, string title)
        {
            this.ID = id;
            this.Title = title;
        }
    }
}

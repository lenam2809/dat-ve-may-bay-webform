using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs
{
    public class UsersDTO
    {
        public int ID { get; set; }
        public int RoleID { get; set; }
        public int OfficeID { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Birthdate { get; set; }
        public bool Active { get; set; }

        public UsersDTO()
        {

        }

        public UsersDTO(int id, int roleid, int officeid, string email, string password, string firstname, string lastname, string birthdate, bool active)
        {
            this.ID = id;
            this.RoleID = roleid;
            this.OfficeID = officeid;
            this.Email = email;
            this.Password = password;
            this.FirstName = firstname;
            this.LastName = lastname;
            this.Birthdate = birthdate;
            this.Active = active;
        }
    }
}

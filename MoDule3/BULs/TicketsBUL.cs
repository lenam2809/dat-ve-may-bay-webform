using DALs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTOs;

namespace BULs
{
    public class TicketsBUL
    {
        TicketsDAL ticketsDAL = new TicketsDAL();
        public void addTicket(TicketsDTO ticket)
        {
            ticketsDAL.addTicket(ticket);
        }
        public bool checkBookingExist(string booking)
        {
            return ticketsDAL.checkBookingExist(booking);
        }
    }
}

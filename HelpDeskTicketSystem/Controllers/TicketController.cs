using HelpDeskTicketSystem.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelpDeskTicketSystem.Controllers
{
    [Route("ticket")]
    [ApiController]
    public class TicketController : ControllerBase
    {
        [HttpPost("add")]
        public bool AddTicket(string username, string subject, string description)
        {
            DateTime timestamp = DateTime.Now;
            DAL.AddTicket(username, timestamp, subject, description);
            return true;
        }

        [HttpGet("all")]
        public List<ticket> GetAllTickets()
        {
            return DAL.GetAllTickets();
        }

        [HttpPut("close/{id}/{user}")]
        public bool CloseTicket(int id, string user)
        {
            ticket updatedTicket = DAL.GetTicketByNumber(id);
            updatedTicket.closedUsername = user;
            updatedTicket.closedtime = DateTime.Now;
            DAL.CloseTicket(updatedTicket);
            return true;
        }

        [HttpDelete("delete/{id}")]
        public bool DeleteTicket (int id)
        {
            DAL.DeleteTicket(id);
            return true;
        }
    }
}

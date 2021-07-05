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
        public bool AddTicket(string username, DateTime timestamp, string subject, string description)
        {
            DAL.AddTicket(username, timestamp, subject, description);
            return true;
        }

        [HttpGet("all")]
        public List<ticket> GetAllTickets()
        {
            return DAL.GetAllTickets();
        }
    }
}

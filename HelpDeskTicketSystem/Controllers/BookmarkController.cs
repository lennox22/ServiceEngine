using HelpDeskTicketSystem.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelpDeskTicketSystem.Controllers
{
    [Route("bookmark")]
    [ApiController]
    public class BookmarkController : ControllerBase
    {
        [HttpPost("add")]
        public bool AddBookmark(string user, int ticketno)
        {
            DAL.AddBookmark(user, ticketno);
            return true;
        }

        [HttpGet("by/{username}")]
        public List<ticket> GetBookmarkedByUser (string username)
        {
            List<bookmark> byUser =  DAL.GetBookmarkedByUser(username);
            List<ticket> fromBookmark = new List<ticket>();
            foreach (bookmark entry in byUser)
            {
                fromBookmark.Add(DAL.GetTicketByNumber(entry.id));
            }
            return fromBookmark;
        }
    }
}

using Dapper;
using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace HelpDeskTicketSystem.Models
{
    public class DAL
    {
        public static IDbConnection db;

        public static ticket AddTicket (string username, DateTime timestamp, string subject, string description)
        {
            ticket newEntry = new ticket() { openedUsername = username, openedtime = timestamp, issue = subject, body = description };
            db.Insert(newEntry);
            return newEntry;
        }

        public static bookmark AddBookmark (string user, int ticketno)
        {
            bookmark newEntry = new bookmark() { username = user, ticket = ticketno };
            db.Insert(newEntry);
            return newEntry;
        }

        public static List<ticket> GetAllTickets()
        {
            return db.GetAll<ticket>().ToList();
        } 

        public static List<bookmark> GetBookmarkedByUser(string username)
        {
            return db.Query<bookmark>("select * from bookmark where username = @uname", new { uname = username }).ToList();
        }

        public static ticket GetTicketByNumber (int id)
        {
            return db.Get<ticket>(id);
        }

        public static bool CloseTicket (int id, string user, DateTime timestamp)
        {
            db.Update(id)
            return true;
        }
    }
}

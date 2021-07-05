using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelpDeskTicketSystem.Models
{
    [Table("ticket")]
    public class ticket
    {
        [Key]
        public int id { get; set; }
        public string openedUsername { get; set; }
        public DateTime openedtime { get; set; }
        public string issue { get; set; }
        public string body { get; set; }
        public string closedUsername { get; set; }
        public DateTime closedtime { get; set; }
    }
}

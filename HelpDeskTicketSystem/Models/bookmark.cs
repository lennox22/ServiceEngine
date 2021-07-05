using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelpDeskTicketSystem.Models
{
    [Table("bookmark")]
    public class bookmark
    {
        [Key]
        public int id { get; set; }
        public string username { get; set; }
        public int ticket { get; set; }
    }
}

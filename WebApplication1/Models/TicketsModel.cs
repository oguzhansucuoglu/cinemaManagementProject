using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    [Table("Tickets")]
    public class TicketsModel
    {
        public Int32 ticket_id { get; set; }
        public Int32 movie_id { get; set; }
        public Int32 theater_id { get; set; }
        public Int32 seat_id { get; set; }
        public Int32 hall_id { get; set; }
        public DateTime showtime { get; set; }
    }
}

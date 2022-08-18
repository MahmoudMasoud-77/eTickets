using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eTickets.Models
{
    public class Actor_Movie
    {
        public int Movie_Id { get; set; }
        public int  Actor_Id { get; set; }

        public virtual Movie movie { get; set; }
        public virtual Actor actor { get; set; }
    }
}

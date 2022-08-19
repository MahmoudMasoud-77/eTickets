using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eTickets.Models
{
    public class Actor_Movie
    {
        public int MovieId { get; set; }
        public int ActorId { get; set; }

        public virtual Movie movie { get; set; }
        public virtual Actor actor { get; set; }
    }
}

using System.ComponentModel.DataAnnotations.Schema;

namespace eTickets.Models
{
    public class Producer
    {
        public Producer()
        {
            movies = new List<Movie> ();
        }
        public int Id { get; set; }
        public string ProfilePictureURL { get; set; }
        public string FallName { get; set; }
        public string Bio { get; set; }
        //Relationships
        
        public virtual List<Movie> movies { get; set; }
    }
}

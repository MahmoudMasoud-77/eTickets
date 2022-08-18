using System.ComponentModel.DataAnnotations.Schema;

namespace eTickets.Models
{
    public class Cinema
    {
        public Cinema()
        {
            movies = new List<Movie>();
        }
        public int Id { get; set; }
        public string Logo { get; set; }
        public string Name { get; set; }
        public string Discription { get; set; }

        //Relationships

        public virtual List<Movie> movies { get; set; }

    }
}

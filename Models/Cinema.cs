using eTickets.Data.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eTickets.Models
{
    public class Cinema:IEntityBase
    {
        public Cinema()
        {
            movies = new List<Movie>();
        }
        public int Id { get; set; }
        [Display(Name = "Logo")]
        public string Logo { get; set; }
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Full Name must be between 3 and 50 chars")]
        [Display(Name = "Name")]
        public string Name { get; set; }
        [Display(Name = "Description")]
        public string Description { get; set; }

        //Relationships

        public virtual List<Movie>? movies { get; set; }

    }
}

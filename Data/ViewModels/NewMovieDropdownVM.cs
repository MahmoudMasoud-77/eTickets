using eTickets.Models;

namespace eTickets.Data.ViewModels
{
    public class NewMovieDropdownVM
    {
        public NewMovieDropdownVM()
        {
            producers = new List<Producer>();
            cinemas = new List<Cinema>();
            actors = new List<Actor>();
        }
        public List<Producer> producers { get; set; }
        public List<Cinema> cinemas { get; set; }
        public List<Actor> actors { get; set; }

    }
}

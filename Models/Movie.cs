using eTickets.Data.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace eTickets.Models
{
    public class Movie
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Discription { get; set; }
        public string ImageURL { get; set; }
        public double Price { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public MovieCatgory MovieCategory { get; set; }
        //Relationships

        [ForeignKey("cinema")]
        public int Cinema_Id { get; set; }
        [ForeignKey("producer")]
        public int Producer_Id { get; set; }
        public virtual Cinema? cinema { get; set; }
        public virtual Producer? producer { get; set; }

        public virtual List<Actor_Movie> Actor_Movies { get; set; }



    }
}

using eTickets.Data.Base;
using eTickets.Data.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace eTickets.Models
{
    public class Movie: IEntityBase
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageURL { get; set; }
        public double Price { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public MovieCategory MovieCategory { get; set; }
        //Relationships

        [ForeignKey("cinema")]
        public int CinemaId { get; set; }
        [ForeignKey("producer")]
        public int ProducerId { get; set; }
        public virtual Cinema? cinema { get; set; }
        public virtual Producer? producer { get; set; }

        public virtual List<Actor_Movie> Actors_Movies { get; set; }



    }
}

using eTickets.Data.Enums;
using eTickets.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eTickets.Data.ViewModels
{
    public class NewMovieVM
    {
        [Display(Name ="Movie name")]
        public string Name { get; set; }
        [Display(Name = "Movie Description")]
        public string Description { get; set; }
        [Display(Name = "Movie Poster URL")]
        public string ImageURL { get; set; }
        [Display(Name = "Price in $")]
        public double Price { get; set; }
        [Display(Name = "Movie Start Date")]
        public DateTime StartDate { get; set; }
        [Display(Name = "Movie End Date")]
        public DateTime EndDate { get; set; }
        [Display(Name = "Select a Category")]
        public MovieCategory MovieCategory { get; set; }
        //Relationships
        [Display(Name = "Select a Cinema")]
        [Required(ErrorMessage = " Movie Cinema is Required")]
        public int CinemaId { get; set; }
        [Display(Name = "Select a Producer")]
        [Required(ErrorMessage = " Movie Producer is Required")]
        public int ProducerId { get; set; }
        [Display(Name = "Select a actor(s)")]
        [Required(ErrorMessage = " Movie actor(s) is Required")]
        public virtual List<int>? ActorIds { get; set; }
    }
}

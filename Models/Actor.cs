namespace eTickets.Models
{
    public class Actor
    {
        public int Id { get; set; }
        public string ProfilePictureURL { get; set; }
        public string FallName { get; set; }
        public string Bio { get; set; }
        //Relationships
        public virtual List<Actor_Movie> Actor_Movies { get; set; }
    }
}

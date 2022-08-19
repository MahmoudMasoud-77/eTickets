using eTickets.Data;
using eTickets.Models;

namespace eTickets.Repository
{
    public class MovieRepository:IMovieRepository
    {
        private readonly AppDbContext context;
        public MovieRepository(AppDbContext _context)
        {
            this.context = _context;
        }

        public List<Movie> GetAll()
        {
            return context.Movies.ToList();
        }

        public Movie GetById(int id)
        {
            return context.Movies.FirstOrDefault(x => x.Id == id);
        }

        public void Delete(int id)
        {
            Movie Movie = GetById(id);
            context.Movies.Remove(Movie);
            context.SaveChanges();
        }
        public void Insert(Movie NewItem)
        {
            context.Movies.Add(NewItem);
            context.SaveChanges();
        }

        public void Update(int id, Movie NewItem)
        {
            Movie OldItem = GetById(id);
            OldItem.Name = NewItem.Name;
            OldItem.Description = NewItem.Description;
            OldItem.ImageURL = NewItem.ImageURL;
            OldItem.Price=NewItem.Price;
            OldItem.StartDate=NewItem.StartDate;
            OldItem.EndDate=NewItem.EndDate;
            OldItem.MovieCategory=NewItem.MovieCategory;
            context.SaveChanges();
        }
    }
}

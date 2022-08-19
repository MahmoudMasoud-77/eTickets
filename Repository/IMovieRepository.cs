using eTickets.Models;

namespace eTickets.Repository
{
    public interface IMovieRepository
    {
        List<Movie> GetAll();
        Movie GetById(int id);
        void Insert(Movie NewItem);
        void Update(int id, Movie NewItem);
        void Delete(int id);
    }
}

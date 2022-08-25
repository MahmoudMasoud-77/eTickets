using eTickets.Data.Base;
using eTickets.Models;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Data.Services
{
    public class MovieService : EntityBaseRepository<Movie>, IMovieService
    {
        private readonly AppDbContext context;
        public MovieService(AppDbContext _context) : base(_context)
        {
            context = _context;
        }

        public async Task<Movie> GetMovieByIdAsync(int id)
        {
            var movieDetails =await context.Movies
                .Include(x => x.cinema)
                .Include(y =>y.producer)
                .Include(z =>z.Actors_Movies)
                .ThenInclude(a =>a.actor).FirstOrDefaultAsync(n =>n.Id ==id);
            return movieDetails;
        }
    }
}

using eTickets.Data.Base;
using eTickets.Data.ViewModels;
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

        public async Task AddNewMovie(NewMovieVM data)
        {
            var newMovie = new Movie()
            {
                Name = data.Name,
                Description = data.Description,
                Price = data.Price,
                ImageURL = data.ImageURL,
                CinemaId = data.CinemaId,
                StartDate = data.StartDate,
                EndDate = data.EndDate,
                MovieCategory = data.MovieCategory,
                ProducerId = data.ProducerId
            };
            await context.Movies.AddAsync(newMovie);
            await context.SaveChangesAsync();

            //Add Movie Actors
            foreach (var actorId in data.ActorIds)
            {
                var newActorMovie = new Actor_Movie()
                {
                    MovieId = newMovie.Id,
                    ActorId = actorId
                };
                await context.Actors_Movies.AddAsync(newActorMovie);
            }
            await context.SaveChangesAsync();
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

        public async Task<NewMovieDropdownVM> NewMovieDropdownsVal()
        {
            var Response =new NewMovieDropdownVM()
            {
                actors = await context.Actors.OrderBy(x => x.FullName).ToListAsync(),
                cinemas = await context.Cinemies.OrderBy(x => x.Name).ToListAsync(),
                producers = await context.Producers.OrderBy(x => x.FullName).ToListAsync(),
            };
            return Response;
        }
    }
}

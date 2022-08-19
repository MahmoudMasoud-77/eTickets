using eTickets.Models;
using eTickets.Repository;
using Microsoft.AspNetCore.Mvc;

namespace eTickets.Controllers
{
    public class MovieController : Controller
    {
        private readonly MovieRepository MovieRepo;

        public MovieController(MovieRepository _MovieRepo)
        {
            this.MovieRepo = _MovieRepo;
        }
        public IActionResult Index()
        {
            List<Movie> allItem = MovieRepo.GetAll();
            return View(allItem);
        }
    }
}

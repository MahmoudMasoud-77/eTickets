using eTickets.Data;
using eTickets.Models;
using eTickets.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Controllers
{
    public class MovieController : Controller
    {
        private readonly AppDbContext context;

        public MovieController(AppDbContext _context)
        {
            this.context = _context;
        }
        public async Task<IActionResult> Index()
        {
            List<Movie> allItem = await context.Movies.ToListAsync();
            return View(allItem);
        }
    }
}

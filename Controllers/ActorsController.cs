using eTickets.Data;
using eTickets.Models;
using eTickets.Repository;
using Microsoft.AspNetCore.Mvc;

namespace eTickets.Controllers
{
    public class ActorsController : Controller
    {
        private readonly AppDbContext context;

        public ActorsController(AppDbContext _context)
        {
            this.context = _context;
        }
        public  IActionResult Index()
        {
            List<Actor> allActors = context.Actors.ToList();
            return View(allActors);
        }

    }
}

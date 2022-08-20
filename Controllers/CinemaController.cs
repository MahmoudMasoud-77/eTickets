using eTickets.Data;
using eTickets.Models;
using eTickets.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Controllers
{
    public class CinemaController : Controller
    {
        private readonly AppDbContext context;

        public CinemaController(AppDbContext _context)
        {
            this.context = _context;
        }
        public async Task<IActionResult> Index()
        {
            List<Cinema> allItem = await context.Cinemies.ToListAsync(); ;
            return View(allItem);
        }
    }
}

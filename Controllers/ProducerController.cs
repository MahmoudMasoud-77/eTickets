using eTickets.Data;
using eTickets.Models;
using eTickets.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Controllers
{
    public class ProducerController : Controller
    {
        private readonly AppDbContext context;

        public ProducerController(AppDbContext _context)
        {
            this.context = _context;
        }
        public async Task<IActionResult> Index()
        {
            List<Producer> allItem = await context.Producers.ToListAsync(); ;
            return View(allItem);
        }
    }
}

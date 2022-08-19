using eTickets.Models;
using eTickets.Repository;
using Microsoft.AspNetCore.Mvc;

namespace eTickets.Controllers
{
    public class CinemaController : Controller
    {
        private readonly CinemaRepository CinemaRepo;

        public CinemaController(CinemaRepository _CinemaRepo)
        {
            this.CinemaRepo = _CinemaRepo;
        }
        public IActionResult Index()
        {
            List<Cinema> allItem = CinemaRepo.GetAll();
            return View(allItem);
        }
    }
}

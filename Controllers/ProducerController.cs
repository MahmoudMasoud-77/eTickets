using eTickets.Models;
using eTickets.Repository;
using Microsoft.AspNetCore.Mvc;

namespace eTickets.Controllers
{
    public class ProducerController : Controller
    {
        private readonly ProducerRepository ProducerRepo;

        public ProducerController(ProducerRepository _ProducerRepo)
        {
            this.ProducerRepo = _ProducerRepo;
        }
        public IActionResult Index()
        {
            List<Producer> allItem = ProducerRepo.GetAll();
            return View(allItem);
        }
    }
}

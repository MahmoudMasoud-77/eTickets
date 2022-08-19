using eTickets.Models;
using eTickets.Repository;
using Microsoft.AspNetCore.Mvc;

namespace eTickets.Controllers
{
    public class ActorsController : Controller
    {
        private readonly ActorRepository ActorRepo;

        public ActorsController(ActorRepository _ActorRepo)
        {
            this.ActorRepo = _ActorRepo;
        }
        public  IActionResult Index()
        {
            List<Actor> allActors = ActorRepo.GetAll();
            return View(allActors);
        }

    }
}

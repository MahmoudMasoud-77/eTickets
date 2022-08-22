using eTickets.Data.Services;
using eTickets.Models;
using Microsoft.AspNetCore.Mvc;

namespace eTickets.Controllers
{
    public class ActorsController : Controller
    {
        private readonly IActorsService Service;

        public ActorsController(IActorsService _Service)
        {
            this.Service = _Service;
        }
        public  async Task<IActionResult> Index()
        {
            List<Actor> allActors = await Service.GetAllAsync();
            return View(allActors);
        }
        //Get :Actor/Details/id
        public async Task<IActionResult> Details(int id)
        {
            var actor= await Service.GetByIdAsync(id);
            if(actor == null)
                return View("Empty");
            return View(actor);
        }
        //Get :Actor/Create
        public IActionResult Create()
        {
            return View();
        }
        // POST: Actor/Create
        [HttpPost]
        public async Task<IActionResult> Create(Actor NewActor)
        {
            if(!ModelState.IsValid)
            {
               return View(NewActor);
            }
            await Service.InsertAsync(NewActor);
            return RedirectToAction("Index");

        }
        //Get :Actor/Edit/id
        public async Task<IActionResult> Edit(int id)
        {
            Actor actor = await Service.GetByIdAsync(id);
            if (actor == null)
                return View("NotFound");
            return View(actor);
        }
        //Post :Actor/Edit/id

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id,Actor NewActor)
        {
            if (!ModelState.IsValid)
            {
                return View(NewActor);
            }
            await Service.UpdateAsync(id,NewActor);
            return RedirectToAction("Index");
        }
        //Get :Actor/Delete/id
        public async Task<IActionResult> Delete(int id)
        {
            Actor actor = await Service.GetByIdAsync(id);
            if (actor == null)
                return View("NotFound");
            return View(actor);
        }
        //Post :Actor/Delete/id

        [HttpPost,ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            Actor actor= await Service.GetByIdAsync(id);
            if (actor==null)
            {
                return View("NotFound");
            }
            await Service.DeleteAsync(id);
            return RedirectToAction("Index");
        }
    }
}

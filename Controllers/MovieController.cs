using eTickets.Data.Services;
using eTickets.Models;
using Microsoft.AspNetCore.Mvc;

namespace eTickets.Controllers
{
    public class MovieController : Controller
    {
        private readonly IMovieService Service;

        public MovieController(IMovieService _Service)
        {
            this.Service = _Service;
        }
        public async Task<IActionResult> Index()
        {
            List<Movie> allItems = await Service.GetAllAsync(n =>n.cinema);
            return View(allItems);
        }
        //Get :Actor/Details/id
        public async Task<IActionResult> Details(int id)
        {
            var item = await Service.GetByIdAsync(id);
            if (item == null)
                return View("NotFound");
            return View(item);
        }
        //Get :Actor/Create
        public IActionResult Create()
        {
            return View();
        }
        // POST: Actor/Create
        [HttpPost]
        public async Task<IActionResult> Create(Movie NewItem)
        {
            if (!ModelState.IsValid)
            {
                return View(NewItem);
            }
            await Service.InsertAsync(NewItem);
            return RedirectToAction("Index");

        }
        //Get :Actor/Edit/id
        public async Task<IActionResult> Edit(int id)
        {
            Movie Item = await Service.GetByIdAsync(id);
            if (Item == null)
                return View("NotFound");
            return View(Item);
        }
        //Post :Actor/Edit/id

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Movie NewItem)
        {
            if (!ModelState.IsValid)
            {
                return View(NewItem);
            }
            await Service.UpdateAsync(id, NewItem);
            return RedirectToAction("Index");
        }
        //Get :Actor/Delete/id
        public async Task<IActionResult> Delete(int id)
        {
            Movie Item = await Service.GetByIdAsync(id);
            if (Item == null)
                return View("NotFound");
            return View(Item);
        }
        //Post :Actor/Delete/id

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            Movie Item = await Service.GetByIdAsync(id);
            if (Item == null)
            {
                return View("NotFound");
            }
            await Service.DeleteAsync(id);
            return RedirectToAction("Index");
        }
    }
}

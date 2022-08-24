using eTickets.Data.Services;
using eTickets.Models;
using Microsoft.AspNetCore.Mvc;

namespace eTickets.Controllers
{
    public class ProducerController : Controller
    {
        private readonly IProducerService Service;

        public ProducerController(IProducerService _Service)
        {
            this.Service = _Service;
        }
        public async Task<IActionResult> Index()
        {
            List<Producer> allItems = await Service.GetAllAsync();
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
        public async Task<IActionResult> Create(Producer NewItem)
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
            Producer Item = await Service.GetByIdAsync(id);
            if (Item == null)
                return View("NotFound");
            return View(Item);
        }
        //Post :Actor/Edit/id

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Producer NewItem)
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
            Producer Item = await Service.GetByIdAsync(id);
            if (Item == null)
                return View("NotFound");
            return View(Item);
        }
        //Post :Actor/Delete/id

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            Producer Item = await Service.GetByIdAsync(id);
            if (Item == null)
            {
                return View("NotFound");
            }
            await Service.DeleteAsync(id);
            return RedirectToAction("Index");
        }
    }
}

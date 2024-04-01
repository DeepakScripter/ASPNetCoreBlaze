using Microsoft.AspNetCore.Mvc;
using YtBookStore.Models.Domain;
using YtBookStore.Repositories.Abstract;

namespace YtBookStore.Controllers
{
    public class GenreController : Controller
    {
        private readonly IGenreService service;
        public GenreController(IGenreService service)
        {
            this.service = service;
        }

        // GET: Genre/Add
        public IActionResult Add()
        {
            return View();
        }

        // POST: Genre/Add
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Add(Genre model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var result = service.Add(model);
            if (result)
            {
                TempData["msg"] = "Added Successfully";
                return RedirectToAction(nameof(Add));
            }
            TempData["msg"] = "Error has occurred on server side";
            return View(model);
        }

        // GET: Genre/Update/5
        public IActionResult Update(int id)
        {
            var record = service.FindById(id);
            return View(record);
        }

        // POST: Genre/Update/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(Genre model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var result = service.Update(model);
            if (result)
            {
                return RedirectToAction(nameof(GetAll));
            }
            TempData["msg"] = "Error has occurred on server side";
            return View(model);
        }

        // GET: Genre/Delete/5
        public IActionResult Delete(int id)
        {
            var result = service.Delete(id);
            return RedirectToAction(nameof(GetAll));
        }

        // GET: Genre/GetAll
        public IActionResult GetAll()
        {
            var data = service.GetAll();
            return View(data);
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MovieApp.Data;
using MovieApp.Data.Interfaces;
using MovieApp.Data.Services;
using MovieApp.Models;

namespace MovieApp.Controllers
{
    public class ProducersController : Controller
    {
        public readonly IProducersService _producersService;
        public ProducersController(IProducersService producersService)
        {
            _producersService = producersService;
        }
        public async Task<IActionResult> Index()
        {
            var data = await _producersService.GetAll();
            return View(data);
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("FullName,ProfilePictureUrl,About")] ProducerViewModel producer)
        {
            if (!ModelState.IsValid)
            {
                return View(producer);
            }
            await _producersService.Add(producer);
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Edit(int id)
        {
            var producerDetails = await _producersService.GetById(id);
            if (producerDetails == null)
            {
                return View("NotFound");
            }
            return View(producerDetails);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FullName,ProfilePictureUrl,About")] ProducerViewModel producer)
        {
            if (!ModelState.IsValid)
            {
                return View(producer);
            }
            await _producersService.Update(id, producer);
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Delete(int id)
        {
            var producerDetails = await _producersService.GetById(id);
            if (producerDetails == null)
            {
                return View("NotFound");
            }
            return View(producerDetails);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteActor(int id)
        {
            var producerDetails = await _producersService.GetById(id);
            if (producerDetails == null)
            {
                return View("NotFound");
            }
            await _producersService.Delete(id);
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Details(int id)
        {
            var producerDetails = await _producersService.GetById(id);
            if (producerDetails == null)
            {
                return View("NotFound");
            }
            return View(producerDetails);
        }
    }
}

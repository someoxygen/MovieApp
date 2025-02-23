using Microsoft.AspNetCore.Mvc;
using MovieApp.Data;
using MovieApp.Data.Interfaces;
using MovieApp.Models;

namespace MovieApp.Controllers
{
    public class ActorsController : Controller
    {
        public readonly IActorsService _actorsService;
        public ActorsController(IActorsService actorsService)
        {
            _actorsService = actorsService;
        }
        public async Task<IActionResult> Index()
        {
            var data = await _actorsService.GetAll();
            return View(data);
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("FullName,ProfilePictureUrl,About")]ActorViewModel actor)
        {
            if (!ModelState.IsValid)
            {
                return View(actor);
            }
            await _actorsService.Add(actor);
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Edit(int id)
        {
            var actorDetails = await _actorsService.GetById(id);
            if (actorDetails == null)
            {
                return View("Not Found");
            }
            return View(actorDetails);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FullName,ProfilePictureUrl,About")] ActorViewModel actor)
        {
            if (!ModelState.IsValid)
            {
                return View(actor);
            }
            await _actorsService.Update(id, actor);
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Delete(int id)
        {
            var actorDetails = await _actorsService.GetById(id);
            if (actorDetails == null)
            {
                return View("NotFound");
            }
            return View(actorDetails);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteActor(int id)
        {
            var actorDetails = await _actorsService.GetById(id);
            if (actorDetails == null)
            {
                return View("NotFound");
            }
            await _actorsService.Delete(id);
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Details(int id)
        {
            var actorDetails = await _actorsService.GetById(id);
            if(actorDetails == null)
            {
                return View("NotFound");
            }
            return View(actorDetails);
        }
    }
}

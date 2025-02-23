using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MovieApp.Data;

namespace MovieApp.Controllers
{
    public class CinemasController : Controller
    {
        public readonly ApplicationDbContext _context;
        public CinemasController(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var cinemas = await _context.CinemaViewModels.ToListAsync();
            return View(cinemas);
        }
    }
}

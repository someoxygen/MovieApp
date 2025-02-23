using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MovieApp.Data;

namespace MovieApp.Controllers
{
    public class MoviesController : Controller
    {
        public readonly ApplicationDbContext _context;
        public MoviesController(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var movies = await _context.MovieViewModels.Include(x => x.Cinema).Include(x => x.Producer).Include(x => x.ActorMovies).OrderBy(x => x.Name).ToListAsync();
            return View(movies);
        }
    }
}

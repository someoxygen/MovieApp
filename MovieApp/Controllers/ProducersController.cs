using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MovieApp.Data;

namespace MovieApp.Controllers
{
    public class ProducersController : Controller
    {
        public readonly ApplicationDbContext _context;
        public ProducersController(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var producers = await _context.ProducerViewModels.ToListAsync();
            return View(producers);
        }
    }
}

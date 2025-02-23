using MovieApp.Data.Base;
using MovieApp.Data.Interfaces;
using MovieApp.Models;

namespace MovieApp.Data.Services
{
    public class CinemasService : EntityBaseRepository<CinemaViewModel>, ICinemasService
    {
        public CinemasService(ApplicationDbContext context) : base(context) { }
    }
}

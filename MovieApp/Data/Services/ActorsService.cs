using Microsoft.EntityFrameworkCore;
using MovieApp.Data.Base;
using MovieApp.Data.Interfaces;
using MovieApp.Models;

namespace MovieApp.Data.Services
{
    public class ActorsService : EntityBaseRepository<ActorViewModel>, IActorsService
    {
        public ActorsService(ApplicationDbContext context) : base(context) { }
    }
}

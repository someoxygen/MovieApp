using MovieApp.Data.Base;
using MovieApp.Data.Interfaces;
using MovieApp.Models;

namespace MovieApp.Data.Services
{
    public class ProducersService : EntityBaseRepository<ProducerViewModel>, IProducersService
    {
        public ProducersService(ApplicationDbContext context) : base(context) { }
    }
}

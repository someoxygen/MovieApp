using Microsoft.EntityFrameworkCore;
using MovieApp.Models;

namespace MovieApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> dbContextOptions) : base(dbContextOptions)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ActorMovie>().HasKey(am => new
            {
                am.ActorId,
                am.MovieId,
            });
            modelBuilder.Entity<ActorMovie>().HasOne(m => m.Movie).WithMany(am => am.ActorMovies).HasForeignKey(m => m.MovieId);
            modelBuilder.Entity<ActorMovie>().HasOne(p => p.Actor).WithMany(am => am.ActorMovies).HasForeignKey(p => p.ActorId);
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<ActorMovie> ActorMovies { get; set; }
        public DbSet<MovieViewModel> MovieViewModels { get; set; }
        public DbSet<ActorViewModel> ActorViewModels { get; set; }
        public DbSet<ProducerViewModel> ProducerViewModels { get; set; }
        public DbSet<CinemaViewModel> CinemaViewModels { get; set; }
    }
}

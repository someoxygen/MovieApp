using MovieApp.Data.Enums;
using MovieApp.Models;

namespace MovieApp.Data
{
    public class ApplicationDbInitializer
    {
        public static void Seed(IApplicationBuilder app)
        {
            using(var serviceScope = app.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<ApplicationDbContext>();
                context.Database.EnsureCreated();

                if (!context.CinemaViewModels.Any())
                {
                    context.CinemaViewModels.AddRange(new List<CinemaViewModel>()
                    {
                        new()
                        {
                            Name = "Cinema 1",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-1.jpeg",
                            Description = "This is the description of the first cinema"
                        },
                        new()
                        {
                            Name = "Cinema 2",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-2.jpeg",
                            Description = "This is the description of the first cinema"
                        },
                        new()
                        {
                            Name = "Cinema 3",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-3.jpeg",
                            Description = "This is the description of the first cinema"
                        },
                        new()
                        {
                            Name = "Cinema 4",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-4.jpeg",
                            Description = "This is the description of the first cinema"
                        },
                        new()
                        {
                            Name = "Cinema 5",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-5.jpeg",
                            Description = "This is the description of the first cinema"
                        },
                    });
                    context.SaveChanges();
                }

                if (!context.ActorViewModels.Any())
                {
                    context.ActorViewModels.AddRange(new List<ActorViewModel>()
                    {
                        new()
                        {
                            FullName = "Actor 1",
                            About = "This is the Bio of the first actor",
                            ProfilePictureUrl = "http://dotnethow.net/images/actors/actor-1.jpeg"

                        },
                        new()
                        {
                            FullName = "Actor 2",
                            About = "This is the Bio of the second actor",
                            ProfilePictureUrl = "http://dotnethow.net/images/actors/actor-2.jpeg"
                        },
                        new()
                        {
                            FullName = "Actor 3",
                            About = "This is the Bio of the second actor",
                            ProfilePictureUrl = "http://dotnethow.net/images/actors/actor-3.jpeg"
                        },
                        new()
                        {
                            FullName = "Actor 4",
                            About = "This is the Bio of the second actor",
                            ProfilePictureUrl = "http://dotnethow.net/images/actors/actor-4.jpeg"
                        },
                        new()
                        {
                            FullName = "Actor 5",
                            About = "This is the Bio of the second actor",
                            ProfilePictureUrl = "http://dotnethow.net/images/actors/actor-5.jpeg"
                        }
                    });
                    context.SaveChanges();
                }

                if (!context.ProducerViewModels.Any())
                {
                    context.ProducerViewModels.AddRange(new List<ProducerViewModel>()
                    {
                        new()
                        {
                            FullName = "Producer 1",
                            About = "This is the Bio of the first actor",
                            ProfilePictureUrl = "http://dotnethow.net/images/producers/producer-1.jpeg"

                        },
                        new()
                        {
                            FullName = "Producer 2",
                            About = "This is the Bio of the second actor",
                            ProfilePictureUrl = "http://dotnethow.net/images/producers/producer-2.jpeg"
                        },
                        new()
                        {
                            FullName = "Producer 3",
                            About = "This is the Bio of the second actor",
                            ProfilePictureUrl = "http://dotnethow.net/images/producers/producer-3.jpeg"
                        },
                        new()
                        {
                            FullName = "Producer 4",
                            About = "This is the Bio of the second actor",
                            ProfilePictureUrl = "http://dotnethow.net/images/producers/producer-4.jpeg"
                        },
                        new()
                        {
                            FullName = "Producer 5",
                            About = "This is the Bio of the second actor",
                            ProfilePictureUrl = "http://dotnethow.net/images/producers/producer-5.jpeg"
                        }
                    });
                    context.SaveChanges();
                }

                if (!context.MovieViewModels.Any())
                {
                    context.MovieViewModels.AddRange(new List<MovieViewModel>()
                    {
                        new()
                        {
                            Name = "Life",
                            Description = "This is the Life movie description",
                            Price = 39.50,
                            ImageUrl = "http://dotnethow.net/images/movies/movie-3.jpeg",
                            StartDate = DateTime.Now.AddDays(-10).ToUniversalTime(),
                            EndDate = DateTime.Now.AddDays(10).ToUniversalTime(),
                            CinemaId = 3,
                            ProducerId = 3,
                            MovieCategory = MovieCategory.Documentary
                        },
                        new()
                        {
                            Name = "The Shawshank Redemption",
                            Description = "This is the Shawshank Redemption description",
                            Price = 29.50,
                            ImageUrl = "http://dotnethow.net/images/movies/movie-1.jpeg",
                            StartDate = DateTime.Now.ToUniversalTime(),
                            EndDate = DateTime.Now.AddDays(3).ToUniversalTime(),
                            CinemaId = 1,
                            ProducerId = 1,
                            MovieCategory = MovieCategory.Action
                        },
                        new()
                        {
                            Name = "Ghost",
                            Description = "This is the Ghost movie description",
                            Price = 39.50,
                            ImageUrl = "http://dotnethow.net/images/movies/movie-4.jpeg",
                            StartDate = DateTime.Now.ToUniversalTime(),
                            EndDate = DateTime.Now.AddDays(7).ToUniversalTime(),
                            CinemaId = 4,
                            ProducerId = 4,
                            MovieCategory = MovieCategory.Horror
                        },
                        new()
                        {
                            Name = "Race",
                            Description = "This is the Race movie description",
                            Price = 39.50,
                            ImageUrl = "http://dotnethow.net/images/movies/movie-6.jpeg",
                            StartDate = DateTime.Now.AddDays(-10).ToUniversalTime(),
                            EndDate = DateTime.Now.AddDays(-5).ToUniversalTime(),
                            CinemaId = 1,
                            ProducerId = 2,
                            MovieCategory = MovieCategory.Documentary
                        },
                        new()
                        {
                            Name = "Scoob",
                            Description = "This is the Scoob movie description",
                            Price = 39.50,
                            ImageUrl = "http://dotnethow.net/images/movies/movie-7.jpeg",
                            StartDate = DateTime.Now.AddDays(-10).ToUniversalTime(),
                            EndDate = DateTime.Now.AddDays(-2).ToUniversalTime(),
                            CinemaId = 1,
                            ProducerId = 3,
                            MovieCategory = MovieCategory.Cartoon
                        },
                        new()
                        {
                            Name = "Cold Soles",
                            Description = "This is the Cold Soles movie description",
                            Price = 39.50,
                            ImageUrl = "http://dotnethow.net/images/movies/movie-8.jpeg",
                            StartDate = DateTime.Now.AddDays(3).ToUniversalTime(),
                            EndDate = DateTime.Now.AddDays(20).ToUniversalTime(),
                            CinemaId = 1,
                            ProducerId = 5,
                            MovieCategory = MovieCategory.Drama
                        }
                    });
                    context.SaveChanges();
                }

                if (!context.ActorMovies.Any())
                {
                    context.ActorMovies.AddRange(new List<ActorMovie>()
                    {
                        new()
                        {
                            ActorId = 1,
                            MovieId = 1
                        },
                        new()
                        {
                            ActorId = 3,
                            MovieId = 1
                        },

                        new()
                        {
                            ActorId = 1,
                            MovieId = 2
                        },
                        new()
                        {
                            ActorId = 4,
                            MovieId = 2
                        },

                        new()
                        {
                            ActorId = 1,
                            MovieId = 3
                        },
                        new()
                        {
                            ActorId = 2,
                            MovieId = 3
                        },
                        new()
                        {
                            ActorId = 5,
                            MovieId = 3
                        },


                        new()
                        {
                            ActorId = 2,
                            MovieId = 4
                        },
                        new()
                        {
                            ActorId = 3,
                            MovieId = 4
                        },
                        new()
                        {
                            ActorId = 4,
                            MovieId = 4
                        },


                        new()
                        {
                            ActorId = 2,
                            MovieId = 5
                        },
                        new()
                        {
                            ActorId = 3,
                            MovieId = 5
                        },
                        new()
                        {
                            ActorId = 4,
                            MovieId = 5
                        },
                        new()
                        {
                            ActorId = 5,
                            MovieId = 5
                        },


                        new()
                        {
                            ActorId = 3,
                            MovieId = 6
                        },
                        new()
                        {
                            ActorId = 4,
                            MovieId = 6
                        },
                        new()
                        {
                            ActorId = 5,
                            MovieId = 6
                        },
                    });
                    context.SaveChanges();
                }
            }
        }
    }
}

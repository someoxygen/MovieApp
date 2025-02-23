using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MovieApp.Data.Enums;

namespace MovieApp.Models
{
    public class MovieViewModel
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string ImageUrl { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public MovieCategory MovieCategory { get; set; }
        public List<ActorMovie> ActorMovies { get; set; }
        public int CinemaId { get; set; }
        [ForeignKey("CinemaId")]
        public CinemaViewModel Cinema { get; set; }
        public int ProducerId { get; set; }
        [ForeignKey("ProducerId")]
        public ProducerViewModel Producer { get; set; }
    }
}

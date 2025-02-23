using System.ComponentModel.DataAnnotations;

namespace MovieApp.Models
{
    public class ProducerViewModel
    {
        [Key]
        public int Id { get; set; }

        [Display(Name ="Profile Picture")]
        public string ProfilePictureUrl { get; set; }

        [Display(Name = "Full Name")]
        public string FullName { get; set; }

        [Display(Name = "About")]
        public string About { get; set; }
        public List<MovieViewModel> Movies { get; set; }
    }
}

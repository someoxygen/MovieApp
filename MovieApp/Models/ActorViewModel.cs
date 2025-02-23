using System.ComponentModel.DataAnnotations;
using MovieApp.Data.Base;

namespace MovieApp.Models
{
    public class ActorViewModel : IEntityBase
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Profile Picture URL")]
        [Required(ErrorMessage ="Profile Picture is required.")]
        public string ProfilePictureUrl { get; set; }

        [Display(Name = "Full Name")]
        [Required(ErrorMessage = "Full Name is required.")]
        [StringLength(50,MinimumLength = 3 ,ErrorMessage ="Full Name must be between 3 and 50 characters length.")]
        public string FullName { get; set; }

        [Display(Name ="About")]
        public string About { get; set; }
        public List<ActorMovie>? ActorMovies { get; set; }
    }
}

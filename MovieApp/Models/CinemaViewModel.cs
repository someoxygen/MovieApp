using System.ComponentModel.DataAnnotations;

namespace MovieApp.Models
{
    public class CinemaViewModel
    {
        [Key]
        public int Id { get; set; }

        [Display(Name="Logo")]
        public string Logo { get; set; }

        [Display(Name = "Name")]
        public string Name { get; set; }

        [Display(Name = "Description")]
        public string Description { get; set; }
    }
}

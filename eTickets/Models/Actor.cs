using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="Full name is required")]
        public string? FullName { get; set; }
        public string ProfilePictureURL { get; set; }
        public string Bio { get; set; }
    }
}

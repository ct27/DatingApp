
namespace API.DTOs
{
    public class RegisterDto
    {
        [Required]
        public string Name { get; set; }
        [Required]
        [StringLength(8, MinimumLength = 4)]
        public string Password { get; set; }

    }
}
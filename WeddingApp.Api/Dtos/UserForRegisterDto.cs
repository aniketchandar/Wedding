using System.ComponentModel.DataAnnotations;

namespace WeddingApp.Api.Dtos
{
    public class UserForRegisterDto
    {

        [Required]
        public string  Username { get; set; }

        [Required]
        [StringLength(8, MinimumLength = 4, ErrorMessage ="Your password specify between 4 to 8 Character")]
        public string Password { get; set; }
    }
}
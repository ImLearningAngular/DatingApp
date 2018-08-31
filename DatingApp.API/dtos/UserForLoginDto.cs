using System.ComponentModel.DataAnnotations;

namespace DatingApp.API.dtos
{
    public class UserForLoginDto
    {
        [Required]
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
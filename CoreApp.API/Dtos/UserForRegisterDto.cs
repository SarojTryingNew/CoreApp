using System.ComponentModel.DataAnnotations;

namespace CoreApp.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string UserName { get; set; }

        [Required]
        [StringLength(8,MinimumLength=4,ErrorMessage="Please enter min of 4 char")]
        public string Password { get; set; }
    }
}
using InstagramClone.Api.Entities;
using System.ComponentModel.DataAnnotations;

namespace InstagramClone.Api
{
    public class UserCreateDTO
    {
        public Guid Id { get; set; } //PK
        [Required(ErrorMessage ="Email is required")]
        public string Email { get; set; }
        [Required (ErrorMessage ="Password is required.")]
        public string Password { get; set; } 
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Avatar { get; set; }
        public ICollection<string> Roles { get; set; }
        public DateTime CreatedDate { get; set; }
        
    }
}

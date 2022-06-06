using System.ComponentModel.DataAnnotations;

namespace InstagramClone.Api.Entities
{
    public class User
    {
        [Key]
        public Guid UserId { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Avatar { get; set; }
        public DateTime CreatedDate { get; set; }

    }
}

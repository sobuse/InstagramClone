using System.ComponentModel.DataAnnotations;

namespace InstagramClone.Api.DTOs
{
    public class FollowersDto
    {
        [Required(ErrorMessage = "FollowedUserId is required")]
        public Guid FollowedUserId { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}

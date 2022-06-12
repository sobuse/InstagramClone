using System.ComponentModel.DataAnnotations.Schema;

namespace InstagramClone.Api.Entities
{
    public class UserFollower
    {
        public User User { get; set; } //Navigation property
        public User FollowedUserId { get; set; } //FK
        public Guid FollowerId { get; set; }
        public DateTime CreatedDate { get; set; }

    }
}

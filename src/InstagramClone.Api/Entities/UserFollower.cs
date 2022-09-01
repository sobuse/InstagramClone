using System.ComponentModel.DataAnnotations.Schema;

namespace InstagramClone.Api.Entities
{
    public class UserFollower
    {
        public UserManager FollowedUser { get; set; } //Navigation property
        public Guid FollowedUserId { get; set; } //FK
        public UserManager Follower { get; set; } //Navigation property
        public Guid FollowerId { get; set; } // Fk
        public DateTime CreatedDate { get; set; }
    }
}

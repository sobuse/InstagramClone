using System.ComponentModel.DataAnnotations.Schema;

namespace InstagramClone.Api.Entities
{
    public class UserFollower
    {
        public User FollowedUser { get; set; } //Navigation property
        public User FollowedUserId { get; set; } //FK
        public User Follower { get; set; } //Navigation property
        public User FollowerId { get; set; } // Fk
        public DateTime CreatedDate { get; set; }

    }
}

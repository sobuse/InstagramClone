using System.ComponentModel.DataAnnotations.Schema;

namespace InstagramClone.Api.Entities
{
    public class UserFollower
    {
        public User FollowedUser { get; set; } //Navigation property
        public Guid FollowedUserId { get; set; } //FK
        public User Follower { get; set; } //Navigation property
        public Guid FollowerId { get; set; } // Fk
        public DateTime CreatedDate { get; set; }
        public List<User_UserFollower> User_UserFollower { get; set; }

    }
}

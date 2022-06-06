using System.ComponentModel.DataAnnotations.Schema;

namespace InstagramClone.Api.Entities
{
    public class UserFollower
    {
        public User Users { get; set; }
        public Guid UserId { get; set; }
        public Guid FollowerId { get; set; }
        public DateTime CreatedDate { get; set; }

    }
}

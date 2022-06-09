using System.ComponentModel.DataAnnotations.Schema;

namespace InstagramClone.Api.Entities
{
    public class UserFollower
    {
        public Guid FollowedUserId { get; set; }
        public Guid FollowerId { get; set; }
        public DateTime CreatedDate { get; set; }

    }
}

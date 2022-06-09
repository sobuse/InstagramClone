using System.ComponentModel.DataAnnotations.Schema;

namespace InstagramClone.Api.Entities
{
    public class UserFollower
    {
        public User User { get; set; }
        public Guid Id { get; set; }
        public Guid FollowerId { get; set; }
        public DateTime CreatedDate { get; set; }

    }
}

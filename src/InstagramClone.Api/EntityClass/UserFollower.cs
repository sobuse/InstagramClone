using System.ComponentModel.DataAnnotations.Schema;

namespace InstagramClone.Api.EntityClass
{
    public class UserFollower
    {
        [ForeignKey("")]
        public Guid UserId { get; set; }
        [ForeignKey("")]
        public Guid FollowerId { get; set; }

        public DateTime CreatedDate { get; set; }

    }
}

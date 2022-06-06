using System.ComponentModel.DataAnnotations.Schema;

namespace InstagramClone.Api.Entities
{
    public class UserFollower
    {
        public User Users { get; set; }
        [ForeignKey("UserId")]
        public Guid UserId { get; set; }


        [ForeignKey("FollowerId")]
        public Guid FollowerId { get; set; }

        public DateTime CreatedDate { get; set; }

    }
}

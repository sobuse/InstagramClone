using System.ComponentModel.DataAnnotations.Schema;

namespace InstagramClone.Api.Entities
{
    public class UserFollower
    {
       
        public Guid FollowerId { get; set; }
        public DateTime CreatedDate { get; set; }

    }
}

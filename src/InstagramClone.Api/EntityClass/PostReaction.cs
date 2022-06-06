using System.ComponentModel.DataAnnotations.Schema;

namespace InstagramClone.Api.EntityClass
{
    public class PostReaction
    {
        [ForeignKey("")]
        public Guid PostId { get; set; }
        [ForeignKey("")]
        public Guid UserId { get; set; }
        public int ReactionType { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}

using System.ComponentModel.DataAnnotations.Schema;

namespace InstagramClone.Api.Entities
{
    public class PostReaction
    {
     
        public Post Posts{ get; set; }

        [ForeignKey("PostId")]
        public Guid PostId { get; set; }


        public User Users { get; set; }
        [ForeignKey("UserId")]
        public User UserId { get; set; }


        public int ReactionType { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}

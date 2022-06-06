namespace InstagramClone.Api.Entities
{
    public class PostReaction
    {
     
        public Post Posts{ get; set; }
        public Guid PostId { get; set; }
        public User Users { get; set; }
        public User UserId { get; set; }
        public int ReactionType { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}

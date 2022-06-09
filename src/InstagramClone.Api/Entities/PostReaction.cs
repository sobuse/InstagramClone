namespace InstagramClone.Api.Entities
{
    public class PostReaction
    {
     
        public Post Post{ get; set; }
        public Guid PostId { get; set; }
        public User User { get; set; }
        public User Id { get; set; }
        public int ReactionType { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}

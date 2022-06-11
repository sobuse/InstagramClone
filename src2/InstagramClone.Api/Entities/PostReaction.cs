namespace InstagramClone.Api.Entities
{
    public class PostReaction
    {
     
        public Post Post{ get; set; }
        public Guid Id { get; set; }
        public User Author { get; set; }
        public int Type { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}

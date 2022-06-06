namespace InstagramClone.Api.Entities
{
    public class Post
    {
        
        public Guid PostId { get; set; }
        public string Content { get; set; }
        public DateTime CreatedDate { get; set; }
        public User Users { get; set; }
        public Guid UserId { get; set; }
    }
}

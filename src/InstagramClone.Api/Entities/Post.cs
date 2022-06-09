namespace InstagramClone.Api.Entities
{
    public class Post
    {
        
        public Guid PostId { get; set; }
        public string Content { get; set; }
        public DateTime CreatedDate { get; set; }
        public User User { get; set; }
        public Guid AuthorId { get; set; }
    }
}

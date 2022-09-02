namespace InstagramClone.Api.Entities
{
    public class Post
    {
        
        public Guid Id { get; set; }
        public string Content { get; set; }
        public DateTime CreatedDate { get; set; }
        public User Author { get; set; } //Navigation property
        public Guid AuthorId { get; set; }  //FK
        public ICollection<PostReaction> PostReactions { get; set; }
       

    }
}

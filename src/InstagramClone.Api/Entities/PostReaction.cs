namespace InstagramClone.Api.Entities
{
    public class PostReaction
    {
        public Guid Id { get; set; }
        public Post Post{ get; set; } //Navigation property
        public Guid PostId { get; set; } //FK
        public User Author { get; set; } //Navigation property
        public Guid AuthorId { get; set; } //FK  person that reacted to the post
        public int Type { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}

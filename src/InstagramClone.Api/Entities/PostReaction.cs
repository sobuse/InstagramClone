namespace InstagramClone.Api.Entities
{
    public class PostReaction
    {
        public Guid Id { get; set; }
        public Post Post{ get; set; } //Navigation property
        public Post PostId { get; set; } //FK
        public User User { get; set; } //Navigation property
        public User AuthorId { get; set; } //FK
        public int Type { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}

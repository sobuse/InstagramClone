namespace InstagramClone.Api.Entities
{
    public class Post
    {
        
        public Guid Id { get; set; }
        public string Content { get; set; }
        public DateTime CreatedDate { get; set; }
        public User Author { get; set; } //Navigation property
        public User AuthorId { get; set; }  //FK
       


    }
}

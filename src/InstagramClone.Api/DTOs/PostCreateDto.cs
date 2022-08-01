namespace InstagramClone.Api.DTOs
{
    public class PostCreateDto
    {
        public Guid Id { get; set; }
        public string Content { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid AuthorId { get; set; }
    }
}

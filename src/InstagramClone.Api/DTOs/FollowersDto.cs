namespace InstagramClone.Api.DTOs
{
    public class FollowersDto
    {
        public Guid FollowedUserId { get; set; }
        public Guid FollowerId { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}

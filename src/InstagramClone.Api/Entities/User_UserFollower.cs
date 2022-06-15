namespace InstagramClone.Api.Entities
{
    public class User_UserFollower
    {
        public User User { get; set; }
        public Guid Id { get; set; }
        public UserFollower UserFollower { get; set; }
        public Guid FollowerId { get; set; }

    }
}

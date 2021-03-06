namespace InstagramClone.Api.Entities
{
    public class User
    {
        
        public Guid Id { get; set; } //PK
        public string Email { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Avatar { get; set; }
        public DateTime CreatedDate { get; set; }
        public ICollection<Post> Posts { get; set; } // Navigation
        public ICollection<UserFollower>   Followers { get; set; } // Navigation
        public ICollection<UserFollower> Followed { get; set; } // Navigation
        public ICollection<PostReaction> Reactions { get; set; } // Navigation

    }
}

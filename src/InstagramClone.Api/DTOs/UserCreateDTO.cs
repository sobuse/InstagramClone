namespace InstagramClone.Api
{
    public class UserCreateDTO
    {
        public Guid Id { get; set; } //PK
        public string Email { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Avatar { get; set; }
        public DateTime CreatedDate { get; set; }   
    }
}

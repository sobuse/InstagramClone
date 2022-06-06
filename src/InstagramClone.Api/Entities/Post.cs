using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InstagramClone.Api.EntityClass
{
    public class Post
    {
        [Key]
        public Guid PostId { get; set; }
        public string Content { get; set; }
        public DateTime CreatedDate { get; set; }

        public User Users { get; set; }
        [ForeignKey("UserId")]
        public Guid UserId { get; set; }
    }
}

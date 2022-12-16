using System;
using System.Collections.Generic;

namespace Domain.Models
{
    public partial class UserPost
    {
        public UserPost()
        {
            PostComments = new HashSet<PostComment>();
            PostLikes = new HashSet<PostLike>();
        }

        public int Id { get; set; }
        public int ProfileId { get; set; }
        public string WrittenText { get; set; } = null!;
        public string? MediaLocation { get; set; }
        public DateTime CreatedDatetime { get; set; }

        public virtual UserProfile Profile { get; set; } = null!;
        public virtual ICollection<PostComment> PostComments { get; set; }
        public virtual ICollection<PostLike> PostLikes { get; set; }
    }
}

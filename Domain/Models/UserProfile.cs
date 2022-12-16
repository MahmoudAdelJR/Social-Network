using System;
using System.Collections.Generic;

namespace Domain.Models
{
    public partial class UserProfile
    {
        public UserProfile()
        {
            PostComments = new HashSet<PostComment>();
            PostLikes = new HashSet<PostLike>();
            UserPosts = new HashSet<UserPost>();
        }

        public int Id { get; set; }
        public string EmailAddress { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string? Country { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string GivenName { get; set; } = null!;
        public string? Surname { get; set; }

        public virtual ICollection<PostComment> PostComments { get; set; }
        public virtual ICollection<PostLike> PostLikes { get; set; }
        public virtual ICollection<UserPost> UserPosts { get; set; }
    }
}

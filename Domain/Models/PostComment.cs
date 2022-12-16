using System;
using System.Collections.Generic;

namespace Domain.Models
{
    public partial class PostComment
    {
        public int Id { get; set; }
        public int PostId { get; set; }
        public int ProfileId { get; set; }
        public string CommentText { get; set; } = null!;
        public DateTime CreatedDatetime { get; set; }

        public virtual UserPost Post { get; set; } = null!;
        public virtual UserProfile Profile { get; set; } = null!;
    }
}

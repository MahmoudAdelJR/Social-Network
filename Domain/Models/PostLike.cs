using System;
using System.Collections.Generic;

namespace Domain.Models
{
    public partial class PostLike
    {
        public int Id { get; set; }
        public int PostId { get; set; }
        public int ProfileId { get; set; }
        public DateTime CreatedDatetime { get; set; }

        public virtual UserPost Post { get; set; } = null!;
        public virtual UserProfile Profile { get; set; } = null!;
    }
}

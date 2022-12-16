using System;
using System.Collections.Generic;

namespace Domain.Models
{
    public partial class Friendship
    {
        public int ProfileRequest { get; set; }
        public int ProfileAccept { get; set; }
        public bool IsAccepted { get; set; }

        public virtual UserProfile ProfileAcceptNavigation { get; set; } = null!;
        public virtual UserProfile ProfileRequestNavigation { get; set; } = null!;
    }
}

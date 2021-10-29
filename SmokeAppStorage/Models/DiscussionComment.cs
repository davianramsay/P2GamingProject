using System;
using System.Collections.Generic;

#nullable disable

namespace SmokeAppStorage.Models
{
    public partial class DiscussionComment
    {
        public int DiscussionCommentId { get; set; }
        public string Content { get; set; }
        public int UserId { get; set; }
        public int DiscussionId { get; set; }

        public virtual Discussion Discussion { get; set; }
        public virtual User User { get; set; }
    }
}

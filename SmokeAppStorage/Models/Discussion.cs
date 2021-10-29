using System;
using System.Collections.Generic;

#nullable disable

namespace SmokeAppStorage.Models
{
    public partial class Discussion
    {
        public Discussion()
        {
            DiscussionComments = new HashSet<DiscussionComment>();
        }

        public int DiscussionId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int UserId { get; set; }
        public int GameId { get; set; }

        public virtual Game Game { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<DiscussionComment> DiscussionComments { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace SmokeAppStorage.Models
{
    public partial class User
    {
        public User()
        {
            DiscussionComments = new HashSet<DiscussionComment>();
            Discussions = new HashSet<Discussion>();
            Reviews = new HashSet<Review>();
            Subscriptions = new HashSet<Subscription>();
        }

        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public DateTime Dob { get; set; }

        public virtual ICollection<DiscussionComment> DiscussionComments { get; set; }
        public virtual ICollection<Discussion> Discussions { get; set; }
        public virtual ICollection<Review> Reviews { get; set; }
        public virtual ICollection<Subscription> Subscriptions { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace SmokeAppStorage.Models
{
    public partial class Game
    {
        public Game()
        {
            Discussions = new HashSet<Discussion>();
            Reviews = new HashSet<Review>();
            Subscriptions = new HashSet<Subscription>();
        }

        public int GameId { get; set; }
        public string Name { get; set; }
        public string Apislug { get; set; }

        public virtual ICollection<Discussion> Discussions { get; set; }
        public virtual ICollection<Review> Reviews { get; set; }
        public virtual ICollection<Subscription> Subscriptions { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace SmokeAppStorage.Models
{
    public partial class Subscription
    {
        public int SubscriptionId { get; set; }
        public int UserId { get; set; }
        public int GameId { get; set; }

        public virtual Game Game { get; set; }
        public virtual User User { get; set; }
    }
}

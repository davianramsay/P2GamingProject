using System;
using System.Collections.Generic;

#nullable disable

namespace SmokeAppStorage.Models
{
    public partial class Review
    {
        public int ReviewId { get; set; }
        public string Content { get; set; }
        public int UserId { get; set; }
        public int GameId { get; set; }

        public virtual Game Game { get; set; }
        public virtual User User { get; set; }
    }
}

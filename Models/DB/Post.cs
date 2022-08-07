using System;
using System.Collections.Generic;

namespace BackEnd.Models.DB
{
    public partial class Post
    {
        public long Id { get; set; }
        public string Title { get; set; } = null!;
        public string Contents { get; set; } = null!;
        public DateTimeOffset Timestamp { get; set; }
        public long CategoryId { get; set; }

        public virtual Category Category { get; set; } = null!;
    }
}

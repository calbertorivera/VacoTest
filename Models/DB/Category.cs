using System;
using System.Collections.Generic;

namespace BackEnd.Models.DB
{
    public partial class Category
    {
        public Category()
        {
            Posts = new HashSet<Post>();
        }

        public long Id { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<Post> Posts { get; set; }
    }
}

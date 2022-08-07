using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace BackEnd.Business.Dto
{
    public partial class CategoryDto
    {
        public CategoryDto()
        {
            Posts = new HashSet<PostDto>();
        }

        public long Id { get; set; }
        public string? Name { get; set; }

        [JsonIgnore]
        public virtual ICollection<PostDto> Posts { get; set; }
    }
}

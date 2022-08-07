using AutoMapper.Configuration.Annotations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;
using System.Text.Json.Serialization;

namespace BackEnd.Business.Dto
{
    public partial class PostDto
    {
        public long Id { get; set; }
        [Required]
        public string? Title { get; set; }
        [Required]
        public string? Contents { get; set; }
        public DateTimeOffset? Timestamp { get; set; }
        [Required]
        public long? CategoryId { get; set; }

        [JsonIgnore]
        public virtual CategoryDto? Category { get; set; }

     
    }
}

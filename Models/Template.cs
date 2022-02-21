using System;
using System.Collections.Generic;

namespace TodoApi.Models
{
    public partial class Template
    {
        public long Id { get; set; }
        public string Title { get; set; } = null!;
        public string? PostDescription { get; set; }
        public string ImgUrl { get; set; } = null!;
    }
}

using System;
using System.Collections.Generic;

namespace TodoApi.Models
{
    public partial class Post
    {
        public Post()
        {
            Comments = new HashSet<Comment>();
            PostReactions = new HashSet<PostReaction>();
        }

        public long Id { get; set; }
        public string? PostDescription { get; set; }
        public string? ImgUrl { get; set; }
        public bool? IsActive { get; set; }
        public long UserId { get; set; }

        public virtual User User { get; set; } = null!;
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<PostReaction> PostReactions { get; set; }
    }
}

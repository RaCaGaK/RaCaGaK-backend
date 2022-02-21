using System;
using System.Collections.Generic;

namespace TodoApi.Models
{
    public partial class Comment
    {
        public long Id { get; set; }
        public string Msg { get; set; } = null!;
        public long UserId { get; set; }
        public long PostId { get; set; }

        public virtual Post Post { get; set; } = null!;
        public virtual User User { get; set; } = null!;
    }
}

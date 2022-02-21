using System;
using System.Collections.Generic;

namespace TodoApi.Models
{
    public partial class Reaction
    {
        public long Id { get; set; }
        public string? ReactionType { get; set; }
    }
}

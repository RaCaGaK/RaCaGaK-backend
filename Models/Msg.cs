using System;
using System.Collections.Generic;

namespace TodoApi.Models
{
    public partial class Msg
    {
        public long Id { get; set; }
        public string Msg1 { get; set; } = null!;
        public DateTime SentDate { get; set; }
        public bool? ReadDate { get; set; }
        public long FromUser { get; set; }
        public long ToUser { get; set; }

        public virtual User FromUserNavigation { get; set; } = null!;
        public virtual User ToUserNavigation { get; set; } = null!;
    }
}

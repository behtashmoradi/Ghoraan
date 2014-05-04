using System;
using System.Collections.Generic;

namespace RunTextNormalizer.Models
{
    public partial class Chapter
    {
        public Chapter()
        {
            this.Keywords = new List<Keyword>();
        }

        public int Id { get; set; }
        public int Section { get; set; }
        public int ItemId { get; set; }
        public string Text { get; set; }
        public virtual ICollection<Keyword> Keywords { get; set; }
    }
}

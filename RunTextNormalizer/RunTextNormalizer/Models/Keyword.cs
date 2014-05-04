using System;
using System.Collections.Generic;

namespace RunTextNormalizer.Models
{
    public partial class Keyword
    {
        public int Id { get; set; }
        public int ChapterId { get; set; }
        public string Keyword1 { get; set; }
        public string NormalizedKeyword { get; set; }
        public virtual Chapter Chapter { get; set; }
    }
}

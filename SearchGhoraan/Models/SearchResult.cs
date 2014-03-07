using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SearchGhoraan.Models
{
    public class SearchResult
    {
        public int sectionId { get; set; }
        public int ChapterId { get; set; }
        public int ItemId { get; set; }
        public string Text { get; set; }
        
    }
}
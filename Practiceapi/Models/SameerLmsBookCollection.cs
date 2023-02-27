using System;
using System.Collections.Generic;

namespace Practiceapi.Models
{
    public partial class SameerLmsBookCollection
    {
        public string BookName { get; set; } = null!;
        public string Isbn { get; set; } = null!;
        public string PublishDate { get; set; } = null!;
        public string Category { get; set; } = null!;
        public int Quantity { get; set; }
        public string? AuthorName { get; set; }
    }
}

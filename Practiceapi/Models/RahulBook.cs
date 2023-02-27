using System;
using System.Collections.Generic;

namespace Practiceapi.Models
{
    public partial class RahulBook
    {
        public RahulBook()
        {
            RahulBookings = new HashSet<RahulBooking>();
        }

        public int BookId { get; set; }
        public string BookName { get; set; } = null!;
        public string BookAuthor { get; set; } = null!;
        public int BookQty { get; set; }

        public virtual ICollection<RahulBooking> RahulBookings { get; set; }
    }
}

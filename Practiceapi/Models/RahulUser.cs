using System;
using System.Collections.Generic;

namespace Practiceapi.Models
{
    public partial class RahulUser
    {
        public RahulUser()
        {
            RahulBookings = new HashSet<RahulBooking>();
        }

        public int Userid { get; set; }
        public string Username { get; set; } = null!;
        public string Userpassword { get; set; } = null!;
        public bool IsAdmin { get; set; }

        public virtual ICollection<RahulBooking> RahulBookings { get; set; }
    }
}

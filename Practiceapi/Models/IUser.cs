using System;
using System.Collections.Generic;

namespace Practiceapi.Models
{
    public partial class IUser
    {
        public IUser()
        {
            IBookings = new HashSet<IBooking>();
        }

        public int UserId { get; set; }
        public string UserPassword { get; set; } = null!;
        public string UserName { get; set; } = null!;
        public string UserEmail { get; set; } = null!;
        public string? UserPhone { get; set; }

        public virtual ICollection<IBooking> IBookings { get; set; }
    }
}

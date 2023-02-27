using System;
using System.Collections.Generic;

namespace Practiceapi.Models
{
    public partial class Customer
    {
        public Customer()
        {
            Reviews = new HashSet<Review>();
            TransactionVrms = new HashSet<TransactionVrm>();
        }

        public int Userid { get; set; }
        public string Username { get; set; } = null!;
        public string Password { get; set; } = null!;

        public virtual ICollection<Review> Reviews { get; set; }
        public virtual ICollection<TransactionVrm> TransactionVrms { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Practiceapi.Models
{
    public partial class Companyawa
    {
        public Companyawa()
        {
            Flightawas = new HashSet<Flightawa>();
        }

        public string Cid { get; set; } = null!;
        public string? Cname { get; set; }

        public virtual ICollection<Flightawa> Flightawas { get; set; }
    }
}

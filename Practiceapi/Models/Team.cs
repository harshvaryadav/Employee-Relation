using System;
using System.Collections.Generic;

namespace Practiceapi.Models
{
    public partial class Team
    {
        public Team()
        {
            Emps = new HashSet<Emp>();
        }

        public int? Id { get; set; }
        public string TeamName { get; set; } = null!;
        public string? TeamLead { get; set; }

        public virtual ICollection<Emp> Emps { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Practiceapi.Models
{
    public partial class Empharshit
    {
        public Empharshit()
        {
            EmpHarshitBranches = new HashSet<EmpHarshitBranch>();
        }

        public int Eid { get; set; }
        public string? Ename { get; set; }
        public int? Salary { get; set; }
        public DateTime? Doj { get; set; }
        public string? City { get; set; }

        public virtual ICollection<EmpHarshitBranch> EmpHarshitBranches { get; set; }
    }
}

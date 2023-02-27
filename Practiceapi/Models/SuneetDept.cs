using System;
using System.Collections.Generic;

namespace Practiceapi.Models
{
    public partial class SuneetDept
    {
        public SuneetDept()
        {
            SuneetEmployees = new HashSet<SuneetEmployee>();
        }

        public int DeptId { get; set; }
        public string? Dname { get; set; }
        public int? NoOfEmployees { get; set; }

        public virtual ICollection<SuneetEmployee> SuneetEmployees { get; set; }
    }
}

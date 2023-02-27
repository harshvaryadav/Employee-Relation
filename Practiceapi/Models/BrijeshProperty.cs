using System;
using System.Collections.Generic;

namespace Practiceapi.Models
{
    public partial class BrijeshProperty
    {
        public BrijeshProperty()
        {
            BrijeshTrans = new HashSet<BrijeshTran>();
        }

        public int PropertyId { get; set; }
        public int? SellerpId { get; set; }
        public string? PName { get; set; }
        public string? Loc { get; set; }

        public virtual BrijeshSeller? Sellerp { get; set; }
        public virtual ICollection<BrijeshTran> BrijeshTrans { get; set; }
    }
}

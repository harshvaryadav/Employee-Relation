using System;
using System.Collections.Generic;

namespace Practiceapi.Models
{
    public partial class BrijeshBuyer
    {
        public BrijeshBuyer()
        {
            BrijeshTrans = new HashSet<BrijeshTran>();
        }

        public int BuyerId { get; set; }
        public string? BuyerName { get; set; }
        public string? BuyerPassword { get; set; }

        public virtual ICollection<BrijeshTran> BrijeshTrans { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Practiceapi.Models
{
    public partial class Vehicle
    {
        public Vehicle()
        {
            Reviews = new HashSet<Review>();
            TransactionVrms = new HashSet<TransactionVrm>();
        }

        public int VehicleId { get; set; }
        public string ModelName { get; set; } = null!;
        public string RegistrationNumber { get; set; } = null!;
        public string VehicleType { get; set; } = null!;
        public int DailyRent { get; set; }
        public bool? IsAvailable { get; set; }

        public virtual ICollection<Review> Reviews { get; set; }
        public virtual ICollection<TransactionVrm> TransactionVrms { get; set; }
    }
}

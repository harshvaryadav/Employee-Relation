using System;
using System.Collections.Generic;

namespace Practiceapi.Models
{
    public partial class ServiceProvider
    {
        public ServiceProvider()
        {
            Places = new HashSet<TouristPlace>();
        }

        public int ProviderId { get; set; }
        public string Name { get; set; } = null!;
        public string Email { get; set; } = null!;
        public int Phone { get; set; }
        public string ProviderType { get; set; } = null!;
        public decimal ProviderRating { get; set; }

        public virtual ICollection<TouristPlace> Places { get; set; }
    }
}

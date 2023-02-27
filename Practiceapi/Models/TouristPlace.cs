using System;
using System.Collections.Generic;

namespace Practiceapi.Models
{
    public partial class TouristPlace
    {
        public TouristPlace()
        {
            PlaceImages = new HashSet<PlaceImage>();
            Providers = new HashSet<ServiceProvider>();
        }

        public int PlaceId { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string City { get; set; } = null!;
        public string State { get; set; } = null!;
        public string Country { get; set; } = null!;
        public decimal PlaceRating { get; set; }

        public virtual ICollection<PlaceImage> PlaceImages { get; set; }

        public virtual ICollection<ServiceProvider> Providers { get; set; }
    }
}

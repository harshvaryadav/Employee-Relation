using System;
using System.Collections.Generic;

namespace Practiceapi.Models
{
    public partial class FlightbookingAvani
    {
        public int Bid { get; set; }
        public int? UserId { get; set; }
        public int? FlightNo { get; set; }
        public int? Numberofseats { get; set; }

        public virtual FlightAvani? FlightNoNavigation { get; set; }
        public virtual FlightuserAvani? User { get; set; }
    }
}

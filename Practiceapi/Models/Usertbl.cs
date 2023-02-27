using System;
using System.Collections.Generic;

namespace Practiceapi.Models
{
    public partial class Usertbl
    {
        public string UserId { get; set; } = null!;
        public string? UserName { get; set; }
        public string? Password { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Practiceapi.Models
{
    public partial class Authorhritik
    {
        public Authorhritik()
        {
            Bookhritiks = new HashSet<Bookhritik>();
        }

        public int Aid { get; set; }
        public string? Aname { get; set; }
        public int? Age { get; set; }
        public string? Place { get; set; }
        public string? Speciality { get; set; }

        public virtual ICollection<Bookhritik> Bookhritiks { get; set; }
    }
}

using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RepositoryPatternDemo.DL
{
    public partial class Doctor : BaseModel
    {
        public Doctor()
        {
            Appointment = new HashSet<Appointment>();
        }

        public string Name { get; set; }
        public long HospitalId { get; set; }

        public virtual Hospital Hospital { get; set; }
        public virtual ICollection<Appointment> Appointment { get; set; }
    }
}

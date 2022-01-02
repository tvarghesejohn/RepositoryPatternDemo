using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RepositoryPatternDemo.DL
{
    public partial class Appointment : BaseModel
    {
        public long DoctorId { get; set; }
        public bool? NineToTen { get; set; }
        public bool? TenToEleven { get; set; }

        public virtual Doctor Doctor { get; set; }
    }
}

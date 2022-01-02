using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RepositoryPatternDemo.DL
{
    public partial class Hospital : BaseModel
    {
        public Hospital()
        {
            Doctor = new HashSet<Doctor>();
        }

        public string HospitalName { get; set; }
        public string HospitalDescription { get; set; }

        public virtual ICollection<Doctor> Doctor { get; set; }
    }
}

using System.Collections.Generic;

namespace RepositoryPatternDemo.Models
{
    public class Doctor : BaseModel
    {
        public string Name { get; set; }
        public Hospital HospitalId { get; set; }
        public List<Appointment> Appointments { get; set; }
    }
}

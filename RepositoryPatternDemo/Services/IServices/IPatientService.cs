using RepositoryPatternDemo.DL;
using System.Collections.Generic;

namespace RepositoryPatternDemo.IServices
{
    public interface IPatientService
    {
        public List<Patient> GetAllPatients();
        public Patient GetPatient(int id);
        public string AddPatient(Patient patient);
        public string UpdatePatient(Patient patient);
        public string DeletePatient(int id);
    }
}

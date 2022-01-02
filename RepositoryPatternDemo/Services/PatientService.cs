using RepositoryPatternDemo.DL;
using RepositoryPatternDemo.IRepositories;
using RepositoryPatternDemo.IServices;
using System.Collections.Generic;

namespace RepositoryPatternDemo.Services
{
    public class PatientService : IPatientService
    {
        private readonly IBaseRepository<Patient> _patientRepository;

        public PatientService(IBaseRepository<Patient> patientRepository)
        {
            _patientRepository = patientRepository;
        }

        public List<Patient> GetAllPatients()
        {
            var patients = _patientRepository.GetAll();
            return patients;
        }

        public Patient GetPatient(int id)
        {
            var patient = _patientRepository.GetById(id);
            return patient;
        }

        public string AddPatient(Patient patient)
        {
            var result = _patientRepository.Add(patient);
            return result.ToString();
        }

        public string DeletePatient(int id)
        {
            var result = _patientRepository.Delete(id);
            return result.ToString();
        }

        public string UpdatePatient(Patient patient)
        {
            var result = _patientRepository.Update(patient);
            return result.ToString();
        }
    }
}

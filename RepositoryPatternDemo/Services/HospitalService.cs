using RepositoryPatternDemo.DL;
using RepositoryPatternDemo.IRepositories;
using RepositoryPatternDemo.Services.IServices;
using System.Collections.Generic;

namespace RepositoryPatternDemo.Services
{
    public class HospitalService : IHospitalService
    {
        private readonly IBaseRepository<Hospital> _hospitalRepository;

        public HospitalService(IBaseRepository<Hospital> hospitalRepository)
        {
            _hospitalRepository = hospitalRepository;
        }

        public string AddHospital(Hospital hospital)
        {
            var result = _hospitalRepository.Add(hospital);
            return result.ToString();
        }

        public string DeleteHospital(int id)
        {
            var result = _hospitalRepository.Delete(id);
            return result.ToString();
        }

        public List<Hospital> GetAllHospitals()
        {
            var hospitals = _hospitalRepository.GetAll();
            return hospitals;
        }

        public Hospital GetHospital(int id)
        {
            var hospital = _hospitalRepository.GetById(id);
            return hospital;
        }

        public string UpdateHospital(Hospital hospital)
        {
            var result = _hospitalRepository.Update(hospital);
            return result.ToString();
        }
    }
}

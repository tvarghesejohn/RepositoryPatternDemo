using RepositoryPatternDemo.Models;
using System.Collections.Generic;

namespace RepositoryPatternDemo.Services.IServices
{
    public interface IHospitalService
    {
        public List<Hospital> GetAllHospitals();
        public Hospital GetHospital(int id);
        public string AddHospital(Hospital hospital);
        public string UpdateHospital(Hospital hospital);
        public string DeleteHospital(int id);
    }
}

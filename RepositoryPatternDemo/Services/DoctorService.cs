﻿using RepositoryPatternDemo.IRepositories;
using RepositoryPatternDemo.Models;
using RepositoryPatternDemo.Services.IServices;
using System.Collections.Generic;

namespace RepositoryPatternDemo.Services
{
    public class DoctorService : IDoctorService
    {
        private readonly IBaseRepository<Doctor> _doctorRepository;

        public DoctorService(IBaseRepository<Doctor> doctorRepository)
        {
            _doctorRepository = doctorRepository;
        }

        public string AddDoctor(Doctor doctor)
        {
            var result = _doctorRepository.Add(doctor);
            return result.ToString();
        }

        public string DeleteDoctor(int id)
        {
            var result = _doctorRepository.Delete(id);
            return result.ToString();
        }

        public List<Doctor> GetAllDoctors()
        {
            var doctors = _doctorRepository.GetAll();
            return doctors;
        }

        public Doctor GetDoctor(int id)
        {
            var doctor = _doctorRepository.GetById(id);
            return doctor;
        }

        public string UpdateDoctor(Doctor doctor)
        {
            var result = _doctorRepository.Update(doctor);
            return result.ToString();
        }
    }
}

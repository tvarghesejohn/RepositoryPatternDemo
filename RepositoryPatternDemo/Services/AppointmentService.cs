﻿using RepositoryPatternDemo.IRepositories;
using RepositoryPatternDemo.Models;
using RepositoryPatternDemo.Services.IServices;
using System.Collections.Generic;

namespace RepositoryPatternDemo.Services
{
    public class AppointmentService : IAppointmentService
    {
        private readonly IBaseRepository<Appointment> _appointmentRepository;

        public AppointmentService(IBaseRepository<Appointment> appointmentRepository)
        {
            _appointmentRepository = appointmentRepository;
        }

        public string AddAppointment(Appointment appointment)
        {
            var result = _appointmentRepository.Add(appointment);
            return result.ToString();
        }

        public string DeleteAppointment(int id)
        {
            var result = _appointmentRepository.Delete(id);
            return result.ToString();
        }

        public List<Appointment> GetAllAppointments()
        {
            var appointments = _appointmentRepository.GetAll();
            return appointments;
        }

        public Appointment GetAppointment(int id)
        {
            var appointment = _appointmentRepository.GetById(id);
            return appointment;
        }

        public string UpdateAppointment(Appointment appointment)
        {
            var result = _appointmentRepository.Update(appointment);
            return result.ToString();
        }
    }
}

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RepositoryPatternDemo.DL;
using RepositoryPatternDemo.Services.IServices;
using System.Collections.Generic;

namespace RepositoryPatternDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppointmentController : ControllerBase
    {
        private readonly IAppointmentService _appointmentService;

        public AppointmentController(IAppointmentService appointmentService)
        {
            _appointmentService = appointmentService;
        }

        [HttpGet("GetAll")]
        public ActionResult<IEnumerable<Appointment>> GetAll()
        {
            var result = _appointmentService.GetAllAppointments();
            return result;
        }

        [HttpGet("GetById/{id}")]
        public ActionResult<Appointment> GetById(int id)
        {
            var result = _appointmentService.GetAppointment(id);
            return result;
        }

        [HttpPost("AddAppointment")]
        public ActionResult<Appointment> AddAppointment([FromBody]Appointment appointment)
        {
            var result = _appointmentService.AddAppointment(appointment);
            if (result == "sucess")
            {
                return Ok(result);
            }
            else
            {
                return StatusCode(500, result);
            }
        }

        [HttpPost("UpdateAppointment")]
        public ActionResult<Appointment> UpdateAppointment([FromBody] Appointment appointment)
        {
            var result = _appointmentService.UpdateAppointment(appointment);
            if (result == "sucess")
            {
                return Ok(result);
            }
            else
            {
                return StatusCode(500, result);
            }
        }

        [HttpPost("DeleteAppointment/{id}")]
        public ActionResult<Appointment> DeleteAppointment(int id)
        {
            var result = _appointmentService.DeleteAppointment(id);
            if (result == "sucess")
            {
                return Ok(result);
            }
            else
            {
                return StatusCode(500, result);
            }
        }
    }
}

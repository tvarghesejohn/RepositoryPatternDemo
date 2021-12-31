using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RepositoryPatternDemo.Models;
using RepositoryPatternDemo.Services.IServices;
using System.Collections.Generic;

namespace RepositoryPatternDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorController : ControllerBase
    {
        private readonly IDoctorService _doctorService;

        public DoctorController(IDoctorService doctorService)
        {
            _doctorService = doctorService;
        }

        [HttpGet("GetAll")]
        public ActionResult<IEnumerable<Doctor>> GetAll()
        {
            var result = _doctorService.GetAllDoctors();
            return result;
        }

        [HttpGet("GetById/{id}")]
        public ActionResult<Doctor> GetById(int id)
        {
            var result = _doctorService.GetDoctor(id);
            return result;
        }

        [HttpPost("AddDoctor/{doctor}")]
        public ActionResult<Doctor> AddDoctor(Doctor doctor)
        {
            var result = _doctorService.AddDoctor(doctor);
            if (result == "sucess")
            {
                return Ok(result);
            }
            else
            {
                return StatusCode(500, result);
            }
        }

        [HttpPost("UpdateDoctor/{doctor}")]
        public ActionResult<Doctor> UpdateDoctor(Doctor doctor)
        {
            var result = _doctorService.UpdateDoctor(doctor);
            if (result == "sucess")
            {
                return Ok(result);
            }
            else
            {
                return StatusCode(500, result);
            }
        }

        [HttpPost("DeleteDoctor/{id}")]
        public ActionResult<Doctor> DeleteDoctor(int id)
        {
            var result = _doctorService.DeleteDoctor(id);
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

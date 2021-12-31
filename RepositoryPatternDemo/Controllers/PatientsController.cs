using Microsoft.AspNetCore.Mvc;
using RepositoryPatternDemo.IServices;
using RepositoryPatternDemo.Models;
using System.Collections.Generic;

namespace RepositoryPatternDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientsController : ControllerBase
    {
        private readonly IPatientService _patientService;

        public PatientsController(IPatientService patientService)
        {
            _patientService = patientService;
        }

        [HttpGet("GetAll")]
        public ActionResult<IEnumerable<Patient>> GetAll()
        {
            var result = _patientService.GetAllPatients();
            return result;
        }

        [HttpGet("GetById/{id}")]
        public ActionResult<Patient> GetById(int id)
        {
            var result = _patientService.GetPatient(id);
            return result;
        }

        [HttpPost("AddPatient/{patient}")]
        public ActionResult<Patient> AddPatient(Patient patient)
        {
            var result = _patientService.AddPatient(patient);
            if(result == "sucess")
            {
                return Ok(result);
            }
            else
            {
                return StatusCode(500, result);
            }
        }

        [HttpPost("UpdatePatient/{patient}")]
        public ActionResult<Patient> UpdatePatient(Patient patient)
        {
            var result = _patientService.UpdatePatient(patient);
            if (result == "sucess")
            {
                return Ok(result);
            }
            else
            {
                return StatusCode(500, result);
            }
        }

        [HttpPost("DeletePatient/{id}")]
        public ActionResult<Patient> DeletePatient(int id)
        {
            var result = _patientService.DeletePatient(id);
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

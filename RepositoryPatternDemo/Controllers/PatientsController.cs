using Microsoft.AspNetCore.Mvc;
using RepositoryPatternDemo.DL;
using RepositoryPatternDemo.IServices;
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

        [HttpPost("AddPatient")]
        public ActionResult<Patient> AddPatient([FromBody]Patient patient)
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

        [HttpPost("UpdatePatient")]
        public ActionResult<Patient> UpdatePatient([FromBody] Patient patient)
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

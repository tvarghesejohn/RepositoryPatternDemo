using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RepositoryPatternDemo.Models;
using RepositoryPatternDemo.Services.IServices;
using System.Collections.Generic;

namespace RepositoryPatternDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HospitalController : ControllerBase
    {
        private readonly IHospitalService _hospitalService;

        public HospitalController(IHospitalService hospitalService)
        {
            _hospitalService = hospitalService;
        }

        [HttpGet("GetAll")]
        public ActionResult<IEnumerable<Hospital>> GetAll()
        {
            var result = _hospitalService.GetAllHospitals();
            return result;
        }

        [HttpGet("GetById/{id}")]
        public ActionResult<Hospital> GetById(int id)
        {
            var result = _hospitalService.GetHospital(id);
            return result;
        }

        [HttpPost("AddHospital/{hospital}")]
        public ActionResult<Patient> AddHospital(Hospital hospital)
        {
            var result = _hospitalService.AddHospital(hospital);
            if (result == "sucess")
            {
                return Ok(result);
            }
            else
            {
                return StatusCode(500, result);
            }
        }

        [HttpPost("UpdateHospital/{hospital}")]
        public ActionResult<Hospital> UpdateHospital(Hospital hospital)
        {
            var result = _hospitalService.UpdateHospital(hospital);
            if (result == "sucess")
            {
                return Ok(result);
            }
            else
            {
                return StatusCode(500, result);
            }
        }

        [HttpPost("DeleteHospital/{id}")]
        public ActionResult<Hospital> DeleteHospital(int id)
        {
            var result = _hospitalService.DeleteHospital(id);
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

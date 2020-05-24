using System;
using System.Linq;
using APBD_11.Models;
using APBD_11.Models.Requests;
using APBD_11.Services;
using Microsoft.AspNetCore.Mvc;

namespace APBD_11.Controllers
{
    [Route("api/doctors")]
    [ApiController]
    public class DoctorController : ControllerBase
    {
        private readonly IDbService _dbService;

        public DoctorController(IDbService service)
        {
            _dbService = service;
        }

        [HttpGet]
        public IActionResult GetAllDoctors()
        {
            var doctors = _dbService.GetAllDoctors();
            
                return !doctors.Any() ? StatusCode(404,"No Doctors Found") : StatusCode(200, doctors);
        }

        [HttpGet("{doctorId}")]
        public IActionResult GetDoctor(int doctorId)
        {
            var doctor = _dbService.GetDoctorById(doctorId);
            if (doctor == null)
            {
                return StatusCode(404, "No doctor with id " + doctorId);
            }
            return Ok(doctor);
        }

        [HttpPost("add")]
        public IActionResult AddNewDoctor(AddDoctorRequest doctorRequest)
        {
            var errors = ValidationHelper.ValidateAddDoctorRequest(doctorRequest);
            if (errors.Count > 0)
            {
                return StatusCode(400, errors);
            }
            var addDoctorResponse = _dbService.AddDoctor(doctorRequest);
            return (StatusCode(201, addDoctorResponse));
        }

        [HttpPost("modify")]
        public IActionResult ModifyDoctor(ModifyDoctorRequest doctorRequest)
        {
            var errors = ValidationHelper.ValidateModifyDoctorRequest(doctorRequest);
            
            if (errors.Count > 0)
            {
                return StatusCode(400, errors);
            }

            bool exists = _dbService.DoctorExists(Convert.ToInt32(doctorRequest.IdDoctor));

            if (exists)
            {
                ModifyDoctorResponse response = _dbService.ModifyDoctor(doctorRequest);
                return (StatusCode(201, response));
            }
            return StatusCode(404, "No doctor with id " + doctorRequest.IdDoctor);
        }

        [HttpDelete]
        [Route("{doctorId}/delete")]
        public IActionResult DeleteDoctor(int doctorId)
        {
            bool exists = _dbService.DoctorExists(doctorId);
            if (exists)
            {
                _dbService.DeleteDoctor(doctorId);
                return StatusCode(204);
            }
            return StatusCode(404, "No doctor with id " + doctorId);
        }
    }
}
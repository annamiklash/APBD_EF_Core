using System;
using System.Collections.Generic;
using System.Linq;
using APBD_11.Models;
using APBD_11.Models.Requests;

namespace APBD_11.Services
{
    public class DbService : IDbService
    {
        private readonly MyDbContext _context;

        public DbService(MyDbContext context)
        {
            _context = context;
        }

        public bool DoctorExists(int doctorId)
        {
            return _context.Doctor
                .Any(doctor => doctor.IdDoctor.Equals(doctorId));
        }

        public IEnumerable<Doctor> GetAllDoctors()
        {
            List<Doctor> doctors = new List<Doctor>();
            try
            {
                doctors = _context.Doctor.ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return doctors;
        }

        public Doctor GetDoctorById(int doctorId)
        {
            var doctorExists = DoctorExists(doctorId);

            if (doctorExists)
            {
                return _context.Doctor.FirstOrDefault(doctor => doctor.IdDoctor.Equals(doctorId));
            }

            return null;
        }

        public AddDoctorResponse AddDoctor(AddDoctorRequest doctorRequest)
        {
            var doctorExists = DoctorExists(Convert.ToInt32(doctorRequest.IdDoctor));
            if (doctorExists)
            {
                int newId = GenerateNewDoctorId();
                doctorRequest.IdDoctor = newId.ToString();
            }

            var doctor = new Doctor()
            {
                IdDoctor = Convert.ToInt32(doctorRequest.IdDoctor),
                FirstName = doctorRequest.FirstName,
                LastName = doctorRequest.LastName,
                Email = doctorRequest.Email
            };

            _context.Doctor.Add(doctor);
            _context.SaveChanges();

            return new AddDoctorResponse()
            {
                AssignedId = Convert.ToInt32(doctorRequest.IdDoctor),
                LastName = doctorRequest.LastName
            };
        }

        public ModifyDoctorResponse ModifyDoctor(ModifyDoctorRequest doctorRequest)
        {
            var doctor = _context.Doctor
                .FirstOrDefault(d => d.IdDoctor == Int32.Parse(doctorRequest.IdDoctor));

            var response = new ModifyDoctorResponse();
            response.IdDoctor = doctorRequest.IdDoctor;

            if (!string.IsNullOrEmpty(doctorRequest.FirstName))
            {
                doctor.FirstName = doctorRequest.FirstName;
                _context.SaveChanges();
                response.FirstName = doctor.FirstName;
            }

            if (!string.IsNullOrEmpty(doctorRequest.LastName))
            {
                doctor.LastName = doctorRequest.LastName;
                _context.SaveChanges();
                response.LastName = doctor.LastName;
            }

            if (!string.IsNullOrEmpty(doctorRequest.Email))
            {
                doctor.Email = doctorRequest.Email;
                _context.SaveChanges();
                response.Email = doctor.Email;
             
            }

            return response;
        }

        public void DeleteDoctor(int doctorId)
        {
            var doctor = _context.Doctor
                .FirstOrDefault(d => d.IdDoctor == doctorId);

            _context.Doctor.Remove(doctor);
            _context.SaveChanges();
        }

        private int GenerateNewDoctorId()
        {
            return _context.Doctor.Max(doctor => doctor.IdDoctor) + 1;
        }
    }
}

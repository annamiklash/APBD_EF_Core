using System.Collections.Generic;
using APBD_11.Models;
using APBD_11.Models.Requests;

namespace APBD_11.Services
{
    public interface IDbService
    {
        bool DoctorExists(int doctorId);
        IEnumerable<Doctor> GetAllDoctors();
        Doctor GetDoctorById(int doctorId);
        AddDoctorResponse AddDoctor(AddDoctorRequest doctorRequest);
        ModifyDoctorResponse ModifyDoctor(ModifyDoctorRequest doctorRequest);

        void DeleteDoctor(int doctorId);
    }
}
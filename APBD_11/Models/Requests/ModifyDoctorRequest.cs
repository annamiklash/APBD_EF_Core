#nullable enable
using System.Text.RegularExpressions;

namespace APBD_11.Models.Requests
{
    public class ModifyDoctorRequest : Request
    {
        public string IdDoctor { get; set; }
        public string? FirstName{ get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
    }
}
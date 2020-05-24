using System.ComponentModel.DataAnnotations;

namespace APBD_11.Models.Requests
{
    public class AddDoctorRequest 
    {
        [Required] public string IdDoctor { get; set; }
        [Required] public string FirstName { get; set; }
        [Required] public string LastName { get; set; }
        [Required] public string Email { get; set; }
    }
}
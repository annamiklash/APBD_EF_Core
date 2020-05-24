namespace APBD_11.Models.Requests
{
    public class AddDoctorRequest : Request
    {
        public string IdDoctor { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
    }
}
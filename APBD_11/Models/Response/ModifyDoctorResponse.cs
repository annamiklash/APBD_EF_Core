﻿using System.ComponentModel.DataAnnotations;

namespace APBD_11.Models
{
    public class ModifyDoctorResponse
    {
       [Required] public string IdDoctor { get; set; }
        public string? FirstName{ get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
    }
}
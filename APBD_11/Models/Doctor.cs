using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace APBD_11.Models
{
    public class Doctor
    {
        public int IdDoctor { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        
        [JsonIgnore]
        public virtual ICollection<Prescription> Prescription { get; set; }

    }
}
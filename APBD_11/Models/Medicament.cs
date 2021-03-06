﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace APBD_11.Models
{
    public class Medicament
    {
        public int IdMedicament { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }

        public virtual ICollection<Prescription_Medicament> Prescription_Medicament { get; set; }
    }
}
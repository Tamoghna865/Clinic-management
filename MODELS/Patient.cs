using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Clinic_Management_API.MODELS
{
    public class Patient
    {
        [Key]
        public int PatientId { get; set; }
        public string Name { get; set; }

        public string Email { get; set; }
        public string Password { get; set; }

    }
}

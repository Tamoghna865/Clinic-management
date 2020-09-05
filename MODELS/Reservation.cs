using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clinic_Management_API.MODELS
{
    public class Reservation
    {
        public int PatientId { get; set; }
        public int DoctorId { get; set; }

        public int ReservationId { get; set; }
    }
}

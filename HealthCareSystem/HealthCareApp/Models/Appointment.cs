#region Namespaces
using System;
#endregion

namespace HealthCareApp.Models
{
    #region Appointment Class
    public class Appointment
    {
        #region Properties
        public int PatientId { get; set; }
        public int DoctorId { get; set; }
        public DateTime AppointmentDate { get; set; }
        #endregion

        #region Navigation Properties
        public Patient Patient { get; set; }
        public Doctor Doctor { get; set; }
        #endregion
    }
    #endregion
}
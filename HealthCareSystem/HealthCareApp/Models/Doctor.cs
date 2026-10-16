#region Namespaces
using System;
using System.Collections.Generic;
#endregion

namespace HealthCareApp.Models
{
    #region Doctor Class
    public class Doctor
    {
        #region Properties
        public int Id { get; set; }
        public string Name { get; set; }
        public string Specialization { get; set; }
        #endregion

        #region Navigation Properties
        public ICollection<Appointment> Appointments { get; set; }
        #endregion
    }
    #endregion
}
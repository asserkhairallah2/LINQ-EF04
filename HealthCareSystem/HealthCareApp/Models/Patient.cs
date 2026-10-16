#region Namespaces
using System;
using System.Collections.Generic;
#endregion

namespace HealthCareApp.Models
{
    #region Patient Class
    public class Patient
    {
        #region Properties
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        #endregion

        #region Navigation Properties
        public ICollection<Appointment> Appointments { get; set; }
        #endregion
    }
    #endregion
}
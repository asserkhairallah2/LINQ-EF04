#region Namespaces
using System;
using System.Collections.Generic;
#endregion

namespace EcommerceApp.Models
{
    #region Customer Class
    public class Customer
    {
        #region Properties
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        #endregion

        #region Navigation Properties
        public ICollection<Order> Orders { get; set; }
        #endregion
    }
    #endregion
}
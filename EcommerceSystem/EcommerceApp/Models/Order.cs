#region Namespaces
using System;
using System.Collections.Generic;
#endregion

namespace EcommerceApp.Models
{
    #region Order Class
    public class Order
    {
        #region Properties
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public int CustomerId { get; set; }
        #endregion

        #region Navigation Properties
        public Customer Customer { get; set; }
        public ICollection<OrderDetail> OrderDetails { get; set; }
        #endregion
    }
    #endregion
}
#region Namespaces
using System;
#endregion

namespace EcommerceApp.Models
{
    #region OrderDetail Class
    public class OrderDetail
    {
        #region Properties
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        #endregion

        #region Navigation Properties
        public Order Order { get; set; }
        public Product Product { get; set; }
        #endregion
    }
    #endregion
}
#region Namespaces
using System;
using System.Collections.Generic;
#endregion

namespace EcommerceApp.Models
{
    #region Product Class
    public class Product
    {
        #region Properties
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
        #endregion

        #region Navigation Properties
        public Category Category { get; set; }
        public ICollection<OrderDetail> OrderDetails { get; set; }
        #endregion
    }
    #endregion
}
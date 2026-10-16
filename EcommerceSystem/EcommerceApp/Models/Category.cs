#region Namespaces
using System;
using System.Collections.Generic;
#endregion

namespace EcommerceApp.Models
{
    #region Category Class
    public class Category
    {
        #region Properties
        public int Id { get; set; }
        public string Name { get; set; }
        #endregion

        #region Navigation Properties
        public ICollection<Product> Products { get; set; }
        #endregion
    }
    #endregion
}
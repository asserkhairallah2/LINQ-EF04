#region Namespaces
using System;
using System.Collections.Generic;
#endregion

namespace LibraryApp.Models
{
    #region Author Class
    public class Author
    {
        #region Properties
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        #endregion

        #region Navigation Properties
        public ICollection<Book> Books { get; set; }
        #endregion
    }
    #endregion
}
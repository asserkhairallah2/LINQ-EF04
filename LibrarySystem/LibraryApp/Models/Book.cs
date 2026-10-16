#region Namespaces
using System;
using System.Collections.Generic;
#endregion

namespace LibraryApp.Models
{
    #region Book Class
    public class Book
    {
        #region Properties
        public int Id { get; set; }
        public string Title { get; set; }
        public string ISBN { get; set; }
        public int AuthorId { get; set; }
        #endregion

        #region Navigation Properties
        public Author Author { get; set; }
        public ICollection<Loan> Loans { get; set; }
        #endregion
    }
    #endregion
}
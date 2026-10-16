#region Namespaces
using System;
using System.Collections.Generic;
#endregion

namespace LibraryApp.Models
{
    #region Borrower Class
    public class Borrower
    {
        #region Properties
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime MembershipDate { get; set; }
        #endregion

        #region Navigation Properties
        public ICollection<Loan> Loans { get; set; }
        #endregion
    }
    #endregion
}
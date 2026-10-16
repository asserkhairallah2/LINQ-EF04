#region Namespaces
using System;
#endregion

namespace LibraryApp.Models
{
    #region Loan Class
    public class Loan
    {
        #region Properties
        public int BookId { get; set; }
        public int BorrowerId { get; set; }
        public DateTime LoanDate { get; set; }
        public DateTime ReturnDate { get; set; }
        #endregion

        #region Navigation Properties
        public Book Book { get; set; }
        public Borrower Borrower { get; set; }
        #endregion
    }
    #endregion
}
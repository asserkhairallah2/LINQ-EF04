#region Namespaces
using System;
using LibraryApp.DbContexts;
#endregion

namespace LibraryApp
{
    #region Program Class
    class Program
    {
        #region Main Method
        static void Main(string[] args)
        {
            #region Test Database Creation
            using var context = new LibraryDbContext();
            context.Database.EnsureCreated();
            Console.WriteLine("Library Database and Tables created successfully!");
            #endregion
        }
        #endregion
    }
    #endregion
}
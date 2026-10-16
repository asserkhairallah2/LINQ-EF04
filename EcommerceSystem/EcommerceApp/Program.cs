#region Namespaces
using System;
using EcommerceApp.DbContexts;
#endregion

namespace EcommerceApp
{
    #region Program Class
    class Program
    {
        #region Main Method
        static void Main(string[] args)
        {
            #region Test Database Connection and Creation
            using var context = new EcommerceDbContext();
            context.Database.EnsureCreated();
            Console.WriteLine("E-commerce Database and Tables created successfully!");
            #endregion
        }
        #endregion
    }
    #endregion
}
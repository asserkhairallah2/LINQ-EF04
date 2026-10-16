#region Namespaces
using System;
using HealthCareApp.DbContexts;
#endregion

namespace HealthCareApp
{
    #region Program Class
    class Program
    {
        #region Main Method
        static void Main(string[] args)
        {
            #region Test Database Creation
            using var context = new HealthCareDbContext();
            context.Database.EnsureCreated();
            Console.WriteLine("Health Care Database and Tables created successfully!");
            #endregion
        }
        #endregion
    }
    #endregion
}
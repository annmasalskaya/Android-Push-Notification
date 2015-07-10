using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using DAL.ApplicationDbContext;
using DAL.Entites;
using DAL.Repositories;
using DAL.UnitOfWork;

namespace DALTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Initializing DbContext...");
            DbContext context = new ApplicationDbContext();

            Console.WriteLine("Initializing UnitOfWork...");
            using (var unit = new UnitOfWork(context))
            {
                Console.WriteLine("Initializing Repository...");
                var repository = new UserRepository(context);

                Console.WriteLine("Creating User...");
                var user = new User{
                    Login = "FirstTestUser",
                    Password = "12345678"
                };

                Console.WriteLine("User created: {0}", user);

                Console.WriteLine("Saving user to repository...");
                var responce = repository.Create(user);
                Console.WriteLine("Repository responce: {0}", responce);
                
                Console.WriteLine("Commiting changes...");
                int unitResponce = unit.Commit();
                Console.WriteLine("Number of saved rows: {0}", unitResponce);
            }
            Console.WriteLine("Done");
            Console.WriteLine("Press Enter to exit");
            Console.ReadLine();
        }
    }
}

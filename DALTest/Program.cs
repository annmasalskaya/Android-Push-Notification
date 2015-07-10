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

                Console.WriteLine("Enter user login to create a user:");
                var login = Console.ReadLine();
                Console.WriteLine("Creating User...");
                var user = new User
                {
                    Login = login,
                    Password = "12345678"
                };

                Console.WriteLine("User created: {0}", user);

                Console.WriteLine("Saving user to repository...");
                repository.Create(user);
                
                Console.WriteLine("Commiting changes...");
                int unitResponce = unit.Commit();
                Console.WriteLine("Number of saved rows: {0}", unitResponce);
                Console.WriteLine("Done");

                Console.WriteLine("All users: ");
                var query = repository.GetAll();
                foreach (var e in query)
                {
                    Console.WriteLine(e);
                }

                Console.WriteLine("Enter user login to find user:");
                login = Console.ReadLine();

                query = repository.GetBy(u => u.Login ==  login);
                foreach (var e in query)
                {
                    Console.WriteLine("Repository responce: {0}", e);
                }

                
            }
           
        }
    }
}

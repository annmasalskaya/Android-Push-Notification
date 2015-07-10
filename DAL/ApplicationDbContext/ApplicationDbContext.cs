using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using DAL.Entites;

namespace DAL.ApplicationDbContext
{
    public class ApplicationDbContext : DbContext
    {
        DbSet<User> users { get; set; }
        DbSet<Device> devices { get; set; }
    }
}

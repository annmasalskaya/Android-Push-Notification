using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

public class DbContext : System.Data.Entity.DbContext
{
   
  

    public System.Data.Entity.DbSet<Android_Push_Notifications.Models.User> Users { get; set; }

    public System.Data.Entity.DbSet<Android_Push_Notifications.Models.Device> Devices { get; set; }

}

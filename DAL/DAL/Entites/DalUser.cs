using DAL.Interfaces.Entites;
using System.Collections.Generic;

namespace DAL.Entites
{
    public class DalUser : BaseEntity
    {
        public string Login { get; set; }

        public string Password { get; set; }

        public virtual ICollection<DalDevice> Devices { get; set; }
    }
}

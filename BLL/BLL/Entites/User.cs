using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Entites
{
    public class User
    {
        public string Login { get; set; }
        
        public virtual ICollection<Device> Devices { get; set; }
    }
}

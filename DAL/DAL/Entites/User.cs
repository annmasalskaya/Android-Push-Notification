using DAL.Interfaces.Entites;

namespace DAL.Entites
{
    public class User : BaseEntity
    {
        public string Login { get; set; }

        public string Password { get; set; }
    }
}

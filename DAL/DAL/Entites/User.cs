using DAL.Interfaces.Entites;

namespace DAL.Entites
{
    public class User : BaseEntity
    {
        public string Login { get; set; }

        public string Password { get; set; }

        public override string ToString()
        {
            return string.Format("Login: {0}, Password: {1}", Login, Password);
        }
    }
}

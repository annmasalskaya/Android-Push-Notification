using DAL.Interfaces.Entites;

namespace DAL.Entites
{
    public class DalDevice : BaseEntity
    {
        public DalUser User { get; set; }

        public string RegistrationId { get; set; }
        
        public string Imei { get; set; }
    }
}

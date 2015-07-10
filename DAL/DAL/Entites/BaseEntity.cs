using DAL.Interfaces.Entites;


namespace DAL.Entites
{
    public abstract class BaseEntity: IEntity
    {
        public int Id { get; set; }
    }
}

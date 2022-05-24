namespace SCSE.HcecliTest.Domain.Interfaces
{
    public interface IEntity<TId> : IEntity
    {
        public TId Id { get; set; }
    }

    public interface IEntity
    {
    }
}

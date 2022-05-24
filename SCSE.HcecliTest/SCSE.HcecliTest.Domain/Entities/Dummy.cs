namespace SCSE.HcecliTest.Domain.Entities
{
    public class Dummy
    {
        public int Id { get; set; }
        public string? Description { get; set; }
        public DateTime Creation { get; set; } = DateTime.Now;
    }
}

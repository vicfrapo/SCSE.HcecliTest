using Microsoft.EntityFrameworkCore;

namespace SCSE.HcecliTest.ORM
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> dbContextOptions)
            : base(dbContextOptions)
        {

        }

        //public DbSet<Dummy> GenericItem { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.ApplyConfiguration(new DummyMapping());
        }


        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            return base.SaveChangesAsync(cancellationToken);
        }
    }
}

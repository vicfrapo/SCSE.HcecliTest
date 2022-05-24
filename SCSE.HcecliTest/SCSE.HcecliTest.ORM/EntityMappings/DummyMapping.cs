using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SCSE.HcecliTest.ORM.EntityMappings
{
    //public class DummyMapping : IEntityTypeConfiguration<Dummy>
    //{
    //    public void Configure(EntityTypeBuilder<Dummy> builder)
    //    {
    //        builder.ToTable("DUMMY");

    //        builder.Property(p => p.Id)
    //            .HasColumnName("ID")
    //            .IsRequired();

    //        builder.Property(p => p.Description)
    //           .HasColumnName("DESCRIPTION")
    //           .IsRequired();

    //        builder.Property(p => p.Creation)
    //          .HasColumnName("CREATION")
    //          .IsRequired();

    //        builder.HasKey(p => new { p.Id });
    //        builder.Property(e => e.Id).ValueGeneratedNever();
    //    }
    //}
}

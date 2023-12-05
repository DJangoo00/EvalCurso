using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration;

public class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.HasKey(e => e.Id).HasName("PK__user__3213E83FA57CA06D");

        builder.ToTable("user");

        builder.HasIndex(e => e.Id, "index_1");

        builder.Property(e => e.Id)
            .HasColumnName("id");

        builder.Property(e => e.Correo)
            .IsRequired()
            .HasMaxLength(100)
            .HasColumnName("correo");

        builder.Property(e => e.Nombre)
            .IsRequired()
            .HasMaxLength(100)
            .HasColumnName("nombre");

        builder.Property(e => e.Password)
            .IsRequired()
            .HasMaxLength(255)
            .HasColumnName("password");

        builder
        .HasMany(d => d.Roles)
        .WithMany(p => p.Users)
        .UsingEntity<UserRole>(
                
                r => r.HasOne<Role>()
                    .WithMany()
                    .HasForeignKey("idRoleFk")
                    .HasConstraintName("FK__userrol__idRolFk__3E52440B"),

                l => l.HasOne<User>()
                    .WithMany()
                    .HasForeignKey("idUserFk")
                    .HasConstraintName("FK__userrol__idUserF__3F466844"),

                j =>
                {
                    j.HasKey("idUserFk", "idRoleFk")
                        .HasName("PK__userrol__48BE068FEF27E1B7");
                    j.ToTable("userrole");
                    //j.HasIndex(new[] { "IdUserFk", "IdRolFk" }, "index_3");
                    //j.IndexerProperty<int>("IdUserFk")
                    //    .HasColumnName("idUserFk");
                    //j.IndexerProperty<int>("IdRolFk")
                    //    .HasColumnName("idRolFk");
                });
    }
}
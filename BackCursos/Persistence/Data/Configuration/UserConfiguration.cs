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

        builder.Property(e => e.Nombre)
            .IsRequired()
            .HasMaxLength(100)
            .HasColumnName("nombre");

        builder.Property(e => e.Correo)
            .IsRequired()
            .HasMaxLength(100)
            .HasColumnName("correo");

        builder.Property(e => e.Password)
            .IsRequired()
            .HasMaxLength(255)
            .HasColumnName("password");

         builder
        .HasMany(p => p.Roles)
        .WithMany(r => r.Users)
        .UsingEntity<UserRole>(

            j => j
            .HasOne(pt => pt.Role)
            .WithMany(t => t.UsersRoles)
            .HasForeignKey(ut => ut.IdRoleFk),


            j => j
            .HasOne(et => et.User)
            .WithMany(et => et.UsersRoles)
            .HasForeignKey(el => el.IdUserFk),

            j =>
            {
                j.ToTable("UserRole");
                j.HasKey(t => new { t.IdUserFk, t.IdRoleFk });

            });

            builder.HasMany(p => p.RefreshTokens)
            .WithOne(p => p.User)
            .HasForeignKey(p => p.IdUserFk);

    
        }
    }

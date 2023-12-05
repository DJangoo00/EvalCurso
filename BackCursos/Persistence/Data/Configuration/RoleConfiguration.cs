using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration;

public class RoleConfiguration : IEntityTypeConfiguration<Role>
{
    public void Configure(EntityTypeBuilder<Role> builder)
    {
        // Aquí puedes configurar las propiedades de la entidad Marca
        // utilizando el objeto 'builder'.
        builder.ToTable("role");
        
        builder.Property(p => p.Id)
        .HasColumnName("id")
        .IsRequired();
        
        builder.Property(p => p.RoleName)
        .HasColumnName("roleName")
        .HasColumnType("varchar")
        .HasMaxLength(50)
        .IsRequired();

    }
}
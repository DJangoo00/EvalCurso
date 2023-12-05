using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration
{
    public class CursoConfiguration : IEntityTypeConfiguration<Curso>
    {
        public void Configure(EntityTypeBuilder<Curso> builder)
        {
            // Aquí puedes configurar las propiedades de la entidad Marca
            // utilizando el objeto 'builder'.
            builder.HasKey(e => e.Id).HasName("PK__curso__3213E83F117E3898");

            builder.ToTable("curso");

            builder.HasIndex(e => new { e.Id, e.Nombre }, "index_4");

            builder.Property(e => e.Id)
                .HasColumnName("id");

            builder.Property(e => e.IdInstructorFk)
                .HasColumnName("idInstructorFk");

            builder.Property(e => e.Nombre)
                .IsRequired()
                .HasMaxLength(100)
                .HasColumnName("nombre");

            builder.Property(e => e.img)
                .IsRequired()
                .HasMaxLength(100)
                .HasColumnName("img");

            builder.Property(e => e.descripcion)
                .IsRequired()
                .HasMaxLength(200)
                .HasColumnName("descripcion");

            builder.HasOne(d => d.IdInstructorFkNavigation).WithMany(p => p.Cursos)
                .HasForeignKey(d => d.IdInstructorFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__curso__idInstruc__4222D4EF");
        }
    }
}
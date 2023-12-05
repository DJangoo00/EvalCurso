using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration
{
    public class UserCursoConfiguration : IEntityTypeConfiguration<UserCurso>
    {
        public void Configure(EntityTypeBuilder<UserCurso> builder)
        {
            // Aquí puedes configurar las propiedades de la entidad Marca
            // utilizando el objeto 'builder'.
            builder.HasKey(e => new { e.Id, e.IdCursoFk })
                .HasName("PK__usercurs__0C6128E894DD7FFB");

            builder.ToTable("usercurso");

            builder.HasIndex(e => new { e.Id, e.IdCursoFk, e.IdEstadoFk, e.Calificacion }, "index_6");

            builder.Property(e => e.Id)
                .HasColumnName("idUserFk");

            builder.Property(e => e.IdCursoFk)
                .HasColumnName("idCursoFk");

            builder.Property(e => e.Calificacion)
                .HasColumnName("calificacion");

            builder.Property(e => e.Comentario)
                .HasMaxLength(200)
                .HasColumnName("comentario");

            builder.Property(e => e.IdEstadoFk)
                .HasColumnName("idEstadoFk");

            builder.HasOne(d => d.IdCursoFkNavigation).WithMany(p => p.Usercursos)
                .HasForeignKey(d => d.IdCursoFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__usercurso__idCur__47DBAE45");

            builder.HasOne(d => d.IdEstadoFkNavigation).WithMany(p => p.Usercursos)
                .HasForeignKey(d => d.IdEstadoFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__usercurso__idEst__48CFD27E");

            builder.HasOne(d => d.IdUserFkNavigation).WithMany(p => p.Usercursos)
                .HasForeignKey(d => d.Id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__usercurso__idUse__46E78A0C");
        }
    }
}
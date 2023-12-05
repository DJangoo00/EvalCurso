using Domain.Entities;

namespace API.Dtos;
public class CursoDto : BaseEntity
{
    public string Nombre { get; set; }
    public string img { get; set; }
    public string descripcion { get; set; }
    public int IdInstructorFk { get; set; }
    public virtual User IdInstructorFkNavigation { get; set; }
}
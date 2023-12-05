using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class Curso : BaseEntity
{
    public string Nombre { get; set; }
    public string img { get; set; }
    public string descripcion { get; set; }
    public int IdInstructorFk { get; set; }
    public virtual User IdInstructorFkNavigation { get; set; }
    public virtual ICollection<UserCurso> Usercursos { get; set; } = new List<UserCurso>();
}

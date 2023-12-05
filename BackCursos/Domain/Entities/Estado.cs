using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class Estado : BaseEntity
{
    public string Nombre { get; set; }
    public virtual ICollection<UserCurso> Usercursos { get; set; } = new List<UserCurso>();
}

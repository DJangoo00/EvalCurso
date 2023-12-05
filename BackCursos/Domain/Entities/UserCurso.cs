using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class UserCurso : BaseEntity
{
    //se remplaza el id de usuario de la entidad por el heredado, para mantener el patron
    //public int IdUserFk { get; set; }

    public int IdCursoFk { get; set; }

    public int IdEstadoFk { get; set; }

    public int? Calificacion { get; set; }

    public string Comentario { get; set; }

    public virtual Curso IdCursoFkNavigation { get; set; }

    public virtual Estado IdEstadoFkNavigation { get; set; }

    public virtual User IdUserFkNavigation { get; set; }
}

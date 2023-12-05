using Domain.Entities;

namespace Domain.Interfaces;

public interface IUnitOfWork
{
    ICursoRepository Cursos { get; }
    IEstadoRepository Estados { get; }
    IUserCursoRepository UsersCursos { get; }
    //JWT
    IUserRepository Users { get; }
    IRoleRepository Roles { get; }

    Task<int> SaveAsync();
}

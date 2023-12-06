using App.Repository;
using Domain.Entities;
using Domain.Interfaces;
using Persistence;

namespace App.UnitOfWork;
public class UnitOfWork : IUnitOfWork, IDisposable
{
    private readonly ApiContext _context;
    
    //main
    private CursoRepository _cursos;
    private EstadoRepository _estados;
    private UserCursoRepository _userscursos;
    //JWT
    private RoleRepository _roles;
    private UserRepository _users;
    public UnitOfWork(ApiContext context)
    {
        _context = context;
    }

    //main
    public ICursoRepository Cursos
    {
        get
        {
            if (_cursos == null)
            {
                _cursos = new CursoRepository(_context);
            }
            return _cursos;
        }
    }

    public IEstadoRepository Estados
    {
        get
        {
            if (_estados == null)
            {
                _estados = new EstadoRepository(_context);
            }
            return _estados;
        }
    }

    public IUserCursoRepository UsersCursos
    {
        get
        {
            if (_userscursos == null)
            {
                _userscursos = new UserCursoRepository(_context);
            }
            return _userscursos;
        }
    }

    //jwt
    public IRoleRepository Roles
    {
        get
        {
            if (_roles == null)
            {
                _roles = new RoleRepository(_context);
            }
            return _roles;
        }
    }

    public IUserRepository Users
    {
        get
        {
            if (_users == null)
            {
                _users = new UserRepository(_context);
            }
            return _users;
        }
    }

    public void Dispose()
   {
       _context.Dispose();
   }
   public async Task<int> SaveAsync()
   {
       return await _context.SaveChangesAsync();
   } 
}
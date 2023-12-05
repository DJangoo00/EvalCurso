using Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption;
using Microsoft.EntityFrameworkCore;
using Domain.Entities;
using Domain.Interfaces;
using Persistence;

namespace App.Repository;

public class UserCursoRepository : GenericRepository<UserCurso>, IUserCursoRepository
{
    private readonly ApiContext _context;
    public UserCursoRepository(ApiContext context) : base(context)
    {
        _context = context;
    }

    public override async Task<IEnumerable<UserCurso>> GetAllAsync()
    {
        return await _context.UsersCursos
            .ToListAsync();
    }

    public override async Task<UserCurso> GetByIdAsync(int id)
    {
        return await _context.UsersCursos
            .FirstOrDefaultAsync(p =>  p.Id == id);
    }
}
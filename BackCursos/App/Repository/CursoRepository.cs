using Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption;
using Microsoft.EntityFrameworkCore;
using Domain.Entities;
using Domain.Interfaces;
using Persistence;

namespace App.Repository;

public class CursoRepository : GenericRepository<Curso>, ICursoRepository
{
    private readonly ApiContext _context;
    public CursoRepository(ApiContext context) : base(context)
    {
        _context = context;
    }

    public override async Task<IEnumerable<Curso>> GetAllAsync()
    {
        return await _context.Cursos
            .ToListAsync();
    }

    public override async Task<Curso> GetByIdAsync(int id)
    {
        return await _context.Cursos
            .FirstOrDefaultAsync(p =>  p.Id == id);
    }
}
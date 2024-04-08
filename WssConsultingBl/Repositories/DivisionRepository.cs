using WssСonsultingBl.DataContexts;
using WssСonsultingBl.Models;
using WssСonsultingBl.Repositories.Interfaces;

namespace WssСonsultingBl.Repositories;

public class DivisionRepository : IRepository<Division>
{
    
    private readonly ApplicationContext _context;

    public DivisionRepository(ApplicationContext context)
    {
        _context = context??throw new ArgumentNullException(nameof(context));
    }
    
    public Task<IEnumerable<Company>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Division> GetByIdAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task AddAsync(Division t)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(Division t)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<bool> IsExistsAsync(Guid id)
    {
        throw new NotImplementedException();
    }
}
using WssСonsultingBl.DataContexts;
using WssСonsultingBl.Models;
using WssСonsultingBl.Repositories.Interfaces;

namespace WssСonsultingBl.Repositories;

public class CompanyRepository : IRepository<Company>, IComponentChildMoving<Department>
{
    private readonly ApplicationContext _context;

    public CompanyRepository(ApplicationContext context)
    {
        _context = context??throw new ArgumentNullException(nameof(context));
    }
    
    
    public Task<IEnumerable<Company>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Company> GetByIdAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task AddAsync(Company t)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(Company t)
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
    
    public Task<IEnumerable<Department>?> GetAllChildrenAsync(Guid idParent)
    {
        throw new NotImplementedException();
    }
 
    public void AddChild(Department department)
    {
        throw new NotImplementedException();
    }

    public Task RemoveChildAsync(Guid childId)
    {
        throw new NotImplementedException();
    }

    public Task MoveChildAsync(Guid childId, Guid newParentId)
    {
        throw new NotImplementedException();
    }
}
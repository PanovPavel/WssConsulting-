using WssСonsultingBl.Model;

namespace WssСonsultingBl.Repository;


public class CompanyRepository : IRepository<Company>, IComponentChild<Department>
{
    private readonly ApplicationContext _context;

    public CompanyRepository(ApplicationContext context)
    {
        _context = context;
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
    
    public IEnumerable<Department> GetAllChildren()
    {
        throw new NotImplementedException();
    }
 
    public void AddChild(Department department)
    {
        throw new NotImplementedException();
    }

    public void RemoveChild(Guid childId)
    {
        throw new NotImplementedException();
    }

    public void MoveChild(Guid childId, Guid newParentId)
    {
        throw new NotImplementedException();
    }
}
using WssСonsultingBl.Repositories.Interfaces;
using WssСonsultingBl.Repository;

namespace WssСonsultingBl.Model;

public class DepartmentRepository : IRepository<Department>, IComponentChildMoving<Division>
{
    private readonly ApplicationContext _context;

    public DepartmentRepository(ApplicationContext context)
    {
        _context = context??throw new ArgumentNullException(nameof(context));
    }

    public Task<IEnumerable<Company>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Department> GetByIdAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task AddAsync(Department t)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(Department t)
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



    public void AddChild(Division division)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Division>?> GetAllChildrenAsync(Guid idParent)
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
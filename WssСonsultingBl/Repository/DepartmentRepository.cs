using WssСonsultingBl.Repository;

namespace WssСonsultingBl.Model;

public class DepartmentRepository : IRepository<Department>, IComponentChild<Division>
{
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

    public IEnumerable<Division> GetAllChildren()
    {
        throw new NotImplementedException();
    }

    public void AddChild(Division division)
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
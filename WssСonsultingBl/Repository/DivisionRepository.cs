using WssСonsultingBl.Model;

namespace WssСonsultingBl.Repository;

public class DivisionRepository : IRepository<Division>
{
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
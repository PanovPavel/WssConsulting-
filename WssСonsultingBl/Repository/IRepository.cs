using WssСonsultingBl.Model;

namespace WssСonsultingBl.Repository;

public interface IRepository <T>
{
    Task<IEnumerable<Company>> GetAllAsync();
    Task<T> GetByIdAsync(Guid id);
    Task AddAsync(T t);
    Task UpdateAsync(T t);
    Task DeleteAsync(Guid id);
    Task<bool> IsExistsAsync(Guid id);
}
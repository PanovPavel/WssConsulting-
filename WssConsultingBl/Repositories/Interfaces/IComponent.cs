using WssСonsultingBl.Model;

namespace WssСonsultingBl.Repository;

public interface IComponent<T>
{
    /// <summary>
    /// await _context.DBSet<T>.AddAsync(department);
    /// _context.SaveChange();
    /// </summary>
    Task<IEnumerable<T>?> GetAllChildrenAsync(Guid idParent);
    /// <summary>
    /// Проверка существует ли childId
    /// _context.DBSet<T>.Remove(department);
    /// _context.SaveChange();
    /// </summary>
    Task RemoveChildAsync(Guid childId);
}
using WssСonsultingBl.Model;

namespace WssСonsultingBl.Repositories.Interfaces;

public interface IRepository<T>
{
    /// <summary>
    /// Получение из _context.DBSet<T> списка объектов
    /// </summary>
    /// <returns></returns>
    Task<IEnumerable<Company>> GetAllAsync();

    /// <summary>
    /// Получение из _context.DBSet<T>.FindAsync(id) объекта
    /// </summary>
    /// <param name="id">id объекта</param>
    /// <returns></returns>
    Task<T> GetByIdAsync(Guid id);

    /// <summary>
    /// Добавление _context.DBSet<T>.AddAsync(t);
    /// _context.SaveChangesAsync();
    /// </summary>
    /// <param name="t"></param>
    /// <returns></returns>
    Task AddAsync(T t);

    /// <summary>
    /// _context.Entry(t).State = EntityState.Modified;
    /// await _context.SaveChangesAsync();
    /// </summary>
    Task UpdateAsync(T t);

    /// <summary>
    /// Проверка на существования IsExistsAsync. throw new ArgumentException("Элемент с указаннным id не найден")
    /// _context.DBSet<T>.FindAsync(id)
    /// _context.ВBSet<T>.Remove(employee);
    /// _context.SaveChangesAsync();
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    Task DeleteAsync(Guid id);
    
    /// <summary>
    /// return await _context.Companies.AnyAsync(e => e.Id == id);
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    Task<bool> IsExistsAsync(Guid id);
}
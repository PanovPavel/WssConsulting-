namespace WssСonsultingBl.Repositories.Interfaces;

public interface IComponentChildMoving<T> : IComponent<T>
{
    /// <summary>
    /// Проверка существуют ли id
    /// Если id существуют то получение из DBSet<child> компонента
    /// Изменение ему id родителя
    /// _context.Update(child);
    /// _context.SaveChanges();
    /// </summary>
    Task MoveChildAsync(Guid childId, Guid newParentId);
}
using Microsoft.AspNetCore.Mvc;

namespace WssConsultingApi.Controllers;

public interface IComponentChildMoving<T> : IComponentController<T>
{
    /// <summary>
    /// _repository.MoveChildAsync(childId, newParentId);
    /// return NoContent();
    /// return Если ошибка StatusCode(500, ErrorMessage)
    /// </summary>
    Task<ActionResult<T>> MoveChildAsync(Guid childId, Guid newParentId);
}
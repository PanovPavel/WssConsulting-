using Microsoft.AspNetCore.Mvc;

namespace WssConsultingApi.Controllers.Interfaces;

public interface IComponentChildMovingApi<T> : IComponentControllerApi<T>
{
    /// <summary>
    /// _repository.MoveChildAsync(childId, newParentId);
    /// return NoContent();
    /// return Если ошибка StatusCode(500, ErrorMessage)
    /// </summary>
    Task<ActionResult<T>> MoveChildAsync(Guid childId, Guid newParentId);
}
using Microsoft.AspNetCore.Mvc;

namespace WssConsultingApi.Controllers;

public interface IComponentController<T>
{
    /// <summary>
    /// Проверка существует ли элемнт if (find == null){return NotFound();}
    /// Если id существует await _companyRepository.GetAllChildrenAsync(idParent);
    /// return Если ошибка StatusCode(500, ErrorMessage)
    /// </summary>
    /// <param name="idParent"></param>
    /// <returns></returns>
    Task<ActionResult<IEnumerable<T>>> GetAllChildren(Guid idParent);
    /// <summary>
    /// Проверка на существование id.
    /// _repository.RemoveChildAsync(childId);
    /// return Если ошибка StatusCode(500, ErrorMessage)
    /// </summary>
    /// <param name="idParent"></param>
    /// <param name="childId"></param>
    /// <returns></returns>
    Task<IActionResult> RemoveChild(Guid idParent, Guid childId);
}
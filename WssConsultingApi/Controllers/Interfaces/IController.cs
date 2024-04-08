using Microsoft.AspNetCore.Mvc;

namespace WssConsultingApi.Controllers;

public interface IController<T>
{
    /// <summary>
    /// Получение из репозитория _repository.GetAllAsync() списка объектов
    /// И возврат return Ok(List<T>)
    /// return Если ошибка StatusCode(500, ErrorMessage)
    /// </summary>
    /// <returns></returns>
    Task<ActionResult<IEnumerable<T>>> GetAll();

    /// <summary>
    /// Проверка на существования repository.IsExist(id) {return BadRequest(ModelState);}
    /// Получение из репозитория _repository.GetAsync() объекта
    /// return Ok(T)
    /// return Если ошибка StatusCode(500, ErrorMessage)
    /// </summary>
    Task<ActionResult<T>> GetById(Guid id);

    /// <summary>
    /// Возврат      if (!ModelState.IsValid){return BadRequest(ModelState);}
    /// Если валидация пройдена то добавление в репозиторий _repository.Add(T)
    /// return Если ошибка StatusCode(500, ErrorMessage)
    /// </summary>
    /// <param name="createT"></param>
    /// <returns></returns>
    ActionResult<T> Create(T createT);

    /// <summary>
    /// Возврат если не пройдена валидация if (!ModelState.IsValid){return BadRequest(ModelState);}
    /// if (id != updatedT.Id) {return BadRequest();}
    /// _repository.Update(T);
    /// return NoContent();
    /// Если ошибка StatusCode(500, ErrorMessage)
    /// </summary>
    /// <param name="createT"></param>
    /// <returns></returns>
    Task<IActionResult> Update(Guid id, T updateT);

    /// <summary>
    /// Проверка существует ли элемнт if (find == null){return NotFound();}
    /// _repository.Delete(id);
    /// return NoContent();
    /// return Если ошибка StatusCode(500, ErrorMessage)
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    Task<IActionResult> Delete(Guid id);
}
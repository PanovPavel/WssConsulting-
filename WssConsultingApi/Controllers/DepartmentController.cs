using Microsoft.AspNetCore.Mvc;
using WssСonsultingBl.Model;
using WssСonsultingBl.Repositories.Interfaces;

namespace WssConsultingApi.Controllers;

[ApiController]
[Route("api/company")]
public class DepartmentController : IController<Department>, IComponentChildMoving<Division>
{
    private readonly IRepository<Department> _departmentRepository;

    public DepartmentController(IRepository<Department> departmentRepository)
    {
        _departmentRepository = departmentRepository??throw new ArgumentNullException(nameof(departmentRepository));
    }
    
    [HttpGet]
    public Task<ActionResult<IEnumerable<Department>>> GetAll()
    {
        throw new NotImplementedException();
    }

    [HttpGet("{id:guid}")]
    public Task<ActionResult<Department>> GetById(Guid id)
    {
        throw new NotImplementedException();
    }

    [HttpPost]
    public ActionResult<Department> Create(Department createT)
    {
        throw new NotImplementedException();
    }

    [HttpPut("{id:guid}")]
    public Task<IActionResult> Update(Guid id, Department updateT)
    {
        throw new NotImplementedException();
    }

    [HttpDelete("{id:guid}")]
    public Task<IActionResult> Delete(Guid id)
    {
        throw new NotImplementedException();
    }

    [HttpGet("children/{idParent:guid}")]
    public Task<ActionResult<IEnumerable<Division>>> GetAllChildren(Guid idParent)
    {
        throw new NotImplementedException();
    }

    [HttpDelete("removeChild/{idParent:guid}/{childId:guid}")]
    public Task<IActionResult> RemoveChild(Guid idParent, Guid childId)
    {
        throw new NotImplementedException();
    }
    
    [HttpPut("moveChild/{childId:guid}/{newParentId:guid}")]
    public Task<ActionResult<Division>> MoveChildAsync(Guid childId, Guid newParentId)
    {
        throw new NotImplementedException();
    }
}
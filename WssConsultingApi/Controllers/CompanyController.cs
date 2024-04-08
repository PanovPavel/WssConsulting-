using Microsoft.AspNetCore.Mvc;
using WssСonsultingBl.Model;
using WssСonsultingBl.Repositories.Interfaces;
using WssСonsultingBl.Repository;

namespace WssConsultingApi.Controllers;

[ApiController]
[Route("api/company")]
public class CompanyController : IController<Company>, IComponentChildMoving<Division>
{
    private readonly IRepository<Company> _companyRepository;

    public CompanyController(IRepository<Company> companyRepository)
    {
        _companyRepository = companyRepository??throw new ArgumentNullException(nameof(companyRepository));
    }

    [HttpGet]
    public Task<ActionResult<IEnumerable<Company>>>GetAll()
    {
        throw new NotImplementedException();
    }

    [HttpGet("{id:guid}")]
    public Task<ActionResult<Company>> GetById(Guid id)
    {
        throw new NotImplementedException();
    }

    [HttpPost]
    public ActionResult<Company> Create(Company createT)
    {
        throw new NotImplementedException();
    }

    [HttpPut("{id:guid}")]
    public Task<IActionResult> Update(Guid id, Company updateT)
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
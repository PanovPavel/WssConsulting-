using Microsoft.AspNetCore.Mvc;
using WssСonsultingBl.Model;
using WssСonsultingBl.Repositories.Interfaces;

namespace WssConsultingApi.Controllers;

[ApiController]
[Route("api/division")]
public class DivisionController : IController<Division>
{
    private readonly IRepository<Division> _divisionRepository;
    
    public DivisionController(IRepository<Division> divisionRepository)
    {
        _divisionRepository = divisionRepository??throw new ArgumentException("division");
    }
    
    [HttpGet]
    public Task<ActionResult<IEnumerable<Division>>> GetAll()
    {
        throw new NotImplementedException();
    }

    [HttpGet("{id:guid}")]
    public Task<ActionResult<Division>> GetById(Guid id)
    {
        throw new NotImplementedException();
    }
    
    [HttpPost]
    public ActionResult<Division> Create(Division createT)
    {
        throw new NotImplementedException();
    }
    [HttpPut("{id:guid}")]
    public Task<IActionResult> Update(Guid id, Division updateT)
    {
        throw new NotImplementedException();
    }

    [HttpDelete("{id:guid}")]
    public Task<IActionResult> Delete(Guid id)
    {
        throw new NotImplementedException();
    }
}
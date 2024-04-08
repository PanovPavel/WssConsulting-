using WssСonsultingBl.Model;

namespace WssConsultingClient.Controller;

public class DepartmentController : IControllerClient<Department>
{
    private readonly IHttpClientFactory _clientFactory;

    public DepartmentController(IHttpClientFactory clientFactory)
    {
        _clientFactory = clientFactory ?? throw new ArgumentNullException(nameof(clientFactory));
    }
    
    public Task<IEnumerable<Department>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Department> GetByIdAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task AddAsync(Department t)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(Guid id, Department t)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(Guid id)
    {
        throw new NotImplementedException();
    }
}
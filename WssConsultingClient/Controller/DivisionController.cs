using WssСonsultingBl.Model;

namespace WssConsultingClient.Controller;

public class DivisionController : IControllerClient<Division>
{
    private readonly IHttpClientFactory _clientFactory;

    public DivisionController(IHttpClientFactory clientFactory)
    {
        _clientFactory = clientFactory ?? throw new ArgumentNullException(nameof(clientFactory));
    }
    public Task<IEnumerable<Division>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Division> GetByIdAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task AddAsync(Division t)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(Guid id, Division t)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(Guid id)
    {
        throw new NotImplementedException();
    }
}
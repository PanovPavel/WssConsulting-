using WssСonsultingBl.Model;

namespace WssConsultingClient.Controller;

public class CompanyController : IControllerClient<Company>
{
    private readonly IHttpClientFactory _clientFactory;

    public CompanyController(IHttpClientFactory clientFactory)
    {
        _clientFactory = clientFactory ?? throw new ArgumentNullException(nameof(clientFactory));
    }
    
    public async Task<IEnumerable<Company>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public async Task<Company> GetByIdAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public async Task AddAsync(Company company)
    {
        throw new NotImplementedException();
    }

    public async Task UpdateAsync(Guid id, Company company)
    {
        throw new NotImplementedException();
    }

    public async Task DeleteAsync(Guid id)
    {
        throw new NotImplementedException();
    }
}
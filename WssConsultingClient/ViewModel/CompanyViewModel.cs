using System.Collections.ObjectModel;
using WssConsultingClient.Controller;
using WssСonsultingBl.Model;

namespace WssConsultingClient.ViewModel;

public class CompanyViewModel
{
    private readonly IHttpClientFactory _httpClientFactory;

    public CompanyViewModel(IHttpClientFactory httpClientFactory)
    {
        _httpClientFactory = httpClientFactory ?? throw new ArgumentNullException(nameof(httpClientFactory));
        LoadCompanyAsync();
    }
    
    private ObservableCollection<Company> _companies = new ObservableCollection<Company>();
    public ObservableCollection<Company> Companies { get; set; }


    private async void LoadCompanyAsync()
    {
        var httpClient = _httpClientFactory.CreateClient();
        var response = await httpClient.GetAsync("api/company");
        response.EnsureSuccessStatusCode();
        var companies = await response.Content.ReadFromJsonAsync<IEnumerable<Company>>();
        if (companies != null)
            foreach (var company in companies.OrderBy(c => c.DateTimeCreated))
            {
                Companies.Add(company);
            }
        
    }
    
}
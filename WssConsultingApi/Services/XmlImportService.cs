using System.Xml.Serialization;
using Microsoft.AspNetCore.Mvc;
using WssСonsultingBl;
using WssСonsultingBl.Model;
using WssСonsultingBl.Services;

namespace WssConsultingApi.Services;

public class XmlImportService : IXmlImport
{
    private readonly ApplicationContext _applicationContext;

    public XmlImportService(ApplicationContext applicationContext)
    {
        _applicationContext = applicationContext;
    }
    
    public async Task<IActionResult> ImportDataFromXml(IFormFile? file)
    {
        if (file == null || file.Length == 0)
        {
            return new BadRequestObjectResult("File is empty");
        }
        using (var memoryStream = new MemoryStream())
        {
            await file.CopyToAsync(memoryStream);
            memoryStream.Position = 0;
            var serializer = new XmlSerializer(typeof(List<Company>));
            if (serializer.Deserialize(memoryStream) is List<Company> importedCompanies)
            {
                foreach (var company in importedCompanies)
                {
                    var existingCompany = await _applicationContext.Companies.FindAsync(company.IdCompany);
                    if (existingCompany == null)
                    {
                        _applicationContext.Companies.Add(company);
                    }
                }
                await _applicationContext.SaveChangesAsync();
                return new OkObjectResult("Data imported successfully");
            };
            return new BadRequestObjectResult("Error format xml");
        }
    }
    
}
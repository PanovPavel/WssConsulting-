using Microsoft.AspNetCore.Mvc;
using WssСonsultingBl.Services;

namespace WssConsultingApi.Controllers;

[Controller]
[Route("api/xml")]
public class XmlImportController
{
    private readonly IXmlImport _xmlImportService;

    public XmlImportController(IXmlImport xmlImportService)
    {
        _xmlImportService = xmlImportService??throw new ArgumentNullException(nameof(xmlImportService));
    }

    [HttpPost("import")]
    public Task<IActionResult> ImportDataFromXml([FromForm] IFormFile file)
    {
        return _xmlImportService.ImportDataFromXml(file);
    }
}
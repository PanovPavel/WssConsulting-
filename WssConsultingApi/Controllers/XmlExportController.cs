using Microsoft.AspNetCore.Mvc;
using WssConsultingApi.Services;

namespace WssConsultingApi.Controllers;

[Controller]
[Route("api/xml")]
public class XmlExportController
{
    private readonly IXmlExport _xmlExportService;

    public XmlExportController(IXmlExport xmlExportService)
    {
        _xmlExportService = xmlExportService??throw new ArgumentNullException(nameof(xmlExportService));
    }

    [HttpGet("export")]
    public async Task<IActionResult> ExportAllDataToXml(string filename = "handbook.xml")
    {
        try
        {
            var result = await _xmlExportService.ExportAllDataToXmlAsync(filename);
            return result;
        }
        catch
        {
            return new BadRequestResult();
        }
    }
}
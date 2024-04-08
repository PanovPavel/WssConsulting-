using Microsoft.AspNetCore.Mvc;

namespace WssConsultingApi.Services;

public interface IXmlImport
{
    Task<IActionResult> ImportDataFromXml(IFormFile? file);
}
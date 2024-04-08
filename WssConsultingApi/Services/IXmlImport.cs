using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WssСonsultingBl.Services;

public interface IXmlImport
{
    Task<IActionResult> ImportDataFromXml(IFormFile? file);
}
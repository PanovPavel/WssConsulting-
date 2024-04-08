using Microsoft.AspNetCore.Mvc;

namespace WssConsultingApi.Services;

public interface IXmlExport
{
    Task<FileStreamResult> ExportAllDataToXmlAsync(string nameFile);
}
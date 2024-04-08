using System.Xml.Serialization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WssСonsultingBl;
using WssСonsultingBl.DataContexts;
using WssСonsultingBl.Models;

namespace WssConsultingApi.Services;

public class XmlExportService : IXmlExport
{
    private readonly ApplicationContext _applicationContext;

    public XmlExportService(ApplicationContext applicationContext)
    {
        _applicationContext = applicationContext;
    }
    
    public async Task<FileStreamResult> ExportAllDataToXmlAsync(string filename = "handbook.xml")
    {
        var companies = await _applicationContext.Companies
            .Include(com => com.Departments)
            .ThenInclude(dep => dep)
            .Select(com => new {
                Company = com,
                Departments = com.Departments != null ? com.Departments.Select(dep => new {
                    Department = dep,
                    Division = dep.Divisions
                }).ToList() : null
            })
            .ToListAsync();
        
        using (var memoryStream = new MemoryStream())
        {
            var serializer = new XmlSerializer(typeof(List<Company>));
            serializer.Serialize(memoryStream, companies);
            memoryStream.Position = 0;
            return new FileStreamResult(memoryStream, "text/xml")
            {
                FileDownloadName = filename
            };
        }
    }
}
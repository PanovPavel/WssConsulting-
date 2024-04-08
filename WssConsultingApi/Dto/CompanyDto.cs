using System.ComponentModel.DataAnnotations;

namespace WssConsultingApi.Dto;

public class CompanyDto
{
    [Key] 
    public Guid IdCompany { get; init; }

    [Required(ErrorMessage = "NameCompany must be filled")]
    [MaxLength(100, ErrorMessage = "NameCompany cannot more than 100 characters")]
    public string NameCompany { get; set; }

    public DateTime DateTimeCreated { get; }
}
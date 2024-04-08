using System.ComponentModel.DataAnnotations;

namespace WssConsultingApi.Dto;

public class DivisionDto
{
    [Key]
    public Guid IdDivision { get; init; }
    
    [Required(ErrorMessage = "NameDepartment must be filled")]
    [MaxLength(100, ErrorMessage = "NameDepartment cannot more than 100 characters")]
    public string NameDivision{get; set; }
    
    public DateTime DateTimeCreated { get; }
}
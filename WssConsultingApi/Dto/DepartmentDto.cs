using System.ComponentModel.DataAnnotations;

namespace WssConsultingApi.Dto;

public class DepartmentDto
{
    [Key]
    public Guid IdDepartment { get; init; }
    
    [Required(ErrorMessage = "NameDepartment must be filled")]
    [MaxLength(100, ErrorMessage = "NameDepartment cannot more than 100 characters")]
    public string NameDepartment{get; set; }
    
    public DateTime DateTimeCreated { get; }
}
using System.ComponentModel.DataAnnotations;

namespace WssСonsultingBl.Model;

public class Division
{
    [Key]
    public Guid IdDivision { get; init; }
    
    [Required(ErrorMessage = "NameDepartment must be filled")]
    [MaxLength(100, ErrorMessage = "NameDepartment cannot more than 100 characters")]
    public string NameDivision{get; set; }
    
    public DateTime DateTimeCreated { get; }
    
    public Department Department { get; set; }

    [Obsolete("This constructor only for EF use.")]
    public Division(){}
    
    public Division(Guid id, string name, Department department)
    {
        if(id == Guid.Empty) throw new ArgumentException("Guid cannot be empty.", nameof(id));
        IdDivision = id;
        NameDivision = name;
        DateTimeCreated = DateTime.Now;
        Department = department;
    }
    
}
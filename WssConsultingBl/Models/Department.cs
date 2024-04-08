using System.ComponentModel.DataAnnotations;

namespace WssСonsultingBl.Models;

public class Department
{
    [Key]
    public Guid IdDepartment { get; init; }
    
    [Required(ErrorMessage = "NameDepartment must be filled")]
    [MaxLength(100, ErrorMessage = "NameDepartment cannot more than 100 characters")]
    public string NameDepartment{get; set; }
    
    public DateTime DateTimeCreated { get; }
    
    public Company Company { get; set; }
    
    public List<Division>? Divisions { get; set; }
    
    [Obsolete("This constructor only for EF use.")]
    public Department(){}

    public Department(Guid id, string nameDepartment, Company company, List<Division>? divisions)
    {
        if(id == Guid.Empty) throw new ArgumentException("Guid cannot be empty.", nameof(id));
        IdDepartment = id;
        NameDepartment = nameDepartment;
        Company = company ?? throw new ArgumentException("Company cannot be");
        Divisions = divisions;
        DateTimeCreated = DateTime.Now;
    }
    
    public Department(string nameDepartment, Company company, List<Division> divisions):this(Guid.NewGuid(), nameDepartment, company, divisions)
    {
        
    }
    
}

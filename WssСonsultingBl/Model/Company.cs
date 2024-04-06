using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace WssСonsultingBl.Model;

public class Company
{
    [Key]
    public Guid IdCompany { get; init; }
    
    [Required(ErrorMessage = "NameCompany must be filled")]
    [MaxLength(100, ErrorMessage = "NameCompany cannot more than 100 characters")]
    public string NameCompany { get; set; }
    public DateTime DateTimeCreated { get; }
    
    public List<Department>? Departments { get; set; }
    
    [Obsolete("This constructor only for EF use.")]
    public Company(){}
    
    public Company(Guid idCompany, string nameCompany, List<Department> departments)
    {
        if(idCompany == Guid.Empty) throw new ArgumentException("Guid cannot be empty.", nameof(idCompany));
        IdCompany = idCompany;
        NameCompany = nameCompany;
        DateTimeCreated = DateTime.Now;
        Departments = departments ?? throw new ArgumentNullException(nameof(departments), "cannot be null,");
    }
    
    public Company(string nameCompany, List<Department> departments):this(Guid.NewGuid(), nameCompany, departments){}
    
}
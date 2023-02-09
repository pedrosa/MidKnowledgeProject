using System.ComponentModel.DataAnnotations;

namespace MKP.Domain;

public class Person
{
    [Key]
    public Guid Id { get; set; }
    
    [Required(ErrorMessage = "The field {0} is required.")]
    [MaxLength(50, ErrorMessage = "The max lenght to the field {0} is {1}.")]
    public string Name { get; set; }
    
    public Guid Document { get; set; }
    
    public int Age { get; set; }
}
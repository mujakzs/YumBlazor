namespace YumBlazor.Data;
using System.ComponentModel.DataAnnotations;


public class Category
{
    
    public int Id { get; set; }

    [Required(ErrorMessage = "Please enter name...")]
    public string Name { get; set; }
}

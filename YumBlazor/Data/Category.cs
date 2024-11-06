namespace YumBlazor.Data;
using System.ComponentModel.DataAnnotations;


public class Category
{
    
    public int CatId { get; set; }

    [Required(ErrorMessage = "Please enter name...")]
    public string Name { get; set; }
}

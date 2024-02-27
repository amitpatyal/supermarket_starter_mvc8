using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace supermarket_starter_mvc8.Model.Category
{
  public class Category
  {
    public int categoryId { get; set; }

    [Required]
    [DisplayName("Category Name")]
    public string categoryName { get; set; } = string.Empty;

    [Required]
    [DisplayName("Category Description")]
    public string categoryDescription { get; set; } = string.Empty;
  }
}

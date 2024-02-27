namespace supermarket_starter_mvc8.Model.Category
{
  public class CategoriesRepository
  {
    private static List<Category> _categories = new List<Category>()
    {
      new Category {categoryId = 1, categoryName="Fruits", categoryDescription="All Fruits are listed!"},
      new Category {categoryId = 2, categoryName="Vegetables", categoryDescription="All Vegetables are listed!"},
      new Category {categoryId = 3, categoryName="Bakeries", categoryDescription="All Bakeries are listed!"},
      new Category {categoryId = 4, categoryName="Beverages", categoryDescription="All Beverages are listed!"},
    };

    public static List<Category> GetAllCategories() => _categories;

    public static Category? GetCategoryById(int categoryId)
    {
      var category = _categories.FirstOrDefault(x => x.categoryId.Equals(categoryId));
      if (category != null)
      {
        return category;
        /*return new Category
        {
          categoryId = category.categoryId,
          categoryName = category.categoryName,
          categoryDescription = category.categoryDescription,
        };*/
      }

      return null;
    }

    public static void AddCategory(Category category) {
      category.categoryId = _categories.Max(x => x.categoryId) + 1;
      _categories.Add(category);
    }

    public static void UpdateCategoryById(Category category) {
      var categoryToUpdate = _categories.FirstOrDefault(x => x.categoryId.Equals(category.categoryId));
      if (categoryToUpdate != null)
      {
        categoryToUpdate.categoryName = category.categoryName;
        categoryToUpdate.categoryDescription = category.categoryDescription;
      }
      else
      {
        return;
      }
    }

    public static void RemoveCategoryById(int categoryId)
    {
      var category = _categories.FirstOrDefault(x => x.categoryId.Equals(categoryId));
      if (category != null) { _categories.Remove(category); }
    }
  }
}

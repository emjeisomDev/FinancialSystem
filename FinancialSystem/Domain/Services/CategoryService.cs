using Domain.Interfaces.ICategory;
using Domain.Interfaces.InterfaceServices;
using Entities.Entities;

namespace Domain.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly CategoryInterface _categoryInterface;
        public CategoryService(CategoryInterface categoryInterface) => _categoryInterface = categoryInterface;
        
        public async Task AddCategory(Category category)
        {
            var valid = category.ValidateStringProperty(category.Name, "Name");
            if (valid)
            {
                await _categoryInterface.Add(category);
            }
        }

        public async Task UpdateCategory(Category category)
        {
            var valid = category.ValidateStringProperty(category.Name, "Name");
            if (valid)
            {
                await _categoryInterface.Updade(category);
            }
        }
    }
}

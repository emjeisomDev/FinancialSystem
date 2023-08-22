using Entities.Entities;

namespace Domain.Interfaces.InterfaceServices
{
    public interface ICategoryService
    {
        Task AddCategory(Category category);
        Task UpdateCategory(Category category);
    }
}

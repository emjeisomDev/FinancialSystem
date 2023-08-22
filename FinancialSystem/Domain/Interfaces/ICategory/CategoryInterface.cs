using Domain.Interfaces.Generics;
using Entities.Entities;

namespace Domain.Interfaces.ICategory
{
    public interface CategoryInterface : GenericInterface<Category>
    {
        Task<IList<Category>> ListUserCategory(string userEmail);
    }
}

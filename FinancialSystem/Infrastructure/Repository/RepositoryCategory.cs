using Domain.Interfaces.ICategory;
using Entities.Entities;
using Infrastructure.Repository.Generics;

namespace Infrastructure.Repository
{
    public class RepositoryCategory : RepositoryGeneric<Category>, InterfaceCategory
    {
        public Task<IList<Category>> ListUserCategory(string userEmail)
        {
            throw new NotImplementedException();
        }
    }
}

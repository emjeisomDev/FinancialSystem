using Domain.Interfaces.ICategory;
using Entities.Entities;
using Infrastructure.Configuration;
using Infrastructure.Repository.Generics;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repository
{
    public class CategoryRepository : GenericRepository<Category>, CategoryInterface
    {
        private readonly DbContextOptions<BaseContext> _OptionsBuilder;
        public CategoryRepository() => _OptionsBuilder = new DbContextOptions<BaseContext>();

        public async Task<IList<Category>> ListUserCategory(string userEmail)
        {
            using(var dataBase = new BaseContext(_OptionsBuilder))
            {
                return await (
                    from s in dataBase.FinancialSystem
                    join c in dataBase.Category on s.Id equals c.IdSystem
                    join us in dataBase.UserFinancialSystem on s.Id equals us.IdSystem
                    where us.UserEmail.Equals(userEmail) && us.CurrentSystem
                    select c).AsNoTracking().ToListAsync();
            }
        }
    }
}

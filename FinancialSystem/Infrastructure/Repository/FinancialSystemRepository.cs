using Domain.Interfaces.IFinancialSystem;
using Entities.Entities;
using Infrastructure.Configuration;
using Infrastructure.Repository.Generics;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repository
{
    public class FinancialSystemRepository : GenericRepository<FinancialSystem>, FinancialSystemInterface
    {
        private readonly DbContextOptions<BaseContext> _OptionsBuilder;
        public FinancialSystemRepository() => _OptionsBuilder = new DbContextOptions<BaseContext>();

        public async Task<IList<FinancialSystem>> ListUserSystem(string userEmail)
        {
            using (var dataBase = new BaseContext(_OptionsBuilder))
            {
                return await(
                    from s in dataBase.FinancialSystem
                    join us in dataBase.UserFinancialSystem on s.Id equals us.IdSystem
                    where us.UserEmail.Equals(userEmail)
                    select s).AsNoTracking().ToListAsync();
            }
        }
    }
}

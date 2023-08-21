using Domain.Interfaces.IUserFinancialSystem;
using Entities.Entities;
using Infrastructure.Configuration;
using Infrastructure.Repository.Generics;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repository
{
    public class RepositoryUserFinancialSystem : RepositoryGeneric<UserFinancialSystem>, InterfaceUserFinancialSystem
    {

        private readonly DbContextOptions<BaseContext> _OptionsBuilder;
        public RepositoryUserFinancialSystem() => _OptionsBuilder = new DbContextOptions<BaseContext>();

        public async Task<IList<UserFinancialSystem>> ListUsersSystem(int idSystem)
        {
            using (var dataBase = new BaseContext(_OptionsBuilder))
            {
                return await (
                    dataBase.UserFinancialSystem
                    .Where(s => s.IdSystem == idSystem)
                    ).AsNoTracking().ToListAsync();
            }
        }

        public async Task<UserFinancialSystem> GetUserByEmail(string userEmail)
        {
            using (var dataBase = new BaseContext(_OptionsBuilder))
            {
                return await
                    dataBase.UserFinancialSystem
                    .AsNoTracking()
                    .FirstOrDefaultAsync(x => x.UserEmail.Equals(userEmail));
            }
        }

        public async Task RemoveUsers(List<UserFinancialSystem> users)
        {
            using (var dataBase = new BaseContext(_OptionsBuilder))
            {
                dataBase.UserFinancialSystem
                .RemoveRange(users);

                await dataBase.SaveChangesAsync();
            }
        }
    }
}

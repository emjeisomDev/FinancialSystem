using Domain.Interfaces.IUserFinancialSystem;
using Entities.Entities;
using Infrastructure.Repository.Generics;

namespace Infrastructure.Repository
{
    public class RepositoryUserFinancialSystem : RepositoryGeneric<UserFinancialSystem>, InterfaceUserFinancialSystem
    {
        public Task<UserFinancialSystem> GetUserByEmail(string userEmail)
        {
            throw new NotImplementedException();
        }

        public Task<IList<UserFinancialSystem>> ListUsersSystem(int idSystem)
        {
            throw new NotImplementedException();
        }

        public Task RemoveUsers(List<UserFinancialSystem> users)
        {
            throw new NotImplementedException();
        }
    }
}

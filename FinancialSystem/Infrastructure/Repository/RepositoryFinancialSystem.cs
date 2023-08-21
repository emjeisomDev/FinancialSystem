using Domain.Interfaces.IFinancialSystem;
using Entities.Entities;
using Infrastructure.Repository.Generics;

namespace Infrastructure.Repository
{
    public class RepositoryFinancialSystem : RepositoryGeneric<FinancialSystem>, InterfaceFinancialSystem
    {
        public Task<IList<FinancialSystem>> ListUserSystem(string userEmail)
        {
            throw new NotImplementedException();
        }
    }
}

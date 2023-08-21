using Domain.Interfaces.Generics;
using Entities.Entities;

namespace Domain.Interfaces.IUserFinancialSystem
{
    public interface InterfaceUserFinancialSystem : InterfaceGeneric<UserFinancialSystem>
    {
        Task<IList<UserFinancialSystem>> ListUsersSystem(int idSystem);
        Task RemoveUsers(List<UserFinancialSystem> users);
        Task<UserFinancialSystem> GetUserByEmail(string userEmail);
    }
}

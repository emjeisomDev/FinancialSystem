using Entities.Entities;

namespace Domain.Interfaces.InterfaceServices
{
    public interface IUserFinancialSystemService
    {
        Task AddUserFinancialSystem(UserFinancialSystem userFinancialSystem);
    }
}

using Domain.Interfaces.Generics;
using Entities.Entities;

namespace Domain.Interfaces.IFinancialSystem
{
    public interface InterfaceFinancialSystem : InterfaceGeneric<FinancialSystem>
    {
        Task<IList<FinancialSystem>> ListUserSystem(string userEmail);
    }
}

using Domain.Interfaces.Generics;
using Entities.Entities;

namespace Domain.Interfaces.IFinancialSystem
{
    public interface FinancialSystemInterface : GenericInterface<FinancialSystem>
    {
        Task<IList<FinancialSystem>> ListUserSystem(string userEmail);
    }
}

using Entities.Entities;

namespace Domain.Interfaces.InterfaceServices
{
    public interface IFinancialSystemService
    {
        Task AddFiancialSystem(FinancialSystem financialSystem);
        Task UpdateFiancialSystem(FinancialSystem financialSystem);        
    }
}

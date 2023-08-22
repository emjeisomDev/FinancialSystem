using Domain.Interfaces.IFinancialSystem;
using Domain.Interfaces.InterfaceServices;
using Entities.Entities;

namespace Domain.Services
{
    public class FinancialSystemService : IFinancialSystemService
    {
        private readonly FinancialSystemInterface _financialSystemInterface;
        public FinancialSystemService(FinancialSystemInterface financialSystemInterface)
            => _financialSystemInterface = financialSystemInterface;

        public async Task AddFiancialSystem(FinancialSystem financialSystem)
        {
            var valid = financialSystem.ValidateStringProperty(financialSystem.Name, "Name");
            if (valid)
            {
                var date = DateTime.UtcNow;
                financialSystem.DueDate = 1;
                financialSystem.Year = date.Year;
                financialSystem.Month = date.Month;
                financialSystem.YearCopy = date.Year;
                financialSystem.MonthCopy = date.Month;
                financialSystem.GenerateCopyExpense = true;

                await _financialSystemInterface.Add(financialSystem);
            }
        }

        public async Task UpdateFiancialSystem(FinancialSystem financialSystem)
        {
            var valid = financialSystem.ValidateStringProperty(financialSystem.Name, "Name");
            if (valid)
            {
                financialSystem.DueDate = 1;
                await _financialSystemInterface.Updade(financialSystem);
            }
        }



    }
}

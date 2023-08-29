using Entities.Entities;

namespace Domain.Interfaces.InterfaceServices
{
    public interface IExpenseService
    {
        Task AddExpense(Expense expense);
        Task UpdateExpense(Expense expense);
        Task<object> LoadCharts(string userEmail);
    }
}

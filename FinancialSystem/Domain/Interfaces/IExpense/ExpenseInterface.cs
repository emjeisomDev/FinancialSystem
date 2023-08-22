using Domain.Interfaces.Generics;
using Entities.Entities;

namespace Domain.Interfaces.IExpense
{
    public interface ExpenseInterface : GenericInterface<Expense>
    {
        Task<IList<Expense>> ListUserExpense(string userEmail);
        Task<IList<Expense>> ListUserExpenseUnpaidPreviousMonth(string userEmail);
    }
}

using Domain.Interfaces.ICategory;
using Domain.Interfaces.IExpense;
using Domain.Interfaces.InterfaceServices;
using Entities.Entities;

namespace Domain.Services
{
    public class ExpenseService : IExpenseService
    {
        private readonly ExpenseInterface _expenseInterface;
        public ExpenseService(ExpenseInterface expenseInterface) => _expenseInterface = expenseInterface;

        public async Task AddExpense(Expense expense)
        {
            var date = DateTime.UtcNow;
            expense.RegistrationDate = date;
            expense.Year = date.Year;
            expense.Month = date.Month;

            var valid = expense.ValidateStringProperty(expense.Name, "Name");
            if (valid)
            { 
                await _expenseInterface.Add(expense); 
            }
        }

        public async Task UpdateExpense(Expense expense)
        {
            var date = DateTime.UtcNow;
            expense.ChangeDate = date;

            if(expense.Paid)
            {
                expense.PaymentDate = date;
            }

            var valid = expense.ValidateStringProperty(expense.Name, "Name");
            if (valid)
            {
                await _expenseInterface.Updade(expense);
            }
        }
    }
}

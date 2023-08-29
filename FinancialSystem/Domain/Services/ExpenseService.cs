using Domain.Interfaces.ICategory;
using Domain.Interfaces.IExpense;
using Domain.Interfaces.InterfaceServices;
using Entities.Entities;

namespace Domain.Services
{
    public class ExpenseService : IExpenseService
    {
        private readonly ExpenseInterface _ExpenseInterface;
        public ExpenseService(ExpenseInterface expenseInterface) => _ExpenseInterface = expenseInterface;

        public async Task AddExpense(Expense expense)
        {
            var date = DateTime.UtcNow;
            expense.RegistrationDate = date;
            expense.Year = date.Year;
            expense.Month = date.Month;

            var valid = expense.ValidateStringProperty(expense.Name, "Name");
            if (valid)
            { 
                await _ExpenseInterface.Add(expense); 
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
                await _ExpenseInterface.Updade(expense);
            }
        }

        public async Task<object> LoadCharts(string userEmail)
        {
            var expenseUser = await _ExpenseInterface.ListUserExpense(userEmail);
            var previousExpenses = await _ExpenseInterface.ListUserExpenseUnpaidPreviousMonth(userEmail);

            var paidExpense = expenseUser
                .Where(e => e.Paid && e.TypeExpense == Entities.Enums.EnumTypeExpense.Bills)
                .Sum(x => x.Value);

            var outstanding_expense = expenseUser
                .Where(e => !e.Paid && e.TypeExpense == Entities.Enums.EnumTypeExpense.Bills)
                .Sum(x => x.Value);

            var expenses_unpaidPreviousMonths = previousExpenses.Any() ?
                previousExpenses.ToList().Sum(x => x.Value) : 0;

            var investment = expenseUser
                .Where(e => e.TypeExpense == Entities.Enums.EnumTypeExpense.Investing)
                .Sum(x => x.Value);

            return new
            {
                sucess = "Ok",
                paidExpense = paidExpense,
                outstanding_expense = outstanding_expense,
                expenses_unpaidPreviousMonths = expenses_unpaidPreviousMonths,
                investment = investment
            };
        }


    }
}

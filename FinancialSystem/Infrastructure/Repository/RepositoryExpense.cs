using Domain.Interfaces.IExpense;
using Entities.Entities;
using Infrastructure.Repository.Generics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public class RepositoryExpense : RepositoryGeneric<Expense>, InterfaceExpense
    {
        public Task<IList<Expense>> ListUserExpense(string userEmail)
        {
            throw new NotImplementedException();
        }

        public Task<IList<Expense>> ListUserExpenseUnpaidPreviousMonth(string userEmail)
        {
            throw new NotImplementedException();
        }
    }
}

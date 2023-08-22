using Domain.Interfaces.IExpense;
using Entities.Entities;
using Infrastructure.Configuration;
using Infrastructure.Repository.Generics;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public class ExpenseRepository : GenericRepository<Expense>, ExpenseInterface
    {

        private readonly DbContextOptions<BaseContext> _OptionsBuilder;
        public ExpenseRepository() => _OptionsBuilder = new DbContextOptions<BaseContext>();

        public async Task<IList<Expense>> ListUserExpense(string userEmail)
        {
            using (var dataBase = new BaseContext(_OptionsBuilder))
            {
                return await (
                    from s in dataBase.FinancialSystem
                    join c in dataBase.Category on s.Id equals c.IdSystem
                    join us in dataBase.UserFinancialSystem on s.Id equals us.IdSystem
                    join d in dataBase.Expense on c.Id equals d.IdCategory
                    where us.UserEmail.Equals(userEmail) && s.Month == d.Month && s.Year == d.Year
                    select d).AsNoTracking().ToListAsync();
            }
        }

        public async Task<IList<Expense>> ListUserExpenseUnpaidPreviousMonth(string userEmail)
        {
            using (var dataBase = new BaseContext(_OptionsBuilder))
            {
                return await (
                    from s in dataBase.FinancialSystem
                    join c in dataBase.Category on s.Id equals c.IdSystem
                    join us in dataBase.UserFinancialSystem on s.Id equals us.IdSystem
                    join d in dataBase.Expense on c.Id equals d.IdCategory
                    where us.UserEmail.Equals(userEmail) && d.Month < DateTime.Now.Month && !d.Paid
                    select d).AsNoTracking().ToListAsync();
            }
        }
    }
}

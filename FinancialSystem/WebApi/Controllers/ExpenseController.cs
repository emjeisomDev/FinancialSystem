using Domain.Interfaces.ICategory;
using Domain.Interfaces.IExpense;
using Domain.Interfaces.InterfaceServices;
using Domain.Services;
using Entities.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ExpenseController : ControllerBase
    {
        private readonly ExpenseInterface _ExpenseInterface;
        private readonly IExpenseService _IExpenseService;

        public ExpenseController(
            ExpenseInterface ExpenseInterface, 
            IExpenseService IExpenseService)
        {
            _ExpenseInterface = ExpenseInterface;
            _IExpenseService = IExpenseService;
        }

        [HttpGet("/api/ListUserExpense")]
        [Produces("application/json")]
        public async Task<object> ListUserExpense(string userEmail) 
            => await _ExpenseInterface.ListUserExpense(userEmail);

        [HttpGet("/api/GetExpenseById")]
        [Produces("application/json")]
        public async Task<object> GetExpenseById(int id) 
            => await _ExpenseInterface.GetEntityById(id);

        [HttpGet("/api/LoadCharts")]
        [Produces("application/json")]
        public async Task<object> LoadCharts(string userEmail)
        {
            return await _IExpenseService.LoadCharts(userEmail);
        }

        [HttpPost("/api/AddExpense")]
        [Produces("application/json")]
        public async Task<object> AddExpense(Expense expense)
        {
            await _IExpenseService.AddExpense(expense);
            return expense;
        }

        [HttpPut("/api/UpdateExpense")]
        [Produces("application/json")]
        public async Task<object> UpdateExpense(Expense expense)
        {
            await _IExpenseService.UpdateExpense(expense);
            return expense;
        }

        [HttpDelete("/api/DeleteExpense")]
        [Produces("application/json")]
        public async Task<object> DeleteExpense(int id)
        {
            try
            {
                var expense = await _ExpenseInterface.GetEntityById(id);
                await _ExpenseInterface.Delete(expense);
            }
            catch (Exception)
            {
                return false;
            }

            return true;

        }

    }
}

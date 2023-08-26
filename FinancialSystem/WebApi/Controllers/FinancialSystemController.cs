using Domain.Interfaces.IFinancialSystem;
using Domain.Interfaces.InterfaceServices;
using Entities.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class FinancialSystemController : ControllerBase
    {
        private readonly FinancialSystemInterface _FinancialSystemInterface;
        private readonly IFinancialSystemService _IFinancialSystemService;

        public FinancialSystemController(
            FinancialSystemInterface FinancialSystemInterface, 
            IFinancialSystemService IFinancialSystemService)
        {
            _FinancialSystemInterface = FinancialSystemInterface;
            _IFinancialSystemService = IFinancialSystemService;
        }

        [HttpGet("/api/ListUserSystem")]
        [Produces("application/json")]
        public async Task<object> ListUserSystem(string userEmail)
            => await _FinancialSystemInterface.ListUserSystem(userEmail);

        [HttpGet("/api/GetEntityById")]
        [Produces("application/json")]
        public async Task<object> GetEntityById(int id)
            => await _FinancialSystemInterface.GetEntityById(id);

        [HttpPost("/api/AddFiancialSystem")]
        [Produces("application/json")]
        public async Task<object> AddFiancialSystem(FinancialSystem financialSystem)
        {
            await _IFinancialSystemService.AddFiancialSystem(financialSystem);
            return Task.FromResult(financialSystem);
        }

        [HttpPut("/api/UpdateFiancialSystem")]
        [Produces("application/json")]
        public async Task<object> UpdateFiancialSystem(FinancialSystem financialSystem)
        {
            await _IFinancialSystemService.UpdateFiancialSystem(financialSystem);
            return Task.FromResult(financialSystem);
        }

        [HttpDelete("/api/DeleteFiancialSystem")]
        [Produces("application/json")]
        public async Task<object> DeleteFiancialSystem(int id)
        {
            try
            {
                var financialSystem = await _FinancialSystemInterface.GetEntityById(id);
                await _FinancialSystemInterface.Delete(financialSystem);
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }





    }
}

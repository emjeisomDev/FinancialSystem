using Domain.Interfaces.InterfaceServices;
using Domain.Interfaces.IUserFinancialSystem;
using Entities.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class UserFinancialSystemController : ControllerBase
    {
        private readonly UserFinancialSystemInterface _UserFinancialSystemInterface;
        private readonly IUserFinancialSystemService _IUserFinancialSystemService;

        public UserFinancialSystemController(
            UserFinancialSystemInterface UserFinancialSystemInterface, 
            IUserFinancialSystemService IUserFinancialSystemService)
        {
            _UserFinancialSystemInterface = UserFinancialSystemInterface;
            _IUserFinancialSystemService = IUserFinancialSystemService;
        }

        [HttpGet("/api/ListUsersSystem")]
        [Produces("application/json")]
        public async Task<object> ListUsersSystem(int idSystem) 
            => await _UserFinancialSystemInterface.ListUsersSystem(idSystem);

        [HttpPost("/api/AddUserFinancialSystem")]
        [Produces("application/json")]
        public async Task<object> AddUserFinancialSystem(int idSystem, string userEmail)
        {
            try
            {
                await _IUserFinancialSystemService.AddUserFinancialSystem(
                        new UserFinancialSystem
                        {
                            IdSystem = idSystem,
                            UserEmail = userEmail,
                            Admin = false,
                            CurrentSystem = true
                        });
            }
            catch (Exception)
            {
                return Task.FromResult(false);
            }
            return Task.FromResult(true);
        }

        [HttpDelete("/api/DeleteUserFinancialSystem")]
        [Produces("application/json")]
        public async Task<object> DeleteUserFinancialSystem(int idSystem)
        {
            try
            {
                var userFinancialSystem = await _UserFinancialSystemInterface.GetEntityById(idSystem);
                await _UserFinancialSystemInterface.Delete(userFinancialSystem);
            }
            catch (Exception)
            {
                return Task.FromResult(false);
            }
            return Task.FromResult(true);
        }



    }
}

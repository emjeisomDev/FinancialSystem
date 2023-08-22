using Domain.Interfaces.InterfaceServices;
using Domain.Interfaces.IUserFinancialSystem;
using Entities.Entities;

namespace Domain.Services
{
    public class UserFinancialSystemService : IUserFinancialSystemService
    {
        private readonly UserFinancialSystemInterface _userFinancialSystemInterface;
        public UserFinancialSystemService(UserFinancialSystemInterface userFinancialSystemInterface) =>
            _userFinancialSystemInterface = userFinancialSystemInterface;

        public async Task AddUserFinancialSystem(UserFinancialSystem userFinancialSystem)
        {
            await _userFinancialSystemInterface.Add(userFinancialSystem);
        }
    }
}

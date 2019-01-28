using System.Threading.Tasks;
using Abp.Application.Services;
using Austine.Test.Authorization.Accounts.Dto;

namespace Austine.Test.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}

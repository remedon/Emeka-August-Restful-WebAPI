using System.Threading.Tasks;
using Abp.Application.Services;
using Austine.Test.Sessions.Dto;

namespace Austine.Test.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}

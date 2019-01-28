using Abp.Application.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Austine.Test.Domain
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IList<Account>> GetAllAccounts();

        Task<Account> GetAccount(int Id);
    }
}


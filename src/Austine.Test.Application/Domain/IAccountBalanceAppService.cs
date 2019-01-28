using Abp.Application.Services;
using Austine.Test.Domain.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Austine.Test.Domain
{
    public interface IAccountBalanceAppService : IApplicationService
    {
        Task<IList<AccountBalanceDto>> GetAllAccountBalances(GetAccountBalanceDto dto);
    }
}

using Abp.Application.Services;
using Abp.Domain.Repositories;
using Austine.Test.Domain.Dto;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Austine.Test.Domain
{
    public class AccountBalanceAppService : ApplicationService, IAccountBalanceAppService
    {
        private readonly IRepository<AccountBalance, long> _accountBalanceRepository;

        public AccountBalanceAppService(IRepository<AccountBalance, long> accountBalanceRepository)
        {
            _accountBalanceRepository = accountBalanceRepository;
        }

        public async Task<IList<AccountBalanceDto>> GetAllAccountBalances(GetAccountBalanceDto dto)
        {
            var list = await _accountBalanceRepository.GetAll()
                .Include(x => x.Account)
                .Where(x => x.Account.Name.Contains(dto.AccountName) || string.IsNullOrEmpty(dto.AccountName))
                .Where(x => x.Account.Number.Contains(dto.AccountNumber) || string.IsNullOrEmpty(dto.AccountNumber))
                .ToListAsync();
            return ObjectMapper.Map<IList<AccountBalanceDto>>(list);
        }
    }
}

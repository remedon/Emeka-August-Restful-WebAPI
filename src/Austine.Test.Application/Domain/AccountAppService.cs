using Abp.Application.Services;
using Abp.Authorization;
using Abp.Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

namespace Austine.Test.Domain
{
    [AbpAuthorize()]
    public class AccountAppService : ApplicationService, IAccountAppService
    {
        private readonly IRepository<Account, long> _accountRepository;

        public AccountAppService(IRepository<Account, long> accountRepository)
        {
            _accountRepository = accountRepository;
        }

        public async Task<Account> GetAccount(int Id)
        {
            return await _accountRepository.GetAsync(Id);
        }

        public async Task<IList<Account>> GetAllAccounts()
        {
            return await _accountRepository.GetAll().ToListAsync();
        }
    }
}

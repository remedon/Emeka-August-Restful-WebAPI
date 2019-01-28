using Austine.Test.Domain;
using Austine.Test.Domain.Dto;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Austine.Test.Controllers
{
    [Route("api/[controller]/[action]")]
    public class AccountsController : TestControllerBase
    {
        private readonly IAccountAppService _accountService;
        private readonly IAccountBalanceAppService _accountBalanceService;

        public AccountsController(
            IAccountAppService accountService,
            IAccountBalanceAppService accountBalanceService
            )
        {
            _accountService = accountService;
            _accountBalanceService = accountBalanceService;
        }

        [HttpGet]
        public async Task<IList<Account>> GetAll()
        {
            return await _accountService.GetAllAccounts();
        }

        [HttpGet]
        public async Task<Account> Get(int Id)
        {
            return await _accountService.GetAccount(Id);
        }

        [HttpGet]
        public async Task<IList<AccountBalanceDto>> GetBalances(GetAccountBalanceDto dto)
        {
            return await _accountBalanceService.GetAllAccountBalances(dto);
        }
    }
}

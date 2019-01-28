using Abp.AutoMapper;
using Austine.Test.Authorization.Users;
using System;
using System.Collections.Generic;
using System.Text;

namespace Austine.Test.Domain.Dto
{
    [AutoMapFrom(typeof(AccountBalance))]
    public class AccountBalanceDto
    {
        public int AccountId { get; set; }

        public string AccountNumber { get; set; }

        public string AccountType { get; set; }

        public string AccountName { get; set; }

        public string AccountStatus { get; set; }

        public decimal? Balance { get; set; }

        public decimal? Overdraft { get; set; }
    }
}

using AutoMapper;
using System.Text.RegularExpressions;

namespace Austine.Test.Domain.Dto
{
    public class AccountsMapProfile : Profile
    {
        public AccountsMapProfile()
        {
            CreateMap<AccountBalance, AccountBalanceDto>()
                .ForMember(x => x.AccountId, opt => opt.MapFrom(src => src.AccountId))
                .ForMember(x => x.AccountName, opt => opt.MapFrom(src => src.Account.Name))
                .ForMember(x => x.AccountNumber, opt => opt.MapFrom(src => Regex.Match(src.Account.Number, @"(.{4})\s*$")))
                .ForMember(x => x.AccountType, opt => opt.MapFrom(src => src.Account.Type))
                .ForMember(x => x.AccountStatus, opt => opt.MapFrom(src => src.Account.Status))
                .ForMember(x => x.Balance, opt => opt.MapFrom(src => src.Balance))
                .ForMember(x => x.Overdraft, opt => opt.MapFrom(src => src.Overdraft));
        }
    }
}

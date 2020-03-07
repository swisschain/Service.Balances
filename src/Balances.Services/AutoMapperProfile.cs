using AutoMapper;
using Balances.Domain.Entities;
using MatchingEngine.Client.Models.Balances;

namespace Balances.Services
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<BalanceModel, Balance>(MemberList.Source);
        }
    }
}

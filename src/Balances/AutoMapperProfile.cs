using System.Globalization;
using AutoMapper;
using Balances.Client.Models.Wallets;
using Balances.Domain.Entities;
using Google.Protobuf.WellKnownTypes;

namespace Balances
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Balance, BalanceModel>(MemberList.Source);

            CreateMap<Balance, Service.Balances.Contracts.Balance>(MemberList.Destination)
                .ForMember(dest => dest.Amount,
                    opt => opt.MapFrom(src => src.Amount.ToString(CultureInfo.InvariantCulture)))
                .ForMember(dest => dest.Reserved,
                    opt => opt.MapFrom(src => src.Reserved.ToString(CultureInfo.InvariantCulture)))
                .ForMember(dest => dest.Timestamp,
                    opt => opt.MapFrom(src => src.Timestamp.ToTimestamp()));
        }
    }
}

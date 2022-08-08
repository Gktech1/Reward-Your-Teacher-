using System;
using AutoMapper;
using Wallet.Dtos;
using Wallet.Model;

namespace Wallet.API.Mappings
{
    public class MappingConfiguration
    {

        public static MapperConfiguration RegisterMap()
        {
            var mappingConfig = new MapperConfiguration(Config =>
            Config.CreateMap<UserWalletDto, UserWallet>().ReverseMap()
            
            );

           

            return mappingConfig;
        }
    }
}

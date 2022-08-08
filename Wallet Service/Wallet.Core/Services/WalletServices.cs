﻿using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Wallet.Model;
using Wallet.Data;
using Microsoft.AspNetCore.Mvc;
using Wallet.Core.Interfaces;
using Wallet.Core.Repository;
using System.Threading.Tasks;
using Wallet.Dtos;
using System.Web.Mvc;
using AutoMapper;
using Wallet.Core;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Wallet.API.Services
{

    public class WalletServices : IWalletServices
    {
       // private readonly ILogger _logger;
        //private readonly WalletServices _walletServices;
        private readonly IMapper _mapper;
        private readonly AppDbContext _Db;
        private IResponseFactory _responseService;

        private WalletRepository _walletRepository;

        public WalletServices( IMapper mapper,
                                      AppDbContext Db, IResponseFactory responseFactory)
        {
            _mapper = mapper;
            
            _responseService = responseFactory;
            _Db = Db;
        }

        public async Task<ExecutionResponse<UserWalletDto>> CreateWalletAsync(UserWalletDto userWallet)
        {

            var wallet = _Db.Wallets.Where(x=> x.UserId == userWallet.UserId);

            if (wallet.Any())
            {
                return _responseService.ExecutionResponse<UserWalletDto>("Wallet Already Exists", userWallet, false, 400);

            }
            var mappWallet = _mapper.Map<UserWalletDto, UserWallet>(userWallet);
             _Db.Wallets.Add(mappWallet);
            
            await _Db.SaveChangesAsync();
            return _responseService.ExecutionResponse<UserWalletDto>("Wallet Successfully Created", userWallet, true, 200);
        }
    }
}


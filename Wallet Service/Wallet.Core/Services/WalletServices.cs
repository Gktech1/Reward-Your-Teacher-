using System;
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

            public WalletServices(IMapper mapper,
                                          AppDbContext Db, IResponseFactory responseFactory)
        {
            _mapper = mapper;

            _responseService = responseFactory;
            _Db = Db;
        }

        public async Task<ExecutionResponse<UserWalletUpdateDto>> ActivateWallet(int UserId)
        {
            var wallet = await _Db.Wallets.Where(x => x.UserId == UserId).FirstOrDefaultAsync();
            if (wallet == null)
            {
                return _responseService.ExecutionResponse<UserWalletUpdateDto>("Wallet not found", null, false, 400);
            }
            else
            {
                if (wallet.Status == true)
                {
                    return _responseService.ExecutionResponse<UserWalletUpdateDto>("Wallet already activated", null, false, 400);
                }
                else
                {
                    wallet.Status = true;
                    var userWalletDtoToReturn = _mapper.Map<UserWalletUpdateDto>(wallet);
                    await _Db.SaveChangesAsync();
                    return _responseService.ExecutionResponse<UserWalletUpdateDto>("Wallet activated", userWalletDtoToReturn, true, 200);
                }

            }
        }

        public async Task<ExecutionResponse<UserWalletDto>> CreateWalletAsync(UserWalletDto userWallet)
        {

            var wallet = _Db.Wallets.Where(x => x.UserId == userWallet.UserId);

            if (wallet.Any())
            {
                return _responseService.ExecutionResponse<UserWalletDto>("Wallet Already Exists", userWallet, false, 400);

            }
            var mappWallet = _mapper.Map<UserWalletDto, UserWallet>(userWallet);
            _Db.Wallets.Add(mappWallet);

            await _Db.SaveChangesAsync();
            return _responseService.ExecutionResponse<UserWalletDto>("Wallet Successfully Created", userWallet, true, 200);

        }

        public async Task<ExecutionResponse<UserWalletDto>> GetUserWalletAsync(int userId)
        {
            var wallet = await _Db.Wallets.Where(x => x.UserId == userId).FirstOrDefaultAsync();
            if(wallet == null)
            {
                return _responseService.ExecutionResponse<UserWalletDto>("Wallet does not exist", null, false, 400);
            }
            var mapWallet = _mapper.Map<UserWallet,UserWalletDto>(wallet);
            return _responseService.ExecutionResponse<UserWalletDto>("Wallet Found", mapWallet, true, 200);
        }

        public async Task<ExecutionResponse<UserWalletUpdateDto>> DeactivateWallet(int userId)
        {
            var wallet = await _Db.Wallets.Where(x => x.UserId == userId).FirstOrDefaultAsync();
            if (wallet == null)
            {
                return _responseService.ExecutionResponse<UserWalletUpdateDto>("Wallet not found", null, false, 400);
            }
            else
            {
                if (wallet.Status == false)
                {
                    return _responseService.ExecutionResponse<UserWalletUpdateDto>("Wallet already deactivated", null, false, 400);
                }
                else
                {
                    wallet.Status = false;
                    var userWalletDtoToReturn = _mapper.Map<UserWalletUpdateDto>(wallet);
                    _Db.SaveChanges();
                    return _responseService.ExecutionResponse<UserWalletUpdateDto>("Wallet deactivated", userWalletDtoToReturn, true, 200);
                }

            }
        }
    }
}


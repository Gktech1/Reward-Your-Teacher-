using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wallet.Core.Interfaces;
using Wallet.Core.Repository;
using Wallet.Data;
using Wallet.Dtos;
using Wallet.Model;

namespace Wallet.Core.Services
{
    public class BankServices : IBankServices
    {
        private readonly IMapper _mapper;
        private readonly AppDbContext _Db;
        private IResponseFactory _responseService;
        public BankServices(IMapper mapper,
                                      AppDbContext Db, IResponseFactory responseFactory)
        {
            _mapper = mapper;
            _Db = Db;
            _responseService = responseFactory;
        }
        public async Task<ExecutionResponse<AccountDetailDto>> CreateBankAsync(AccountDetailDto accountDetailDto)
        {
            var account = _mapper.Map<AccountDetail>(accountDetailDto);

            _Db.Add(account);
            await _Db.SaveChangesAsync();
            var accountToReturn = _mapper.Map < AccountDetailDto >(account);

            return _responseService.ExecutionResponse<AccountDetailDto>("Bank Account created", accountToReturn, true, 200);
        }

        public async Task<ExecutionResponse<AccountDetailDto>> DeleteBankAsync(int accountId, int userId)
        {
            var account = _Db.AccountDetails.FirstOrDefault(x => x.UserId == accountId && x.Id == userId);
            if(account == null)
            {
                return _responseService.ExecutionResponse<AccountDetailDto>("Bank account details does not exist", null, false, 400);
            }
            var accountDetailMapping = _mapper.Map<AccountDetailDto>(account);
            _Db.Remove(accountDetailMapping);
            return _responseService.ExecutionResponse<AccountDetailDto>("Bank account detail deleted", accountDetailMapping, true, 200);

        }

        public async Task<ExecutionResponse<AccountDetailDto>> GetBankAsync(int accountId, int userId)
        {
            var account =  _Db.AccountDetails.FirstOrDefault(x => x.UserId == accountId && x.Id == userId);
            if(account == null)
            {
                return _responseService.ExecutionResponse<AccountDetailDto>("Bank account details does not exist", null, false, 400);
            }
            var accountToReturn = _mapper.Map<AccountDetailDto>(account);
            return _responseService.ExecutionResponse<AccountDetailDto>("Bank account detail found", null, true, 200);
        }

        private int GetAccountId(int accountId) => _Db.AccountDetails.FirstOrDefault(x => x.Id == accountId).Id;
        
    }
}

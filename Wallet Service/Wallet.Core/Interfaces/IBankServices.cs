using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wallet.Dtos;

namespace Wallet.Core.Interfaces
{
    public interface IBankServices
    {
        Task<ExecutionResponse<AccountDetailDto>> CreateBankAsync(AccountDetailDto accountDetailDto);
        Task<ExecutionResponse<AccountDetailDto>> DeleteBankAsync(int accountId, int userId);
        Task<ExecutionResponse<AccountDetailDto>> GetBankAsync(int accountId, int userId);

    }
}

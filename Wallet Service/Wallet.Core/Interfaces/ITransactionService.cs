using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wallet.Dtos;
using Wallet.Model;
using Wallet.Utilties.Requests;

namespace Wallet.Core.Interfaces
{
    public interface ITransactionService
    {
        Task CreateFundingTransactionAsync(string txRef, string amount, string userId);
        Task<ExecutionResponse<UserTransactionDto>> CreateWalletToWalletTransactionAsync(Guid senderWalletId,
           Guid receiverWalletId, int amount, string description);//charges could be set for this transfer
        Task<UserTransaction> GetTransactionAsync(string txRef);
        Task UpdateTransaction(UserTransaction transaction);
        Task<PagedExecutionResponse<IEnumerable<UserTransactionDto>>> GetTransactionsForWallet(Guid id, int pageNumber, int pageSize,
            DateTime searchDate);
    }
}

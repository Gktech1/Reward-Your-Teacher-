﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wallet.Model;

namespace Wallet.Core.Interfaces
{
    public interface ITransactionService
    {
        Task CreateFundingTransactionAsync(string txRef, string amount, int userId);
        Task CreateWalletToWalletTransactionAsync(int senderWalletId, int receiverWalletId, int amount);//charges could be set for this transfer
        Task<UserTransaction> GetTransactionAsync(string txRef);
        Task UpdateTransaction(UserTransaction transaction);
    }
}

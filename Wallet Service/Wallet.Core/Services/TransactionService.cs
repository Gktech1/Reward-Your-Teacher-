using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wallet.Core.Interfaces;
using Wallet.Data;
using Wallet.Model;

namespace Wallet.Core.Services
{
    public class TransactionService : ITransactionService
    {
        private readonly AppDbContext _db;

        public TransactionService(AppDbContext db)
        {
            _db = db;
        }

        public async Task CreateFundingTransactionAsync(string txRef, string amount, string userId)
        {
            var transaction = new UserTransaction();
            var userWalletId = GetWalletId(userId);
            transaction.Amount = amount;
            transaction.TransactionReference = txRef;
            transaction.WalletId = userWalletId;
            _db.Transactions.Add(transaction);
            await _db.SaveChangesAsync();
        }

        public Task CreateWalletToWalletTransactionAsync(Guid senderWalletId, Guid receiverWalletId, int amount)
        {
            throw new NotImplementedException();
        }

        public Task<UserTransaction> GetTransactionAsync(string txRef) => 
            _db.Transactions.FirstOrDefaultAsync(x => x.TransactionReference.Equals(txRef));

        public async Task UpdateTransaction(UserTransaction transaction)
        {
            _db.Transactions.Update(transaction);
            await _db.SaveChangesAsync();
        }  

        private Guid GetWalletId(string userId) =>
            _db.Wallets.FirstOrDefault(x => x.UserId == userId).Id;
    }
}

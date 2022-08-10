using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wallet.Core.Interfaces;
using Wallet.Data;
using Wallet.Dtos.PaymentDtos;
using Wallet.Model.Enums;
using Wallet.Utilties;
using Wallet.Utilties.Requests;

namespace Wallet.Core.Services
{
    public class PayStackService : IPayStackService
    {
        private readonly IConfiguration _config;
        private readonly IHttpService _httpService;
        private readonly ITransactionService _txService;
        private readonly AppDbContext _db;
        private readonly UrlConfiguration _walletOptions;

        public PayStackService(IConfiguration config, IHttpService httpService, 
            IOptionsSnapshot<UrlConfiguration> walletoptions, ITransactionService txService, AppDbContext db)
        {
            _config = config;
            _httpService = httpService;
            _txService = txService;
            _db = db;
            //_walletOptions = walletoptions.Value;
        }

        public Task<bool> ConfirmTransactionById(string transactionId)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> ConfirmTransactionByRef(string txRef)
        {
            var request = new GetRequest();
            request.Url = $"https://api.paystack.co/transaction/verify/{txRef}";
            request.AccessToken = _config["WalletApi:Key"];
            var response = await _httpService.SendGetRequest<PayStackTransactionDto>(request);
            var tx = await _txService.GetTransactionAsync(txRef);

            if (response.Data.Status == "success" )
            {
                var wallet = _db.Wallets.FirstOrDefault(x => x.Id.Equals(tx.WalletId));
                wallet.Balance += Convert.ToInt32(tx.Amount);
                tx.Status = TransactionStatus.Success;
                tx.Updated = DateTime.Now;
                await _db.SaveChangesAsync();
                return true;
            }
            return false;

        }

        public async Task<PayStackLinkResponseDto> GetPaymentLink(PayStackPaymentDto details, string userId)
        {
            var request = new JsonContentPostRequest<PayStackPaymentDto>();
            details.Amount = details.Amount + "00";
            request.Data = details;
            request.Url = "https://api.paystack.co/transaction/initialize";
            request.AccessToken = _config["WalletApi:Key"]; ;

            var response = await _httpService.SendPostRequest<PayStackLinkResponseDto, PayStackPaymentDto>(request);
            if (response.Status == "true")
                await _txService.CreateFundingTransactionAsync(response.Data.Reference, details.Amount, userId);
     
            return response;
        }


    }
}

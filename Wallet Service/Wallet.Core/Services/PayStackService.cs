using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wallet.Core.Interfaces;
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
        private readonly UrlConfiguration _walletOptions;

        public PayStackService(IConfiguration config, IHttpService httpService, 
            IOptionsSnapshot<UrlConfiguration> walletoptions, ITransactionService txService)
        {
            _config = config;
            _httpService = httpService;
            _txService = txService;
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
            if (response.Data.Status == "success")
            {
                var tx = await _txService.GetTransactionAsync(txRef);
                tx.Status = TransactionStatus.Success;
                tx.Updated = DateTime.Now;
                await _txService.UpdateTransaction(tx);
                return true;
            }
            return false;

        }

        public async Task<PayStackLinkResponseDto> GetPaymentLink(PayStackPaymentDto details, string userId)
        {
            var request = new JsonContentPostRequest<PayStackPaymentDto>();
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
